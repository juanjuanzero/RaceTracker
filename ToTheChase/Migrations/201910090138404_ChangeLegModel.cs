namespace ToTheChase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeLegModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Legs",
                c => new
                    {
                        LegID = c.Int(nullable: false, identity: true),
                        LegNumber = c.Int(nullable: false),
                        LengthInMiles = c.Double(nullable: false),
                        LegDifficulty = c.Int(nullable: false),
                        AssignedRunner_RunnerID = c.Int(),
                        EndExchange_ExchangeID = c.Int(),
                        StartExchange_ExchangeID = c.Int(),
                    })
                .PrimaryKey(t => t.LegID)
                .ForeignKey("dbo.Runners", t => t.AssignedRunner_RunnerID)
                .ForeignKey("dbo.Exchanges", t => t.EndExchange_ExchangeID)
                .ForeignKey("dbo.Exchanges", t => t.StartExchange_ExchangeID)
                .Index(t => t.AssignedRunner_RunnerID)
                .Index(t => t.EndExchange_ExchangeID)
                .Index(t => t.StartExchange_ExchangeID);
            
            CreateTable(
                "dbo.Runners",
                c => new
                    {
                        RunnerID = c.Int(nullable: false, identity: true),
                        RunnerNumber = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PaceMinutes = c.Int(nullable: false),
                        PaceSeconds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RunnerID);
            
            CreateTable(
                "dbo.Exchanges",
                c => new
                    {
                        ExchangeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsMajorExchange = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ExchangeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Legs", "StartExchange_ExchangeID", "dbo.Exchanges");
            DropForeignKey("dbo.Legs", "EndExchange_ExchangeID", "dbo.Exchanges");
            DropForeignKey("dbo.Legs", "AssignedRunner_RunnerID", "dbo.Runners");
            DropIndex("dbo.Legs", new[] { "StartExchange_ExchangeID" });
            DropIndex("dbo.Legs", new[] { "EndExchange_ExchangeID" });
            DropIndex("dbo.Legs", new[] { "AssignedRunner_RunnerID" });
            DropTable("dbo.Exchanges");
            DropTable("dbo.Runners");
            DropTable("dbo.Legs");
        }
    }
}
