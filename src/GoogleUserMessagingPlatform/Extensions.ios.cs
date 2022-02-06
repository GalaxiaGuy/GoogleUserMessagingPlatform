namespace Plugin.GoogleUserMessagingPlatform
{
    public static class Extensions
    {
        public static ConsentStatus ToConsentStatus(this Google.MobileAds.Consent.ConsentStatus status)
        {
            return status switch
            {
                Google.MobileAds.Consent.ConsentStatus.Unknown => ConsentStatus.Unknown,
                Google.MobileAds.Consent.ConsentStatus.Required => ConsentStatus.Required,
                Google.MobileAds.Consent.ConsentStatus.NotRequired => ConsentStatus.NotRequired,
                Google.MobileAds.Consent.ConsentStatus.Obtained => ConsentStatus.Obtained,
                _ => ConsentStatus.Unknown,
            };
        }

        public static ConsentType ToConsentType(this Google.MobileAds.Consent.ConsentType type)
        {
            return type switch
            {
                Google.MobileAds.Consent.ConsentType.Unknown => ConsentType.Unknown,
                Google.MobileAds.Consent.ConsentType.Personalized => ConsentType.Unknown,
                Google.MobileAds.Consent.ConsentType.NonPersonalized => ConsentType.Unknown,
                _ => ConsentType.Unknown,
            };
        }

        public static FormStatus ToFormStatus(this Google.MobileAds.Consent.FormStatus status)
        {
            return status switch
            {
                Google.MobileAds.Consent.FormStatus.Unknown => FormStatus.Unknown,
                Google.MobileAds.Consent.FormStatus.Available => FormStatus.Available,
                Google.MobileAds.Consent.FormStatus.Unavailable => FormStatus.Unavailable,
                _ => FormStatus.Unknown,
            };
        }

        public static DebugGeography ToDebugGeography(this Google.MobileAds.Consent.DebugGeography geography)
        {
            return geography switch
            {
                Google.MobileAds.Consent.DebugGeography.Disabled => DebugGeography.Disabled,
                Google.MobileAds.Consent.DebugGeography.Eea => DebugGeography.Eea,
                Google.MobileAds.Consent.DebugGeography.NotEea => DebugGeography.NotEea,
                _ => DebugGeography.Disabled,
            };
        }

        public static Google.MobileAds.Consent.DebugGeography ToPlatform(this DebugGeography geography)
        {
            return geography switch
            {
                DebugGeography.Disabled => Google.MobileAds.Consent.DebugGeography.Disabled,
                DebugGeography.Eea => Google.MobileAds.Consent.DebugGeography.Eea,
                DebugGeography.NotEea => Google.MobileAds.Consent.DebugGeography.NotEea,
                _ => Google.MobileAds.Consent.DebugGeography.Disabled,
            };
        }
    }
}
