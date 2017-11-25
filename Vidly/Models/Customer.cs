using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsSubscribedToNewsletter { get; set; }
        [Required]
        public MembershipType MembershipType { get; set; }
    }
}