namespace Archery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifTournament : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tournaments", "Location", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tournaments", "Location", c => c.String());
        }
    }
}
