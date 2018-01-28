using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamIntro.Models;
using XamIntro.Services;
using XamIntro.Services.Contract;

namespace XamIntro.ViewModels
{
    public class ExpenseSummaryViewModel:NavigationViewModel
    {
        private IDataService _dataService;
        protected IDataService dataService {
            get
            {
                if (_dataService == null)
                {
                    _dataService = App.Current.Resources["DataService"] as IDataService;
                }
                return _dataService;
            }
        }
        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public ObservableCollection<ExpenseModel> Expenses { get; set; }
        public Command GetExpensesCommand { get; set; }

        private ExpenseModel _selectedExpense;

        public ExpenseModel SelectedExpense
        {
            get { return _selectedExpense; }
            set
            {
                _selectedExpense = value;
                OnPropertyChanged("SelectedExpense");
                NavigationService.NavigateTo("EditExpenseView");
            }
        }


        public ExpenseSummaryViewModel()
        {
            initializeViewModel();
            //On Show workarround
            MessagingCenter.Subscribe<NavigationService>(this, "Page pushed",(obj)=> GetExpensesCommand.Execute(null));
        }

        private async Task GetExpensesAync()
        {
            if(!IsBusy)
            {
                IsBusy = true;
                try
                {
                    Expenses.Clear();
                    var expenses = await dataService.GetExpensesAsync();
                    foreach(var expense in expenses)
                    {
                        Expenses.Add(expense);
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }
        private void initializeViewModel()
        {
            Expenses = new ObservableCollection<ExpenseModel>();
            GetExpensesCommand = new Command(async () => await GetExpensesAync());
            //AddExpenseCommand = new Command(async () => await GetAddExpense());
        }
    }
}
