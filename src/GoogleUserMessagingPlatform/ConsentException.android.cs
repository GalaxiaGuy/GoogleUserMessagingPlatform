using Xamarin.Google.UserMesssagingPlatform;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class ConsentException
    {
        public FormError? Error { get; }

        public ConsentException(FormError error) : this(error.Message)
        {
            Error = error;
        }
    }
}
