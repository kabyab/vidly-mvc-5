using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    /// <summary>
    /// Genre model class
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// Unique identifier of Genre
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Genre Name
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}