using System.Threading.Tasks;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class UserMessagingPlatform
    {
        private TaskCompletionSource<ConsentInformation> _consentInformationCompletionSource = new TaskCompletionSource<ConsentInformation>();
        private TaskCompletionSource<bool> _loadConsentFormCompletionSource = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> _presentConsentFormCompletionSource = new TaskCompletionSource<bool>();
    }
}
