using System.ComponentModel.DataAnnotations;

/// <summary>
/// Expense Tracker Data Models namespace
/// </summary>
namespace Data.Models
{
    /// <summary>
    /// Data Models Category Class
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Category ID
        /// </summary>
        [Key]
        public int CategoryId { get; set; }

        /// <summary>
        /// Category Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Category Icon
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Category Type
        /// </summary>
        public string Type { get; set; }
    }
}
