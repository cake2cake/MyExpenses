using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyExpenses.Components.Pages;
using MyExpenses.Domain.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System;

namespace MyExpenses.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCat> SubCats { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { CatId = 10, CatName = "Food", CatOrder = 1000 },
                new Category { CatId = 20, CatName = "Transport", CatOrder = 2000 },
                new Category { CatId = 30, CatName = "Home", CatOrder = 3000 },
                new Category { CatId = 40, CatName = "Utilities", CatOrder = 4000 },
                new Category { CatId = 50, CatName = "Clothing", CatOrder = 5000 },
                new Category { CatId = 60, CatName = "Leisure", CatOrder = 6000 },
                new Category { CatId = 70, CatName = "Studies", CatOrder = 7000 },
                new Category { CatId = 80, CatName = "Vacation", CatOrder = 8000 },
                new Category { CatId = 90, CatName = "Medical", CatOrder = 9000 },
                new Category { CatId = 100, CatName = "Occasions", CatOrder = 10000 },
                new Category { CatId = 110, CatName = "Loan", CatOrder = 11000 },
                new Category { CatId = 120, CatName = "Parents", CatOrder = 12000 },
                new Category { CatId = 130, CatName = "Pet", CatOrder = 13000 },
                new Category { CatId = 140, CatName = "Wife", CatOrder = 14000 },
                new Category { CatId = 150, CatName = "Work", CatOrder = 15000 },
                new Category { CatId = 160, CatName = "Social", CatOrder = 16000 }
            );

            //builder.Entity<SubCat>().HasData(
            //    new SubCat { SubCatId = 1, SubCatName = "Breakfast", CatId = 10, SubCatOrder = 100, Category = { CatId = 10 } },
            //    new SubCat { SubCatId = 2, SubCatName = "Lunch", CatId = 10, SubCatOrder = 200, Category = { CatId = 10 } },
            //    new SubCat { SubCatId = 3, SubCatName = "Dinner", CatId = 10, SubCatOrder = 300, Category = { CatId = 10 } },
            //    new SubCat { SubCatId = 4, SubCatName = "Snack", CatId = 10, SubCatOrder = 400, Category = { CatId = 10 } },
            //    new SubCat { SubCatId = 5, SubCatName = "Cook", CatId = 10, SubCatOrder = 500, Category = { CatId = 10 } },
            //    new SubCat { SubCatId = 6, SubCatName = "Car Park", CatId = 20, SubCatOrder = 600, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 7, SubCatName = "Car Gas", CatId = 20, SubCatOrder = 700, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 8, SubCatName = "Car Fines", CatId = 20, SubCatOrder = 800, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 9, SubCatName = "Car Tax", CatId = 20, SubCatOrder = 900, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 10, SubCatName = "Car Maintenance", CatId = 20, SubCatOrder = 1000, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 11, SubCatName = "Car Insurance", CatId = 20, SubCatOrder = 1100, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 12, SubCatName = "Car Wash", CatId = 20, SubCatOrder = 1200, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 13, SubCatName = "Bus", CatId = 20, SubCatOrder = 1300, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 14, SubCatName = "Taxi", CatId = 20, SubCatOrder = 1400, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 15, SubCatName = "Monthly", CatId = 120, SubCatOrder = 1500, Category = { CatId = 120 } },
            //    new SubCat { SubCatId = 16, SubCatName = "Travel", CatId = 120, SubCatOrder = 1600, Category = { CatId = 120 } },
            //    new SubCat { SubCatId = 17, SubCatName = "House maintenance", CatId = 120, SubCatOrder = 1700, Category = { CatId = 120 } },
            //    new SubCat { SubCatId = 18, SubCatName = "Others", CatId = 120, SubCatOrder = 1800, Category = { CatId = 120 } },
            //    new SubCat { SubCatId = 19, SubCatName = "Food", CatId = 130, SubCatOrder = 1900, Category = { CatId = 130 } },
            //    new SubCat { SubCatId = 20, SubCatName = "Pet care", CatId = 130, SubCatOrder = 2000, Category = { CatId = 130 } },
            //    new SubCat { SubCatId = 21, SubCatName = "Vet", CatId = 130, SubCatOrder = 2100, Category = { CatId = 130 } },
            //    new SubCat { SubCatId = 22, SubCatName = "Accessories", CatId = 130, SubCatOrder = 2200, Category = { CatId = 130 } },
            //    new SubCat { SubCatId = 23, SubCatName = "Pet Toilet", CatId = 130, SubCatOrder = 2300, Category = { CatId = 130 } },
            //    new SubCat { SubCatId = 24, SubCatName = "Groceries", CatId = 30, SubCatOrder = 2400, Category = { CatId = 30 } },
            //    new SubCat { SubCatId = 25, SubCatName = "Home Maintenance", CatId = 30, SubCatOrder = 2700, Category = { CatId = 30 } },
            //    new SubCat { SubCatId = 26, SubCatName = "Management Fee", CatId = 30, SubCatOrder = 2600, Category = { CatId = 30 } },
            //    new SubCat { SubCatId = 27, SubCatName = "Maid", CatId = 30, SubCatOrder = 2500, Category = { CatId = 30 } },
            //    new SubCat { SubCatId = 28, SubCatName = "Car Loan", CatId = 110, SubCatOrder = 2800, Category = { CatId = 110 } },
            //    new SubCat { SubCatId = 29, SubCatName = "House Loan", CatId = 110, SubCatOrder = 2900, Category = { CatId = 110 } },
            //    new SubCat { SubCatId = 30, SubCatName = "Loan charges", CatId = 110, SubCatOrder = 3000, Category = { CatId = 110 } },
            //    new SubCat { SubCatId = 31, SubCatName = "House Tax", CatId = 30, SubCatOrder = 3100, Category = { CatId = 30 } },
            //    new SubCat { SubCatId = 33, SubCatName = "CEM", CatId = 40, SubCatOrder = 3300, Category = { CatId = 40 } },
            //    new SubCat { SubCatId = 34, SubCatName = "SAAM", CatId = 40, SubCatOrder = 3400, Category = { CatId = 40 } },
            //    new SubCat { SubCatId = 35, SubCatName = "Gas", CatId = 40, SubCatOrder = 3500, Category = { CatId = 40 } },
            //    new SubCat { SubCatId = 36, SubCatName = "Fixed line", CatId = 40, SubCatOrder = 3600, Category = { CatId = 40 } },
            //    new SubCat { SubCatId = 37, SubCatName = "Mobile(CTM)", CatId = 40, SubCatOrder = 3700, Category = { CatId = 40 } },
            //    new SubCat { SubCatId = 38, SubCatName = "Internet", CatId = 40, SubCatOrder = 3800, Category = { CatId = 40 } },
            //    new SubCat { SubCatId = 39, SubCatName = "Internet(Mom)", CatId = 40, SubCatOrder = 3900, Category = { CatId = 40 } },
            //    new SubCat { SubCatId = 40, SubCatName = "Mobile(China Telecom)", CatId = 40, SubCatOrder = 4000, Category = { CatId = 40 } },
            //    new SubCat { SubCatId = 41, SubCatName = "Magazines", CatId = 60, SubCatOrder = 4100, Category = { CatId = 60 } },
            //    new SubCat { SubCatId = 42, SubCatName = "Toys", CatId = 60, SubCatOrder = 4200, Category = { CatId = 60 } },
            //    new SubCat { SubCatId = 43, SubCatName = "Sports", CatId = 60, SubCatOrder = 4300, Category = { CatId = 60 } },
            //    new SubCat { SubCatId = 45, SubCatName = "Parking Rent", CatId = 140, SubCatOrder = 4500, Category = { CatId = 140 } },
            //    new SubCat { SubCatId = 46, SubCatName = "Insurance", CatId = 140, SubCatOrder = 4600, Category = { CatId = 140 } },
            //    new SubCat { SubCatId = 47, SubCatName = "Others", CatId = 140, SubCatOrder = 4700, Category = { CatId = 140 } },
            //    new SubCat { SubCatId = 48, SubCatName = "Personal - Clothing", CatId = 50, SubCatOrder = 4800, Category = { CatId = 50 } },
            //    new SubCat { SubCatId = 49, SubCatName = "Medicine", CatId = 90, SubCatOrder = 4900, Category = { CatId = 90 } },
            //    new SubCat { SubCatId = 50, SubCatName = "Insurance", CatId = 90, SubCatOrder = 5000, Category = { CatId = 90 } },
            //    new SubCat { SubCatId = 51, SubCatName = "Irene - Shop Expenses", CatId = 140, SubCatOrder = 5100, Category = { CatId = 140 } },
            //    new SubCat { SubCatId = 52, SubCatName = "Personal - Occasions", CatId = 100, SubCatOrder = 5200, Category = { CatId = 100 } },
            //    new SubCat { SubCatId = 53, SubCatName = "Hair cut", CatId = 50, SubCatOrder = 5300, Category = { CatId = 50 } },
            //    new SubCat { SubCatId = 54, SubCatName = "Audio Visual", CatId = 60, SubCatOrder = 5400, Category = { CatId = 60 } },
            //    new SubCat { SubCatId = 55, SubCatName = "Personal - CNY", CatId = 100, SubCatOrder = 5500, Category = { CatId = 100 } },
            //    new SubCat { SubCatId = 56, SubCatName = "Fruit", CatId = 10, SubCatOrder = 550, Category = { CatId = 10 } },
            //    new SubCat { SubCatId = 60, SubCatName = "Games", CatId = 60, SubCatOrder = 6000, Category = { CatId = 60 } },
            //    new SubCat { SubCatId = 61, SubCatName = "Expenses", CatId = 80, SubCatOrder = 6100, Category = { CatId = 80 } },
            //    new SubCat { SubCatId = 62, SubCatName = "Transportation", CatId = 80, SubCatOrder = 6200, Category = { CatId = 80 } },
            //    new SubCat { SubCatId = 70, SubCatName = "Irene dad China Mobile(since Jun / 18)", CatId = 40, SubCatOrder = 4050, Category = { CatId = 40 } },
            //    new SubCat { SubCatId = 80, SubCatName = "Online course", CatId = 70, SubCatOrder = 8000, Category = { CatId = 70 } },
            //    new SubCat { SubCatId = 81, SubCatName = "Classroom course", CatId = 70, SubCatOrder = 8100, Category = { CatId = 70 } },
            //    new SubCat { SubCatId = 103, SubCatName = "Car Purchase", CatId = 20, SubCatOrder = 1250, Category = { CatId = 20 } },
            //    new SubCat { SubCatId = 110, SubCatName = "Furniture", CatId = 30, SubCatOrder = 2710, Category = { CatId = 30 } },
            //    new SubCat { SubCatId = 120, SubCatName = "Shoes", CatId = 50, SubCatOrder = 4850, Category = { CatId = 50 } },
            //    new SubCat { SubCatId = 130, SubCatName = "Hotels", CatId = 80, SubCatOrder = 6250, Category = { CatId = 80 } },
            //    new SubCat { SubCatId = 135, SubCatName = "Misc", CatId = 80, SubCatOrder = 6260, Category = { CatId = 80 } },
            //    new SubCat { SubCatId = 140, SubCatName = "Social expenses", CatId = 150, SubCatOrder = 14000, Category = { CatId = 150 } },
            //    new SubCat { SubCatId = 144, SubCatName = "Computers", CatId = 150, SubCatOrder = 14400, Category = { CatId = 150 } }
            //    );
        }
    }


}
