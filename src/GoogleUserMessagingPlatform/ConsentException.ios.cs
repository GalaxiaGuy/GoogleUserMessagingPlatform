using Foundation;

namespace Google.UserMessagingPlatform
{
    public partial class ConsentException
    {
        public NSError? Error { get; }

        public ConsentException(NSError error) : this(error.LocalizedDescription)
        {
            Error = error;
        }
    }
}
