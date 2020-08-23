namespace CLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimingMigrations1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calendars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumYear = c.Int(nullable: false),
                        Days_NumDay = c.Byte(nullable: false),
                        Days_DayOfWeek = c.String(nullable: false),
                        Days_RedDay = c.Boolean(nullable: false),
                        Months_NumMonth = c.Byte(nullable: false),
                        Months_NameMonth = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CalendarId = c.Int(nullable: false),
                        TextEvent = c.String(),
                        PlaceEvent = c.String(),
                        StartDate = c.String(),
                        EndDate = c.String(),
                        IsEvent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Calendars", t => t.CalendarId, cascadeDelete: true)
                .Index(t => t.CalendarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "CalendarId", "dbo.Calendars");
            DropIndex("dbo.Events", new[] { "CalendarId" });
            DropTable("dbo.Events");
            DropTable("dbo.Calendars");
        }
    }
}
