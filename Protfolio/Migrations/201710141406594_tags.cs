namespace Protfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tags : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Project_Name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.Projects", t => t.Project_Name)
                .Index(t => t.Project_Name);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "Project_Name", "dbo.Projects");
            DropIndex("dbo.Tags", new[] { "Project_Name" });
            DropTable("dbo.Tags");
        }
    }
}
