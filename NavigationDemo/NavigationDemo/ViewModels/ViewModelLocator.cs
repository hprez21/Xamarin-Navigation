using NavigationDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;
using TinyIoC;

namespace NavigationDemo.ViewModels
{
    public static class ViewModelLocator
    {
        private static TinyIoCContainer _container;

        static ViewModelLocator()
        {
            _container = new TinyIoCContainer();
            _container.Register<Page1ViewModel>();
            _container.Register<Page2ViewModel>();

            _container.Register<INavigationService, NavigationService>();
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }
}
