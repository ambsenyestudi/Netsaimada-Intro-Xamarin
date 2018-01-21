using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamIntro.Models;

namespace XamIntro.ViewModels
{
    public class EditExpenseDetailViewModel:BindableObject
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
        public EditExpenseDetailViewModel()
        {
            Expense = new ExpenseModel
            {
                Company = "Default",
                Description = "Default",
                Amount = "Default",
                Date = DateTime.Now,
                Receipt = "Default"
            };
            UpdateCommand = new Command(() => { OnPropertyChanged("Expense"); });
        }
    }
}
