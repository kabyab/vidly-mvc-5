using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public byte SignUpFee { get; set; }
        public short DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}