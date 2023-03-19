using System.ComponentModel.DataAnnotations;

/// <summary>
/// Expense Tracker Data Models namespace
/// </summary>
namespace Data.Models
{
    /// <summary>
    /// Data Models Transaction Class
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Transaction ID
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// Category ID
        /// </summary>
        public int category { get; set; }

        /// <summary>
        /// Category from Data.Models.Category
        /// </summary>
        // public Category Category { get; set; }

        /// <summary>
        /// Transaction amount
        /// </summary>
        public decimal amount { get; set; }

        /// <summary>
        /// Transaction note
        /// </summary>
        public string? note { get; set; }

        /// <summary>
        /// Transaction date
        /// </summary>
        public DateTime date { get; set; } = DateTime.Now;
    }
}
