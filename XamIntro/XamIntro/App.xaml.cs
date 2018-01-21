﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamIntro.Services;
using XamIntro.ViewModels;
using XamIntro.Views;

namespace XamIntro
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            initNavigationService();
        }
        private void initNavigationService()
        {
            NavigationService navigationService = new NavigationService();
            navigationService.RegisterPage("MainView", typeof(MainView), typeof(MainViewModel));
            navigationService.RegisterPage("ExpenseSummaryView", typeof(ExpenseSummaryView));
            navigationService.RegisterPage("NewExpenseView", typeof(NewExpenseView));
            navigationService.RegisterPage("ExpenseChartView", typeof(ExpenseChartView));
            navigationService.NavigateTo("MainView");
            App.Current.Resources.Add("NavigationService", navigationService);
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
