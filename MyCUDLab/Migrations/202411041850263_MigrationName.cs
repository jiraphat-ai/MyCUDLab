namespace MyCUDLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Image");
        }
    }
}
