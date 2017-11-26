using System;
using System.Collections.Generic;
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
        public string Name { get; set; }
    }
}