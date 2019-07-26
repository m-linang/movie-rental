namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreIdValue1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre_Id = (CASE WHEN Id=1 THEN 5 WHEN Id=2 THEN 4 WHEN Id=3 THEN 3 WHEN Id=4 THEN 2 WHEN Id=5 THEN 1 END)");
        }
        
        public override void Down()
        {
        }
    }
}
