namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedMovieAddedMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumInStock, Genre_Id) VALUES ('Hangover', 'Friday, June 26, 2009', 'Sunday, November 26, 2017', 5, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumInStock, Genre_Id) VALUES ('Inception', 'Friday, July 16, 2010', 'Sunday, November 26, 2017', 7, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumInStock, Genre_Id) VALUES ('Wall-E', 'Friday, June 21, 2008', 'Saturday, November 25, 2017', 4, 4)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumInStock, Genre_Id) VALUES ('The Fault in Our Stars', 'Friday, July 4, 2014', 'Sunday, November 26, 2017', 5, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumInStock, Genre_Id) VALUES ('The Dark Knight', 'Friday, July 18, 2008', 'Saturday, November 25, 2017', 8, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumInStock, Genre_Id) VALUES ('Toy Story 3', 'Friday, June 25, 2010', 'Friday, November 24, 2017', 6, 4)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumInStock, Genre_Id) VALUES ('The Dictator', 'Friday, may 16, 2012', 'Thursday, November 23, 2017', 2, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
