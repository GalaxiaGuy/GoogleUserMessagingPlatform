namespace Plugin.GoogleUserMessagingPlatform
{
    public class ConsentInformation
    {
        public ConsentStatus ConsentStatus { get; }
        public ConsentType ConsentType { get; }
        public FormStatus FormStatus { get; }

        public ConsentInformation(ConsentStatus consentStatus, ConsentType consentType, FormStatus formStatus)
        {
            ConsentStatus = consentStatus;
            ConsentType = ConsentType;
            FormStatus = formStatus;
        }
    }
}
