using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using PayPal.Models;

namespace PayPal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160129164814_[Update 6]")]
    partial class Update6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("PayPal.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.ActualReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<double>("EstimatedCustomerAmount");

                    b.Property<bool>("IsGain");

                    b.Property<double>("Return");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.Benchmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ActualReportId");

                    b.Property<int?>("BenchmarkContainerId");

                    b.Property<int?>("CompletionPercent");

                    b.Property<int?>("ExpectedReportId");

                    b.Property<bool?>("IsComplete");

                    b.Property<double>("ShortTermGoal");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.BenchmarkContainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("AmountSpent");

                    b.Property<double?>("AverageReturnValue");

                    b.Property<bool?>("IsRegularCustomer");

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<bool?>("RespondsToUpselling");

                    b.Property<int?>("SatisfactionPercent");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.ExpectedReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<double>("EstimatedCustomerAmount");

                    b.Property<bool>("IsGain");

                    b.Property<double>("Return");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FakeTransactionsId");

                    b.Property<int?>("TodaysTransactionsId");

                    b.Property<int?>("TotalTransactionsId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.FakeTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExpenseId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BenchmarkContainerId");

                    b.Property<int?>("CompletionPercent");

                    b.Property<double>("ExpectedCareerLength");

                    b.Property<double>("ExpectedTotalDaily");

                    b.Property<double>("RealisticTotalDaily");

                    b.Property<double>("YearlyGoalIncome");

                    b.Property<double>("YearlyIncome");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.TodaysTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExpenseId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.TotalTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExpenseId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AmountReceived");

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime>("Date");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.TransactionContainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExpenseId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.PeopleModel.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<double?>("Hourly");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<int?>("RoleID");

                    b.Property<double?>("Salary");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.PeopleModel.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DefaultHourlyWage");

                    b.Property<int?>("DefaultSalary");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PayPal.Models.PeopleModel.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<TimeSpan>("CompletionTime");

                    b.Property<int>("DifficultyLevel");

                    b.Property<string>("Name");

                    b.Property<int>("RoleID");

                    b.Property<int>("ValueLevel");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PayPal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PayPal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("PayPal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.Benchmark", b =>
                {
                    b.HasOne("PayPal.Models.FinanceModel.ActualReport")
                        .WithMany()
                        .HasForeignKey("ActualReportId");

                    b.HasOne("PayPal.Models.FinanceModel.BenchmarkContainer")
                        .WithMany()
                        .HasForeignKey("BenchmarkContainerId");

                    b.HasOne("PayPal.Models.FinanceModel.ExpectedReport")
                        .WithMany()
                        .HasForeignKey("ExpectedReportId");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.Expense", b =>
                {
                    b.HasOne("PayPal.Models.FinanceModel.FakeTransaction")
                        .WithMany()
                        .HasForeignKey("FakeTransactionsId");

                    b.HasOne("PayPal.Models.FinanceModel.TodaysTransaction")
                        .WithMany()
                        .HasForeignKey("TodaysTransactionsId");

                    b.HasOne("PayPal.Models.FinanceModel.TotalTransaction")
                        .WithMany()
                        .HasForeignKey("TotalTransactionsId");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.FakeTransaction", b =>
                {
                    b.HasOne("PayPal.Models.FinanceModel.Expense")
                        .WithOne()
                        .HasForeignKey("PayPal.Models.FinanceModel.FakeTransaction", "ExpenseId");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.Goal", b =>
                {
                    b.HasOne("PayPal.Models.FinanceModel.BenchmarkContainer")
                        .WithMany()
                        .HasForeignKey("BenchmarkContainerId");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.TodaysTransaction", b =>
                {
                    b.HasOne("PayPal.Models.FinanceModel.Expense")
                        .WithOne()
                        .HasForeignKey("PayPal.Models.FinanceModel.TodaysTransaction", "ExpenseId");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.TotalTransaction", b =>
                {
                    b.HasOne("PayPal.Models.FinanceModel.Expense")
                        .WithOne()
                        .HasForeignKey("PayPal.Models.FinanceModel.TotalTransaction", "ExpenseId");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.Transaction", b =>
                {
                    b.HasOne("PayPal.Models.FinanceModel.Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("PayPal.Models.FinanceModel.TransactionContainer", b =>
                {
                    b.HasOne("PayPal.Models.FinanceModel.Expense")
                        .WithMany()
                        .HasForeignKey("ExpenseId");
                });

            modelBuilder.Entity("PayPal.Models.PeopleModel.Employee", b =>
                {
                    b.HasOne("PayPal.Models.PeopleModel.Role")
                        .WithMany()
                        .HasForeignKey("RoleID");
                });

            modelBuilder.Entity("PayPal.Models.PeopleModel.Task", b =>
                {
                    b.HasOne("PayPal.Models.PeopleModel.Role")
                        .WithMany()
                        .HasForeignKey("RoleID");
                });
        }
    }
}
