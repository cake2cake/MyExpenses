using Microsoft.EntityFrameworkCore;
using MyExpenses.Domain.Models;

namespace MyExpenses.Api.Data
{
    public class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<SubCat>? SubCats { get; set; }
        

    }
        
    
}
