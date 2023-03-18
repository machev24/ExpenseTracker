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
        /// <summary>
        /// Database Connection String
        /// </summary>
        private const string connectionString = "";

        /// <summary>
        /// Transaction Table from Database
        /// </summary>
        public DbSet<Transaction> Transactions { get; set; }

        /// <summary>
        /// Category Table from Database
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Default Construstor
        /// </summary>
        public Context(): base()
        {
            //empty
        }

        /// <summary>
        /// Set Connection String Configuration
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}