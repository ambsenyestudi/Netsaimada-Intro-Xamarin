using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamIntro.ViewModels
{
    public class MainViewModel: NavigationViewModel
    {
        public Command NewExpenseCommand { get; set; }
        public Command ExpenseSummaryCommand { get; set; }
        public Command ChartCommand { get; set; }
        public MainViewModel()
        {
            initViewModel();
        }
        public void NavigateToDetailView()
        {
            NavigationService.NavigateTo("NewExpenseView");
        }
        public void NavigateToExpenseSummayView()
        {
            NavigationService.NavigateTo("ExpenseSummaryView");
        }
        public void NavigateToChartView()
        {
            NavigationService.NavigateTo("ExpenseChartView");
        }
        private void initViewModel()
        {
            NewExpenseCommand = new Command(NavigateToDetailView);
            ExpenseSummaryCommand = new Command(NavigateToExpenseSummayView);
            ChartCommand = new Command(NavigateToChartView);
        }
    }
}
