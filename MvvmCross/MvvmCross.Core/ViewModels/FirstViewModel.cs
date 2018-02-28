using Microsoft.Azure.Devices.Client;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossIotSdkBug.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public DeviceClient BuildBreakingSnipet;
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }
    }
}
