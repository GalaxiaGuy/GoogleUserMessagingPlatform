namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class RequestParameters
    {
        public bool IsTagForUnderAgeOfConsent
        {
            get;
            set;
        }

        public ConsentDebugSettings DebugSettings
        {
            get;
            set;
        } = new ConsentDebugSettings();
    }
}
