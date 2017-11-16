namespace MVCMiscellaneous.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershipWithTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Title");
        }
    }
}
