using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NavigationDemo.ViewModels
{
    public class Page1ViewModel : ViewModelBase
    {
        public ICommand ButtonCommand { get; set; }

        public Page1ViewModel()
        {
            ButtonCommand = new Command(async () =>
            {
                //????                
            });
        }
    }
}
