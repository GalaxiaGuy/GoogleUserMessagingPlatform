using System;
using System.Threading.Tasks;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class UserMessagingPlatform
    {
        public bool IsSupported => false;

        public Task<ConsentInformation> GetConsentInformationAsync(RequestParameters parameters)
            => throw new PlatformNotSupportedException();

        public Task LoadConsentFormAsync()
            => throw new PlatformNotSupportedException();

        public Task ShowFormAsync()
            => throw new PlatformNotSupportedException();

        public void Reset()
            => throw new PlatformNotSupportedException();
    }
}
