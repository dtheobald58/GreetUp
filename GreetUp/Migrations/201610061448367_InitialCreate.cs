namespace GreetUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrganizerName = c.String(),
                        EventDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        MaxNumOfGuests = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RSVPs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PrimaryGuestName = c.String(),
                        NumOfGuests = c.Int(nullable: false),
                        Email = c.String(),
                        EventID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Events", t => t.EventID, cascadeDelete: true)
                .Index(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RSVPs", "EventID", "dbo.Events");
            DropIndex("dbo.RSVPs", new[] { "EventID" });
            DropTable("dbo.RSVPs");
            DropTable("dbo.Events");
        }
    }
}
