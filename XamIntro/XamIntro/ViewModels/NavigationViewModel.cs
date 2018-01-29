using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamIntro.Services;

namespace XamIntro.ViewModels
{
    public class NavigationViewModel:BindableObject
    {
        private NavigationService _navigationService;
        protected NavigationService NavigationService
        {
            get
            {
                if (_navigationService == null)
                {
                    _navigationService = App.Current.Resources["NavigationService"] as NavigationService;
                }
                return _navigationService;
            }
        }
    }
}
