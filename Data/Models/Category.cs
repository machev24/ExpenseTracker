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
        public int id { get; set; }

        /// <summary>
        /// Category Title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Category Icon
        /// </summary>
        public string icon { get; set; }

        /// <summary>
        /// Category Type
        /// </summary>
        public string type { get; set; }
    }
}
