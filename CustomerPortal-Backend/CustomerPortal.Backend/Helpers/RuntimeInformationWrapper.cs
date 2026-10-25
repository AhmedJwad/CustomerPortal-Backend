using System.Runtime.InteropServices;

namespace CustomerPortal.Backend.Helpers
{
    public class RuntimeInformationWrapper: IRuntimeInformationWrapper
    {
        public bool IsOSPlatform(OSPlatform osPlatform)
        => RuntimeInformation.IsOSPlatform(osPlatform);
    }
}
