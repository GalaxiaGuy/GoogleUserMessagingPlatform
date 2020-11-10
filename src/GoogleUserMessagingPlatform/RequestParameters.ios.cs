namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class RequestParameters
    {
        public Google.MobileAds.Consent.RequestParameters ToPlatform()
        {
            return new Google.MobileAds.Consent.RequestParameters
            {
                TagForUnderAgeOfConsent = IsTagForUnderAgeOfConsent,
                DebugSettings = DebugSettings.ToPlatform()
            };
        }
    }
}
