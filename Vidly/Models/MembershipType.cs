namespace Vidly.Models
{
    /// <summary>
    /// Membership Type model class
    /// </summary>
    public class MembershipType
    {
        /// <summary>
        /// Unique ID to reference the membership type. Is a foreign key in Customer table.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the membership. Depends on DurationInMonths.
        /// </summary>
        public string Name { get; set; }    
        /// <summary>
        /// Sign Up Fee for the particular membership.
        /// </summary>
        public byte SignUpFee { get; set; }
        /// <summary>
        /// Duration of membership.
        /// </summary>
        public short DurationInMonths { get; set; }
        /// <summary>
        /// Discount rate applied to particular membership.
        /// </summary>
        public byte DiscountRate { get; set; }
    }
}