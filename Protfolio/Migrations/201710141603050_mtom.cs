namespace Protfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mtom : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Tags", new[] { "project_Name" });
            CreateIndex("dbo.Tags", "Project_Name");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tags", new[] { "Project_Name" });
            CreateIndex("dbo.Tags", "project_Name");
        }
    }
}
