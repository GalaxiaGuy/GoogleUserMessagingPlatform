using System.Threading.Tasks;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class UserMessagingPlatform : IUserMessagingPlatform
    {
        public static UserMessagingPlatform Instance { get; } = new UserMessagingPlatform();

        private UserMessagingPlatform()
        {

        }

        private TaskCompletionSource<ConsentInformation> _consentInformationCompletionSource = new TaskCompletionSource<ConsentInformation>();
        private TaskCompletionSource<bool> _loadConsentFormCompletionSource = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> _presentConsentFormCompletionSource = new TaskCompletionSource<bool>();
    }
}
