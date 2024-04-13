using Microsoft.EntityFrameworkCore;
using MyExpenses.Data;
using MyExpenses.Domain.Models;

namespace MyExpenses.Services
{
    public class CategoryService
    {
        private ApplicationDbContext _dbContext;
        public CategoryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _dbContext.Categories.Include(cat => cat.SubCats).AsNoTracking().ToListAsync();
        }
    }


    public class SubCatService
    {
        private ApplicationDbContext _dbContext;
        public SubCatService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SubCat>> GetSubCats()
        {
            return await _dbContext.SubCats.Include(sc => sc.Category).OrderBy(sc => sc.Category.CatOrder)
                .AsNoTracking().ToListAsync();

        }
    }

}
