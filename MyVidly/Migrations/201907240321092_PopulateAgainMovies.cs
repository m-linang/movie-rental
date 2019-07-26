namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAgainMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, Genre, Stocks) VALUES (1, 'Shrek', 'Comedy', 5)");
            Sql("INSERT INTO Movies (Id, Name, Genre, Stocks) VALUES (2, 'Green Paradise', 'Action', 10)");
            Sql("INSERT INTO Movies (Id, Name, Genre, Stocks) VALUES (3, 'Balahibong Pusa', 'Horror', 15)");
            Sql("INSERT INTO Movies (Id, Name, Genre, Stocks) VALUES (4, 'Lanitnit ng Papag', 'Suspense', 20)");
            Sql("INSERT INTO Movies (Id, Name, Genre, Stocks) VALUES (5, 'Malalim na Gabi', 'Action', 25)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
