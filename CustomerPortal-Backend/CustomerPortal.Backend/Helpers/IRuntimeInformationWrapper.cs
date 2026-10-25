using System.Runtime.InteropServices;

namespace CustomerPortal.Backend.Helpers
{
    public interface IRuntimeInformationWrapper
    {
        bool IsOSPlatform(OSPlatform osPlatform);
    }
}
