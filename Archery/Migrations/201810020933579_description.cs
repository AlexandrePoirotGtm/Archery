namespace Archery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tournaments", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tournaments", "Description");
        }
    }
}
