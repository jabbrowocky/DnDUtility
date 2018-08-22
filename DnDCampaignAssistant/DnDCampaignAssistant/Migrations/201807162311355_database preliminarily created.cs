namespace DnDCampaignAssistant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databasepreliminarilycreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerClasses",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        ClassType = c.String(),
                    })
                .PrimaryKey(t => t.ClassId);
            
            CreateTable(
                "dbo.PlayerNotes",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.NoteId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        ClassId = c.Int(nullable: false),
                        StatsId = c.Int(nullable: false),
                        IsDM = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayerClasses", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.Stats", t => t.StatsId, cascadeDelete: true)
                .Index(t => t.ClassId)
                .Index(t => t.StatsId);
            
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        StatsId = c.Int(nullable: false, identity: true),
                        Strength = c.Int(nullable: false),
                        Dexterity = c.Int(nullable: false),
                        Constitution = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        Wisdom = c.Int(nullable: false),
                        Charisma = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "StatsId", "dbo.Stats");
            DropForeignKey("dbo.Players", "ClassId", "dbo.PlayerClasses");
            DropIndex("dbo.Players", new[] { "StatsId" });
            DropIndex("dbo.Players", new[] { "ClassId" });
            DropTable("dbo.Stats");
            DropTable("dbo.Players");
            DropTable("dbo.PlayerNotes");
            DropTable("dbo.PlayerClasses");
        }
    }
}
