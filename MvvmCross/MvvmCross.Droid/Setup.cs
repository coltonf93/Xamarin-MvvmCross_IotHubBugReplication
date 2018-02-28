using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platform.Platform;
using MvvmCrossIotSdkBug.Core;

namespace MvvmCrossIotSdkBug.Droid
{
    public class Setup : MvxAppCompatSetup
    {
        public Setup(Context applicationContext) : base(applicationContext){}

        protected override IMvxApplication CreateApp() => new App();

        /*protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }*/
    }
}
