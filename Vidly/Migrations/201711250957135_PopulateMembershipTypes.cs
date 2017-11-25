namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (30, 3, 10)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (90, 6, 15)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (180, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
