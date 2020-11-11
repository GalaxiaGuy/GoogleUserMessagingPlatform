namespace Plugin.GoogleUserMessagingPlatform
{
    public static class Extensions
    {
        public static ConsentStatus ToConsentStatus(this Google.MobileAds.Consent.ConsentStatus status)
        {
            return (ConsentStatus)(int)status;
        }

        public static ConsentType ToConsentType(this Google.MobileAds.Consent.ConsentType type)
        {
            return (ConsentType)(int)type;
        }

        public static FormStatus ToFormStatus(this Google.MobileAds.Consent.FormStatus status)
        {
            return (FormStatus)(int)status;
        }

        public static DebugGeography ToDebugGeography(this Google.MobileAds.Consent.DebugGeography geography)
        {
            return (DebugGeography)(int)geography;
        }

        public static Google.MobileAds.Consent.DebugGeography ToPlatform(this DebugGeography geography)
        {
            return (Google.MobileAds.Consent.DebugGeography)(int)geography;
        }
    }
}
