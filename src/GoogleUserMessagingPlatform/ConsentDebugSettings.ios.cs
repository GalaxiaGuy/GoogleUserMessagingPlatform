using GoogleUserMessagingPlatform;
using System.Linq;

namespace Google.UserMessagingPlatform
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
