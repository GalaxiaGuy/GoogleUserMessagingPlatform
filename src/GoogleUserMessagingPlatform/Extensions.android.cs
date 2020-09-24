namespace Google.UserMessagingPlatform
{
    public static class Extensions
    {
        public static ConsentStatus ToConsentStatus(this int status)
        {
            return (ConsentStatus)status;
        }

        public static ConsentType ToConsentType(this int type)
        {
            return (ConsentType)type;
        }

        public static FormStatus ToFormStatus(this int status)
        {
            return (FormStatus)status;
        }

        public static DebugGeography ToDebugGeography(this int geography)
        {
            return (DebugGeography)geography;
        }
    }
}
