using Microsoft.Azure.Devices.Client;
using MvvmCross.Platform.IoC;

namespace MvvmCrossIotSdkBug.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        DeviceClient _deviceClient = DeviceClient.Create("", new DeviceAuthenticationWithRegistrySymmetricKey("", ""), TransportType.Mqtt);
        public override void Initialize()
        {
            
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<ViewModels.FirstViewModel>();
        }
    }
}
