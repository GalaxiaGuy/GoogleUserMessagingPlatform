using System.Threading.Tasks;

namespace Plugin.GoogleUserMessagingPlatform
{
    public interface IUserMessagingPlatform
    {
        bool IsSupported { get; }

        Task<ConsentInformation> GetConsentInformationAsync(RequestParameters parameters);
        Task LoadConsentFormAsync();
        void Reset();
        Task ShowFormAsync();
    }
}