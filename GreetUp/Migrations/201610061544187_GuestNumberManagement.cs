namespace GreetUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuestNumberManagement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "CurrentNumOfGuests", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "CurrentNumOfGuests");
        }
    }
}
