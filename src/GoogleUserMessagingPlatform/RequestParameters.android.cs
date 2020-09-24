using Xamarin.Google.UserMesssagingPlatform;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class RequestParameters
    {
        public ConsentRequestParameters ToPlatform()
        {
            return new ConsentRequestParameters.Builder().SetTagForUnderAgeOfConsent(IsTagForUnderAgeOfConsent).Build();
        }
    }
}
