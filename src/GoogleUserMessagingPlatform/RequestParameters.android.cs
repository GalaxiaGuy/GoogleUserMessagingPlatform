using Xamarin.Google.UserMesssagingPlatform;

namespace Google.UserMessagingPlatform
{
    public partial class RequestParameters
    {
        public bool IsTagForUnderAgeOfConsent
        {
            get;
            set;
        }

        public ConsentRequestParameters ToPlatform()
        {
            return new ConsentRequestParameters.Builder().SetTagForUnderAgeOfConsent(IsTagForUnderAgeOfConsent).Build();
        }
    }
}
