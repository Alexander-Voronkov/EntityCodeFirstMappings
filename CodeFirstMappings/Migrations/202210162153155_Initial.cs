namespace CodeFirstMappings.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        City = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place = c.Int(nullable: false),
                        Competition_Id = c.Int(),
                        Participant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.Competition_Id)
                .ForeignKey("dbo.Participants", t => t.Participant_Id)
                .Index(t => t.Competition_Id)
                .Index(t => t.Participant_Id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Birth = c.DateTime(nullable: false, storeType: "date"),
                        Country = c.String(nullable: false, maxLength: 100),
                        Weight = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "Participant_Id", "dbo.Participants");
            DropForeignKey("dbo.Results", "Competition_Id", "dbo.Competitions");
            DropIndex("dbo.Results", new[] { "Participant_Id" });
            DropIndex("dbo.Results", new[] { "Competition_Id" });
            DropTable("dbo.Participants");
            DropTable("dbo.Results");
            DropTable("dbo.Competitions");
        }
    }
}
