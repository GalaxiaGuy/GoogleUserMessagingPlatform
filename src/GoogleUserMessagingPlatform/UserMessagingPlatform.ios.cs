﻿using System.Threading.Tasks;
using Foundation;
using Google.MobileAds.Consent;
using UIKit;
using Xamarin.Essentials;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class UserMessagingPlatform
    {
        public bool IsSupported => true;

        public ConsentForm? Form { get; private set; }
        public Google.MobileAds.Consent.ConsentInformation ConsentInformationSharedInstance => Google.MobileAds.Consent.ConsentInformation.SharedInstance;

        public Task<ConsentInformation> GetConsentInformationAsync(RequestParameters parameters)
        {
            _consentInformationCompletionSource.TrySetCanceled();
            _consentInformationCompletionSource = new TaskCompletionSource<ConsentInformation>();
            ConsentInformationSharedInstance.RequestConsentInfoUpdateWithParameters(parameters.ToPlatform(), RequestConsentHandler);
            return _consentInformationCompletionSource.Task;
        }

        private void RequestConsentHandler(NSError? error)
        {
            if (error != null)
            {
                _consentInformationCompletionSource.TrySetException(new ConsentException(error));
                return;
            }
            var info = new ConsentInformation(
                ConsentInformationSharedInstance.ConsentStatus.ToConsentStatus(),
                ConsentInformationSharedInstance.ConsentType.ToConsentType(),
                ConsentInformationSharedInstance.FormStatus.ToFormStatus());
            _consentInformationCompletionSource.TrySetResult(info);
        }

        public Task LoadConsentFormAsync()
        {
            _loadConsentFormCompletionSource.TrySetCanceled();
            _loadConsentFormCompletionSource = new TaskCompletionSource<bool>();
            ConsentForm.LoadWithCompletionHandler(LoadConsentFormCompletionHandler);
            return _loadConsentFormCompletionSource.Task;
        }

        private void LoadConsentFormCompletionHandler(ConsentForm? form, NSError? error)
        {
            if (error != null)
            {
                _loadConsentFormCompletionSource.TrySetException(new ConsentException(error));
                return;
            }
            Form = form;
            _loadConsentFormCompletionSource.TrySetResult(true);
        }

        public Task ShowFormAsync()
        {
            _presentConsentFormCompletionSource.TrySetCanceled();
            _presentConsentFormCompletionSource = new TaskCompletionSource<bool>();
            if (Form == null)
            {
                _presentConsentFormCompletionSource.TrySetException(ConsentException.UnknownError);
            }
            else
            {
                Form.PresentFromViewController(Platform.GetCurrentUIViewController(), PresentConsentFormCompletionHandler);
            }
            return _presentConsentFormCompletionSource.Task;
        }

        private void PresentConsentFormCompletionHandler(NSError? error)
        {
            if (error != null)
            {
                _presentConsentFormCompletionSource.TrySetException(new ConsentException(error));
                return;
            }
            _presentConsentFormCompletionSource.TrySetResult(true);
        }

        public void Reset()
        {
            ConsentInformationSharedInstance.Reset();
        }
    }
}
