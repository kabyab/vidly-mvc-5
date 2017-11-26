namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedBirthDateOfCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1994-05-11' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '1995-11-02' WHERE Id = 3");
            Sql("UPDATE Customers SET BirthDate = '1990-06-23' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
