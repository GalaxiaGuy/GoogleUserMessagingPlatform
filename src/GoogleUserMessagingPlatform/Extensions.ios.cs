using GoogleUserMessagingPlatform;

namespace Google.UserMessagingPlatform
{
    public static class Extensions
    {
        public static ConsentStatus ToConsentStatus(this UMPConsentStatus status)
        {
            return (ConsentStatus)(int)status;
        }

        public static ConsentType ToConsentType(this UMPConsentType type)
        {
            return (ConsentType)(int)type;
        }

        public static FormStatus ToFormStatus(this UMPFormStatus status)
        {
            return (FormStatus)(int)status;
        }

        public static DebugGeography ToDebugGeography(this UMPDebugGeography geography)
        {
            return (DebugGeography)(int)geography;
        }

        public static UMPDebugGeography ToUMPDebugGeography(this DebugGeography geography)
        {
            return (UMPDebugGeography)(int)geography;
        }
    }
}
