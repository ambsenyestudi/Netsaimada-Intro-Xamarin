using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamIntro.Models;
using XamIntro.Services.Contract;

namespace XamIntro.Services.Fakes
{
    public class FakeDataService : IDataService
    {
        bool isInitialized;
        List<ExpenseModel> expenses;

        void Initialize()
        {
            if (!isInitialized)
            {
                expenses = new List<ExpenseModel>
                {
                new ExpenseModel { Company = "Walmart", Description = "Always low prices.", Amount = "$14.99", Date = DateTime.Now },
                new ExpenseModel { Company = "Apple", Description = "New iPhone came out - irresistable.", Amount = "$999", Date = DateTime.Now.AddDays(-7) },
                new ExpenseModel { Company = "Amazon", Description = "Case to protect my new iPhone.", Amount = "$50", Date = DateTime.Now.AddDays(-2) }
                };
                isInitialized = true;
            }
        }
        public async Task AddExpenseAsync(ExpenseModel expense)
        {
            await Task.Run(() => {
                Initialize();
            });
            expenses.Add(expense);
        }
        public async Task<IEnumerable<ExpenseModel>> GetExpensesAsync()
        {
            await Task.Run(() => {
                Initialize();
            });
            return expenses;
        }
    }
}
