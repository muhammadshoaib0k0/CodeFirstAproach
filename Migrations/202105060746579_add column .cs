namespace CodeFirstAproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Location");
        }
    }
}
