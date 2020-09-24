using System;
using System.Threading.Tasks;

namespace Google.UserMessagingPlatform
{
    public partial class UserMessagingPlatform
    {
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
