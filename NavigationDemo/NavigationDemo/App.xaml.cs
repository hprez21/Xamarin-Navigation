using NavigationDemo.Services;
using NavigationDemo.ViewModels;
using NavigationDemo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();            
            MainPage = new NavigationPage(new Page1View());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
