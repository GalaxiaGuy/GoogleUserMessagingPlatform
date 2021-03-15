using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Google.UserMesssagingPlatform;
using static Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class UserMessagingPlatform :
        Java.Lang.Object,
        IConsentInformationOnConsentInfoUpdateSuccessListener,
        IConsentInformationOnConsentInfoUpdateFailureListener,
        IOnConsentFormLoadSuccessListener,
        IOnConsentFormLoadFailureListener,
        IConsentFormOnConsentFormDismissedListener
    {
        private IConsentInformation? _consentInformation;

        public bool IsSupported => true;

        public IConsentForm? Form { get; private set; }

        public Task<ConsentInformation> GetConsentInformationAsync(RequestParameters parameters)
        {
            _ = _consentInformationCompletionSource?.TrySetCanceled();
            _consentInformationCompletionSource = new TaskCompletionSource<ConsentInformation>();
            _consentInformation = GetConsentInformation(Platform.CurrentActivity);
            _consentInformation.RequestConsentInfoUpdate(Platform.CurrentActivity, parameters.ToPlatform(), this, this);
            return _consentInformationCompletionSource.Task;
        }

        void IConsentInformationOnConsentInfoUpdateSuccessListener.OnConsentInfoUpdateSuccess()
        {
            if (_consentInformation == null)
            {
                _ = _consentInformationCompletionSource.TrySetException(ConsentException.UnknownError);
            }
            else
            {
                var info = new ConsentInformation(
                    _consentInformation.ConsentStatus.ToConsentStatus(),
                    _consentInformation.ConsentType.ToConsentType(),
                    _consentInformation.IsConsentFormAvailable ? FormStatus.Available : FormStatus.Unavailable);
                _ = _consentInformationCompletionSource.TrySetResult(info);
            }
        }

        void IConsentInformationOnConsentInfoUpdateFailureListener.OnConsentInfoUpdateFailure(FormError formError)
        {
            _ = _consentInformationCompletionSource.TrySetException(new ConsentException(formError));
        }

        public Task LoadConsentFormAsync()
        {
            _ = _loadConsentFormCompletionSource.TrySetCanceled();
            _loadConsentFormCompletionSource = new TaskCompletionSource<bool>();
            LoadConsentForm(Platform.CurrentActivity, this, this);
            return _loadConsentFormCompletionSource.Task;
        }

        void IOnConsentFormLoadSuccessListener.OnConsentFormLoadSuccess(IConsentForm form)
        {
            Form = form;
            _ = _loadConsentFormCompletionSource.TrySetResult(true);
        }

        void IOnConsentFormLoadFailureListener.OnConsentFormLoadFailure(FormError formError)
        {
            _ = _loadConsentFormCompletionSource.TrySetException(new ConsentException(formError));
        }

        public Task ShowFormAsync()
        {
            _ = _presentConsentFormCompletionSource.TrySetCanceled();
            _presentConsentFormCompletionSource = new TaskCompletionSource<bool>();
            if (Form == null)
            {
                _ = _presentConsentFormCompletionSource.TrySetException(ConsentException.UnknownError);
            }
            else
            {
                Form.Show(Platform.CurrentActivity, this);
            }
            return _presentConsentFormCompletionSource.Task;
        }

        void IConsentFormOnConsentFormDismissedListener.OnConsentFormDismissed(FormError formError)
        {
            if (formError != null)
            {
                _ = _presentConsentFormCompletionSource.TrySetException(new ConsentException(formError));
                return;
            }
            _ = _presentConsentFormCompletionSource.TrySetResult(true);
        }

        public void Reset()
        {
            _consentInformation?.Reset();
        }
    }
}
