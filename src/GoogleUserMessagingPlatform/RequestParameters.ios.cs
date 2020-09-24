using GoogleUserMessagingPlatform;

namespace Google.UserMessagingPlatform
{
    public partial class RequestParameters
    {
        public bool IsTagForUnderAgeOfConsent
        {
            get;
            set;
        }

        public UMPRequestParameters ToPlatform()
        {
            return new UMPRequestParameters { TagForUnderAgeOfConsent = IsTagForUnderAgeOfConsent };
        }
    }
}
