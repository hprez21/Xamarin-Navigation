using NavigationDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationDemo.ViewModels
{
    public class ViewModelBase
    {
        protected readonly INavigationService NavigationService;
        public ViewModelBase()
        {
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
        }
    }
}
