using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamIntro.Models;

namespace XamIntro.Services.Contract
{
    public interface IDataService
    {
        Task AddExpenseAsync(ExpenseModel ex);

        Task<IEnumerable<ExpenseModel>> GetExpensesAsync();
    }
}
