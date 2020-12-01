using NavigationDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1View : ContentPage
    {
        public Page1View()
        {
            InitializeComponent();
            BindingContext = new Page1ViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2View());
        }
    }
}