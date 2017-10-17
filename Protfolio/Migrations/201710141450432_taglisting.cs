namespace Protfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taglisting : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Tags", new[] { "Project_Name" });
            AddColumn("dbo.Projects", "tagListing", c => c.String());
            CreateIndex("dbo.Tags", "project_Name");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tags", new[] { "project_Name" });
            DropColumn("dbo.Projects", "tagListing");
            CreateIndex("dbo.Tags", "Project_Name");
        }
    }
}
