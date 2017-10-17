namespace Protfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tagid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tags", "Project_Name", "dbo.Projects");
            DropIndex("dbo.Tags", new[] { "Project_Name" });
            DropTable("dbo.Tags");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Project_Name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateIndex("dbo.Tags", "Project_Name");
            AddForeignKey("dbo.Tags", "Project_Name", "dbo.Projects", "Name");
        }
    }
}
