using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    /// <summary>
    /// Movie model class
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Unique ID of the movie
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the movie
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Genre of the movie
        /// </summary>
        [Required]
        public Genre Genre { get; set; }
        /// <summary>
        /// Release Date of the movie
        /// </summary>
        [Required]
        public string ReleaseDate { get; set; }
        /// <summary>
        /// Date the movie was added in the database
        /// </summary>
        [Required]
        public string DateAdded { get; set; }
        /// <summary>
        /// Number of copies of the movie in stock
        /// </summary>
        [Required]
        public int NumInStock { get; set; }
    }
}