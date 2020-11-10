using System.Linq;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class ConsentDebugSettings
    {
        public Google.MobileAds.Consent.DebugSettings ToPlatform()
        {
            return new Google.MobileAds.Consent.DebugSettings
            {
                Geography = Geography.ToUMPDebugGeography(),
                TestDeviceIdentifiers = iOSTestDeviceIds.ToArray(),
            };
        }
    }
}
