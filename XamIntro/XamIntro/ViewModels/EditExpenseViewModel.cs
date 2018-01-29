using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamIntro.Models;
using XamIntro.Services;

namespace XamIntro.ViewModels
{
    public class EditExpenseViewModel:BindableObject
    {
        private ExpenseModel _expense;
        public ExpenseModel Expense
        {
            get {return _expense; }
            set
            {
                _expense = value;
                OnPropertyChanged("Expense");
            }
        }
        public Command UpdateCommand { get; set; }
        public EditExpenseViewModel()
        {
            Expense = new ExpenseModel
            {
                Company = "Default",
                Description = "Default",
                Amount = "Default",
                Date = DateTime.Now,
                Receipt = "Default"
            };
            MessagingCenter.Subscribe<NavigationService, object>(this, "ExpenseModel", (sender, param) => updateExpense(param));
            UpdateCommand = new Command(() => { OnPropertyChanged("Expense"); });
        }

        private void updateExpense(object obj)
        {
            ExpenseModel newModel = obj as ExpenseModel;
            if(newModel!=null)
            {
                Expense = newModel;
            }
        }
    }
}
