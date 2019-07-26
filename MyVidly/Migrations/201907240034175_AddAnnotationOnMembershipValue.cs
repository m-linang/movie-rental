namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationOnMembershipValue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipTypeValue", c => c.String(nullable: false));
            Sql("UPDATE MembershipTypes SET MembershipTypeValue = (CASE WHEN Id=1 THEN 'PAY As YOU GO' WHEN Id=2 THEN 'Monthly' WHEN Id=3 THEN 'Quarterly' WHEN Id=4 THEN 'Annually' END)");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipTypeValue", c => c.String());
        }
    }
}
