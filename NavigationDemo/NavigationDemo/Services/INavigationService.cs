using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDemo.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync<TViewModel>();
    }
}
