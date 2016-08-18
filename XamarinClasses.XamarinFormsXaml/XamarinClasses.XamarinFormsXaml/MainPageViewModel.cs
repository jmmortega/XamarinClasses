using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamarinClasses.XamarinFormsXaml
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; RaisePropertyChanged("Text"); }
        }


        public ICommand CommandButtonClick
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Text = "Hello";
                });
            }
        }
            

    }
}
