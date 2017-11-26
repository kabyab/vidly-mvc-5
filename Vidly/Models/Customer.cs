using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    /// <summary>
    /// Customer Model class
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Unique ID of every Customer
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of customer. The attribute makes it NOT NULL.
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Whether the customer has subscribed to newsletter or not
        /// </summary>
        [Required]
        public bool IsSubscribedToNewsletter { get; set; }
        /// <summary>
        /// Type of memnership. This is a navigation type.
        /// </summary>
        [Required]
        public MembershipType MembershipType { get; set; }
    }
}