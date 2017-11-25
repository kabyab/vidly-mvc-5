namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipType_Id) VALUES ('John Williams', 0, 2)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipType_Id) VALUES ('Mary Smith', 1, 1)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipType_Id) VALUES ('Harold Hargrove', 1, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
