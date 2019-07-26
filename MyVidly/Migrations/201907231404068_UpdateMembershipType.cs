namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipTypeValue='Pay as You GO' WHERE Id=1");
            Sql("UPDATE MembershipTypes SET MembershipTypeValue='Monthlly' WHERE Id=2");
            Sql("UPDATE MembershipTypes SET MembershipTypeValue='Quarterlly' WHERE Id=3");
            Sql("UPDATE MembershipTypes SET MembershipTypeValue='Annually' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
