namespace ToTheChase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRunnerLegtoInt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Legs", "AssignedRunner_RunnerID", "dbo.Runners");
            DropIndex("dbo.Legs", new[] { "AssignedRunner_RunnerID" });
            AddColumn("dbo.Legs", "AssignedRunnerId", c => c.Int(nullable: false));
            DropColumn("dbo.Legs", "AssignedRunner_RunnerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Legs", "AssignedRunner_RunnerID", c => c.Int());
            DropColumn("dbo.Legs", "AssignedRunnerId");
            CreateIndex("dbo.Legs", "AssignedRunner_RunnerID");
            AddForeignKey("dbo.Legs", "AssignedRunner_RunnerID", "dbo.Runners", "RunnerID");
        }
    }
}
