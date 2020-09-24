using GoogleUserMessagingPlatform;
using System.Linq;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class ConsentDebugSettings
    {
        public UMPDebugSettings ToPlatform()
        {
            return new UMPDebugSettings
            {
                Geography = Geography.ToUMPDebugGeography(),
                TestDeviceIdentifiers = iOSTestDeviceIds.ToArray(),
            };
        }
    }
}
