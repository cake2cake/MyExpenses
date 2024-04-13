using Microsoft.EntityFrameworkCore;
using MyExpenses.Data;
using MyExpenses.Domain.Models;

namespace MyExpenses.Services
{
    public class ExpenseService
    {
        private ApplicationDbContext _dbContext;
        
        public ExpenseService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }

        public async Task<List<Expense>> GetAllExpensesAsync()
        {
            return await _dbContext.Expenses.Where(c => c.TDate >= DateTime.Now.AddDays(-7))
                .Include(exp => exp.SubCat).ToListAsync();
        }

        public async Task<Expense> GetExpenseByIdAsync(int expId)
        {
            return await _dbContext.Expenses.FindAsync(expId);
        }

        public async Task<List<Expense>> GetExpensesByDateAsync(DateTime targetDate)
        {
            DateTime startDate = targetDate.AddDays(-1);
            DateTime endDate = targetDate.AddDays(1);
            return await _dbContext.Expenses.Where(exp => exp.TDate >= startDate && exp.TDate <= endDate).ToListAsync();
        }

        public async Task AddExpenseAsync(Expense expEntry)
        {
            try
            {
                _dbContext.Expenses.Add(expEntry);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
