namespace CodeFirstAproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablevehicleandperson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                        VehicleName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.People", t => t.PersonId)
                .Index(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "PersonId", "dbo.People");
            DropIndex("dbo.Vehicles", new[] { "PersonId" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.People");
        }
    }
}
