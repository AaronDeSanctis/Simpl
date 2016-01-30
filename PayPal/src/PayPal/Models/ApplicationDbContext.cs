using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using PayPal.ViewModels;
using PayPal.Models.PeopleModel;
using PayPal.Models.FinanceModel;

namespace PayPal.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Employee> DBEmployees { get; set; }
        public DbSet<Role> DBRoles { get; set; }
        public DbSet<PeopleModel.Task> DBTasks { get; set; }
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Expense> Expenses {get; set;}
        public DbSet<ActualReport> ActualReports {get; set;}
        public DbSet<ExpectedReport> ExpectedReports{get; set;}
        public DbSet<FakeTransaction> FakeTransactions{get; set;}
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TodaysTransaction> TodaysTransactions { get; set; }
        public DbSet<TotalTransaction> TotalTransactions { get; set; }
        public DbSet<TransactionContainer> TransactionContainers { get; set; }
        public DbSet<Benchmark> Benchmarks {get; set;}
        public DbSet<BenchmarkContainer> BenchmarkContainers { get; set; }
        public DbSet<Goal> Goals {get; set;}
    }
}
