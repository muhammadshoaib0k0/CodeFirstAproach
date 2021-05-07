namespace CodeFirstAproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manytomanyADDtablesDEVELOPERPROJECTPROJECTASSIGNDEVELOPER : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        DevId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNum = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.DevId);
            
            CreateTable(
                "dbo.ProjectAssignDevelopers",
                c => new
                    {
                        ProjectAssignDeveloperId = c.Int(nullable: false, identity: true),
                        DevId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectAssignDeveloperId)
                .ForeignKey("dbo.Developers", t => t.DevId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.DevId)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectAssignDevelopers", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ProjectAssignDevelopers", "DevId", "dbo.Developers");
            DropIndex("dbo.ProjectAssignDevelopers", new[] { "ProjectId" });
            DropIndex("dbo.ProjectAssignDevelopers", new[] { "DevId" });
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectAssignDevelopers");
            DropTable("dbo.Developers");
        }
    }
}
