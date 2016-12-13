namespace AssetTracker.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrganizationChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Organizations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Organizations", "Code", c => c.String(maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Organizations", "Code", c => c.String());
            AlterColumn("dbo.Organizations", "Name", c => c.String());
        }
    }
}
