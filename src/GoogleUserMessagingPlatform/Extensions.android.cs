using Xamarin.Google.UserMesssagingPlatform;

namespace Plugin.GoogleUserMessagingPlatform
{
    public static class Extensions
    {
        public static ConsentStatus ToConsentStatus(this int status)
        {
            return status switch
            {
                ConsentInformationConsentStatus.Unknown => ConsentStatus.Unknown,
                ConsentInformationConsentStatus.Required => ConsentStatus.Required,
                ConsentInformationConsentStatus.NotRequired => ConsentStatus.NotRequired,
                ConsentInformationConsentStatus.Obtained => ConsentStatus.Obtained,
                _ => ConsentStatus.Unknown,
            };
        }

        public static ConsentType ToConsentType(this int type)
        {
            return type switch
            {
                ConsentInformationConsentType.Unknown => ConsentType.Unknown,
                ConsentInformationConsentType.Personalized => ConsentType.Unknown,
                ConsentInformationConsentType.NonPersonalized => ConsentType.Unknown,
                _ => ConsentType.Unknown,
            };
        }

        public static DebugGeography ToDebugGeography(this int geography)
        {
            return (DebugGeography)geography;
        }

        public static int ToPlatform(this DebugGeography geography)
        {
            return geography switch
            {
                DebugGeography.Disabled => Xamarin.Google.UserMesssagingPlatform.ConsentDebugSettings.DebugGeography.DebugGeographyDisabled,
                DebugGeography.Eea => Xamarin.Google.UserMesssagingPlatform.ConsentDebugSettings.DebugGeography.DebugGeographyEea,
                DebugGeography.NotEea => Xamarin.Google.UserMesssagingPlatform.ConsentDebugSettings.DebugGeography.DebugGeographyNotEea,
                _ => Xamarin.Google.UserMesssagingPlatform.ConsentDebugSettings.DebugGeography.DebugGeographyDisabled,
            };
        }
    }
}
