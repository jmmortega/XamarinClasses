using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;

namespace XamarinClasses.Mvvmcross.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        

        public FirstViewModel()
        {
            
        }


		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
    }
}
