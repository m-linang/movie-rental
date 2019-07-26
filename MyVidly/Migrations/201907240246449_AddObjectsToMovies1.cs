namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddObjectsToMovies1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Stocks", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Stocks", c => c.String());
        }
    }
}
