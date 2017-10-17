namespace Protfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SummmaryAndTags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Summary", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Summary");
        }
    }
}
