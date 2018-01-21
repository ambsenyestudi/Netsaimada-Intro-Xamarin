using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamIntro.Services
{
    public class NavigationService
    {
        public Dictionary<string, Page> Pages { get; private set; }
        public NavigationPage MainNavigationPage { get; private set; }

        public NavigationService()
        {
            initService();
        }
        public void RegisterPage(string pageName, Type view, Type bindingContext = null)
        {
            if (!view.IsSubclassOf(typeof(Page)))
            {
                throw new InvalidCastException("Registered view must be a type of page");
            }
            Page registeringPage = (Page)Activator.CreateInstance(view);
            if (bindingContext != null)
            {
                registeringPage.BindingContext = (BindableObject)Activator.CreateInstance(bindingContext);
            }
            Pages.Add(pageName, registeringPage);
        }
        public void NavigateTo(string pageName)
        {
            MainNavigationPage.Navigation.PushAsync(Pages[pageName]);

        }
        private void initService()
        {
            Pages = new Dictionary<string, Page>();
            MainNavigationPage = new NavigationPage();
            Application.Current.MainPage = MainNavigationPage;
        }
    }
}
