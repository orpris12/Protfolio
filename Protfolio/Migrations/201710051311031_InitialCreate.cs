namespace Protfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        UploadDate = c.DateTime(name: "Upload Date", nullable: false),
                        Video = c.String(),
                        Image = c.String(),
                        GithubLink = c.String(name: "Github Link"),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
        }
    }
}
