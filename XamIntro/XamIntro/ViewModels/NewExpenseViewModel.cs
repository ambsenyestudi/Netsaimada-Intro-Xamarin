using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamIntro.Models;
using XamIntro.Services.Contract;

namespace XamIntro.ViewModels
{
    public class NewExpenseViewModel:NavigationViewModel
    {
        private IDataService _dataService;
        protected IDataService dataService
        {
            get
            {
                if (_dataService == null)
                {
                    _dataService = App.Current.Resources["DataService"] as IDataService;
                }
                return _dataService;
            }
        }
        private ExpenseModel _expense;

        public ExpenseModel Expense
        {
            get { return _expense; }
            set
            {
                _expense = value;
                OnPropertyChanged("Expense");
            }
        }
        private Command _saveCommand;

        public Command SaveCommand
        {
            get { return _saveCommand; }
            set
            {
                _saveCommand = value;
                OnPropertyChanged("SaveCommand");
            }
        }
        private Command _resetCommand;

        public Command ResetCommand
        {
            get { return _resetCommand; }
            set
            {
                _resetCommand = value;
                OnPropertyChanged("ResetCommand");
            }
        }
        public NewExpenseViewModel()
        {
            initCommands();
            ResetCommand.Execute(null);
        }

        private void initCommands()
        {
            ResetCommand = new Command(() => { Expense = new ExpenseModel() {Date = DateTime.Now}; });
            SaveCommand = new Command(saveExpenseAndGoBack);
        }

        private void saveExpenseAndGoBack()
        {
            dataService.AddExpenseAsync(Expense);
            NavigationService.NavigateBack();
        }
    }
}
