using Android.Content;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Droid;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;

namespace XamarinClasses.Mvvmcross.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
            
        }

        protected override IMvxApplication CreateApp()
        {
            return new XamarinClasses.Mvvmcross.Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}