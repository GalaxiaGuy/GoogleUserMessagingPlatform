using Xamarin.Essentials;

namespace Plugin.GoogleUserMessagingPlatform
{
    public partial class ConsentDebugSettings
    {
        public Xamarin.Google.UserMesssagingPlatform.ConsentDebugSettings ToPlatform()
        {
            var builder = new Xamarin.Google.UserMesssagingPlatform.ConsentDebugSettings.Builder(Platform.CurrentActivity)
                .SetDebugGeography((int)Geography);

            foreach (var id in AndroidTestDeviceIds)
            {
                _ = builder.AddTestDeviceHashedId(id);
            }
            return builder.Build();
        }
    }
}
