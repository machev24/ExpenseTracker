using System.ComponentModel.DataAnnotations;

/// <summary>
/// Data Models Transaction namespace
/// </summary>
namespace Data.Models
{
    /// <summary>
    /// Data Models Transaction Class
    /// </summary>
    public class Transcaction
    {
        /// <summary>
        /// Transaction ID
        /// </summary>
        [Key]
        public int TransactionId { get; set; }

        /// <summary>
        /// Category ID
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Category from Data.Models.Category
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Transaction amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Transaction note
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Transaction date
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
