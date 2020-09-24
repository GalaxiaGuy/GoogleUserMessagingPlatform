using System.Collections.Generic;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class ConsentDebugSettings
    {
        public DebugGeography Geography
        {
            get;
            set;
        }

        public IList<string> AndroidTestDeviceIds
        {
            get;
            set;
        } = new List<string>();

        public IList<string> iOSTestDeviceIds
        {
            get;
            set;
        } = new List<string>();
    }
}
