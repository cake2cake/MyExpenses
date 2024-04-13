﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyExpenses.Data;

#nullable disable

namespace MyExpenses.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240323085554_seed-subcat-data")]
    partial class seedsubcatdata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyExpenses.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MyExpenses.Domain.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatId"));

                    b.Property<string>("CatName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatOrder")
                        .HasColumnType("int");

                    b.HasKey("CatId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CatId = 10,
                            CatName = "Food",
                            CatOrder = 1000
                        },
                        new
                        {
                            CatId = 20,
                            CatName = "Transport",
                            CatOrder = 2000
                        },
                        new
                        {
                            CatId = 30,
                            CatName = "Home",
                            CatOrder = 3000
                        },
                        new
                        {
                            CatId = 40,
                            CatName = "Utilities",
                            CatOrder = 4000
                        },
                        new
                        {
                            CatId = 50,
                            CatName = "Clothing",
                            CatOrder = 5000
                        },
                        new
                        {
                            CatId = 60,
                            CatName = "Leisure",
                            CatOrder = 6000
                        },
                        new
                        {
                            CatId = 70,
                            CatName = "Studies",
                            CatOrder = 7000
                        },
                        new
                        {
                            CatId = 80,
                            CatName = "Vacation",
                            CatOrder = 8000
                        },
                        new
                        {
                            CatId = 90,
                            CatName = "Medical",
                            CatOrder = 9000
                        },
                        new
                        {
                            CatId = 100,
                            CatName = "Occasions",
                            CatOrder = 10000
                        },
                        new
                        {
                            CatId = 110,
                            CatName = "Loan",
                            CatOrder = 11000
                        },
                        new
                        {
                            CatId = 120,
                            CatName = "Parents",
                            CatOrder = 12000
                        },
                        new
                        {
                            CatId = 130,
                            CatName = "Pet",
                            CatOrder = 13000
                        },
                        new
                        {
                            CatId = 140,
                            CatName = "Wife",
                            CatOrder = 14000
                        },
                        new
                        {
                            CatId = 150,
                            CatName = "Work",
                            CatOrder = 15000
                        },
                        new
                        {
                            CatId = 160,
                            CatName = "Social",
                            CatOrder = 16000
                        });
                });

            modelBuilder.Entity("MyExpenses.Domain.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Currency")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<decimal>("ForeignAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Item")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ItemDetails")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("SubCatId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("MyExpenses.Domain.SubCat", b =>
                {
                    b.Property<int>("SubCatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCatId"));

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("SubCatName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SubCatOrder")
                        .HasColumnType("int");

                    b.HasKey("SubCatId");

                    b.ToTable("SubCats");

                    b.HasData(
                        new
                        {
                            SubCatId = 1,
                            CatId = 10,
                            SubCatName = "Breakfast",
                            SubCatOrder = 100
                        },
                        new
                        {
                            SubCatId = 2,
                            CatId = 10,
                            SubCatName = "Lunch",
                            SubCatOrder = 200
                        },
                        new
                        {
                            SubCatId = 3,
                            CatId = 10,
                            SubCatName = "Dinner",
                            SubCatOrder = 300
                        },
                        new
                        {
                            SubCatId = 4,
                            CatId = 10,
                            SubCatName = "Snack",
                            SubCatOrder = 400
                        },
                        new
                        {
                            SubCatId = 5,
                            CatId = 10,
                            SubCatName = "Cook",
                            SubCatOrder = 500
                        },
                        new
                        {
                            SubCatId = 6,
                            CatId = 20,
                            SubCatName = "Car Park",
                            SubCatOrder = 600
                        },
                        new
                        {
                            SubCatId = 7,
                            CatId = 20,
                            SubCatName = "Car Gas",
                            SubCatOrder = 700
                        },
                        new
                        {
                            SubCatId = 8,
                            CatId = 20,
                            SubCatName = "Car Fines",
                            SubCatOrder = 800
                        },
                        new
                        {
                            SubCatId = 9,
                            CatId = 20,
                            SubCatName = "Car Tax",
                            SubCatOrder = 900
                        },
                        new
                        {
                            SubCatId = 10,
                            CatId = 20,
                            SubCatName = "Car Maintenance",
                            SubCatOrder = 1000
                        },
                        new
                        {
                            SubCatId = 11,
                            CatId = 20,
                            SubCatName = "Car Insurance",
                            SubCatOrder = 1100
                        },
                        new
                        {
                            SubCatId = 12,
                            CatId = 20,
                            SubCatName = "Car Wash",
                            SubCatOrder = 1200
                        },
                        new
                        {
                            SubCatId = 13,
                            CatId = 20,
                            SubCatName = "Bus",
                            SubCatOrder = 1300
                        },
                        new
                        {
                            SubCatId = 14,
                            CatId = 20,
                            SubCatName = "Taxi",
                            SubCatOrder = 1400
                        },
                        new
                        {
                            SubCatId = 15,
                            CatId = 120,
                            SubCatName = "Monthly",
                            SubCatOrder = 1500
                        },
                        new
                        {
                            SubCatId = 16,
                            CatId = 120,
                            SubCatName = "Travel",
                            SubCatOrder = 1600
                        },
                        new
                        {
                            SubCatId = 17,
                            CatId = 120,
                            SubCatName = "House maintenance",
                            SubCatOrder = 1700
                        },
                        new
                        {
                            SubCatId = 18,
                            CatId = 120,
                            SubCatName = "Others",
                            SubCatOrder = 1800
                        },
                        new
                        {
                            SubCatId = 19,
                            CatId = 130,
                            SubCatName = "Food",
                            SubCatOrder = 1900
                        },
                        new
                        {
                            SubCatId = 20,
                            CatId = 130,
                            SubCatName = "Pet care",
                            SubCatOrder = 2000
                        },
                        new
                        {
                            SubCatId = 21,
                            CatId = 130,
                            SubCatName = "Vet",
                            SubCatOrder = 2100
                        },
                        new
                        {
                            SubCatId = 22,
                            CatId = 130,
                            SubCatName = "Accessories",
                            SubCatOrder = 2200
                        },
                        new
                        {
                            SubCatId = 23,
                            CatId = 130,
                            SubCatName = "Pet Toilet",
                            SubCatOrder = 2300
                        },
                        new
                        {
                            SubCatId = 24,
                            CatId = 30,
                            SubCatName = "Groceries",
                            SubCatOrder = 2400
                        },
                        new
                        {
                            SubCatId = 25,
                            CatId = 30,
                            SubCatName = "Home Maintenance",
                            SubCatOrder = 2700
                        },
                        new
                        {
                            SubCatId = 26,
                            CatId = 30,
                            SubCatName = "Management Fee",
                            SubCatOrder = 2600
                        },
                        new
                        {
                            SubCatId = 27,
                            CatId = 30,
                            SubCatName = "Maid",
                            SubCatOrder = 2500
                        },
                        new
                        {
                            SubCatId = 28,
                            CatId = 110,
                            SubCatName = "Car Loan",
                            SubCatOrder = 2800
                        },
                        new
                        {
                            SubCatId = 29,
                            CatId = 110,
                            SubCatName = "House Loan",
                            SubCatOrder = 2900
                        },
                        new
                        {
                            SubCatId = 30,
                            CatId = 110,
                            SubCatName = "Loan charges",
                            SubCatOrder = 3000
                        },
                        new
                        {
                            SubCatId = 31,
                            CatId = 30,
                            SubCatName = "House Tax",
                            SubCatOrder = 3100
                        },
                        new
                        {
                            SubCatId = 33,
                            CatId = 40,
                            SubCatName = "CEM",
                            SubCatOrder = 3300
                        },
                        new
                        {
                            SubCatId = 34,
                            CatId = 40,
                            SubCatName = "SAAM",
                            SubCatOrder = 3400
                        },
                        new
                        {
                            SubCatId = 35,
                            CatId = 40,
                            SubCatName = "Gas",
                            SubCatOrder = 3500
                        },
                        new
                        {
                            SubCatId = 36,
                            CatId = 40,
                            SubCatName = "Fixed line",
                            SubCatOrder = 3600
                        },
                        new
                        {
                            SubCatId = 37,
                            CatId = 40,
                            SubCatName = "Mobile(CTM)",
                            SubCatOrder = 3700
                        },
                        new
                        {
                            SubCatId = 38,
                            CatId = 40,
                            SubCatName = "Internet",
                            SubCatOrder = 3800
                        },
                        new
                        {
                            SubCatId = 39,
                            CatId = 40,
                            SubCatName = "Internet(Mom)",
                            SubCatOrder = 3900
                        },
                        new
                        {
                            SubCatId = 40,
                            CatId = 40,
                            SubCatName = "Mobile(China Telecom)",
                            SubCatOrder = 4000
                        },
                        new
                        {
                            SubCatId = 41,
                            CatId = 60,
                            SubCatName = "Magazines",
                            SubCatOrder = 4100
                        },
                        new
                        {
                            SubCatId = 42,
                            CatId = 60,
                            SubCatName = "Toys",
                            SubCatOrder = 4200
                        },
                        new
                        {
                            SubCatId = 43,
                            CatId = 60,
                            SubCatName = "Sports",
                            SubCatOrder = 4300
                        },
                        new
                        {
                            SubCatId = 45,
                            CatId = 140,
                            SubCatName = "Parking Rent",
                            SubCatOrder = 4500
                        },
                        new
                        {
                            SubCatId = 46,
                            CatId = 140,
                            SubCatName = "Insurance",
                            SubCatOrder = 4600
                        },
                        new
                        {
                            SubCatId = 47,
                            CatId = 140,
                            SubCatName = "Others",
                            SubCatOrder = 4700
                        },
                        new
                        {
                            SubCatId = 48,
                            CatId = 50,
                            SubCatName = "Personal - Clothing",
                            SubCatOrder = 4800
                        },
                        new
                        {
                            SubCatId = 49,
                            CatId = 90,
                            SubCatName = "Medicine",
                            SubCatOrder = 4900
                        },
                        new
                        {
                            SubCatId = 50,
                            CatId = 90,
                            SubCatName = "Insurance",
                            SubCatOrder = 5000
                        },
                        new
                        {
                            SubCatId = 51,
                            CatId = 140,
                            SubCatName = "Irene - Shop Expenses",
                            SubCatOrder = 5100
                        },
                        new
                        {
                            SubCatId = 52,
                            CatId = 100,
                            SubCatName = "Personal - Occasions",
                            SubCatOrder = 5200
                        },
                        new
                        {
                            SubCatId = 53,
                            CatId = 50,
                            SubCatName = "Hair cut",
                            SubCatOrder = 5300
                        },
                        new
                        {
                            SubCatId = 54,
                            CatId = 60,
                            SubCatName = "Audio Visual",
                            SubCatOrder = 5400
                        },
                        new
                        {
                            SubCatId = 55,
                            CatId = 100,
                            SubCatName = "Personal - CNY",
                            SubCatOrder = 5500
                        },
                        new
                        {
                            SubCatId = 56,
                            CatId = 10,
                            SubCatName = "Fruit",
                            SubCatOrder = 550
                        },
                        new
                        {
                            SubCatId = 60,
                            CatId = 60,
                            SubCatName = "Games",
                            SubCatOrder = 6000
                        },
                        new
                        {
                            SubCatId = 61,
                            CatId = 80,
                            SubCatName = "Expenses",
                            SubCatOrder = 6100
                        },
                        new
                        {
                            SubCatId = 62,
                            CatId = 80,
                            SubCatName = "Transportation",
                            SubCatOrder = 6200
                        },
                        new
                        {
                            SubCatId = 70,
                            CatId = 40,
                            SubCatName = "Irene dad China Mobile(since Jun / 18)",
                            SubCatOrder = 4050
                        },
                        new
                        {
                            SubCatId = 80,
                            CatId = 70,
                            SubCatName = "Online course",
                            SubCatOrder = 8000
                        },
                        new
                        {
                            SubCatId = 81,
                            CatId = 70,
                            SubCatName = "Classroom course",
                            SubCatOrder = 8100
                        },
                        new
                        {
                            SubCatId = 103,
                            CatId = 20,
                            SubCatName = "Car Purchase",
                            SubCatOrder = 1250
                        },
                        new
                        {
                            SubCatId = 110,
                            CatId = 30,
                            SubCatName = "Furniture",
                            SubCatOrder = 2710
                        },
                        new
                        {
                            SubCatId = 120,
                            CatId = 50,
                            SubCatName = "Shoes",
                            SubCatOrder = 4850
                        },
                        new
                        {
                            SubCatId = 130,
                            CatId = 80,
                            SubCatName = "Hotels",
                            SubCatOrder = 6250
                        },
                        new
                        {
                            SubCatId = 135,
                            CatId = 80,
                            SubCatName = "Misc",
                            SubCatOrder = 6260
                        },
                        new
                        {
                            SubCatId = 140,
                            CatId = 150,
                            SubCatName = "Social expenses",
                            SubCatOrder = 14000
                        },
                        new
                        {
                            SubCatId = 144,
                            CatId = 150,
                            SubCatName = "Computers",
                            SubCatOrder = 14400
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MyExpenses.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyExpenses.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyExpenses.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyExpenses.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}