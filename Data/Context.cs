using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

/// <summary>
/// Expense Tracker Data namespace
/// </summary>
namespace Data
{
    /// <summary>
    /// Db Context class
    /// </summary>
    public class Context: DbContext
    {
        private const string connectionString = "";

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

        public Context(): base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}