using GoogleUserMessagingPlatform;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class RequestParameters
    {
        public UMPRequestParameters ToPlatform()
        {
            return new UMPRequestParameters { TagForUnderAgeOfConsent = IsTagForUnderAgeOfConsent };
        }
    }
}
