namespace MVCMiscellaneous.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_more_titles_to_membership : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.MembershipTypes SET Title = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE dbo.MembershipTypes SET Title = 'Monthly'       WHERE Id = 2");
            Sql("UPDATE dbo.MembershipTypes SET Title = 'Quarterly'     WHERE Id = 3");
            Sql("UPDATE dbo.MembershipTypes SET Title = 'Yearly'        WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
