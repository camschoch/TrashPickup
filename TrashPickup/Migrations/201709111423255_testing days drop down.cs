namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testingdaysdropdown : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DaysOfTheWeekModels", "DayKey", c => c.Int(nullable: false));
            AddColumn("dbo.DaysOfTheWeekModels", "DaysOfTheWeek_Id", c => c.Int());
            CreateIndex("dbo.DaysOfTheWeekModels", "DaysOfTheWeek_Id");
            AddForeignKey("dbo.DaysOfTheWeekModels", "DaysOfTheWeek_Id", "dbo.DaysOfTheWeekModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DaysOfTheWeekModels", "DaysOfTheWeek_Id", "dbo.DaysOfTheWeekModels");
            DropIndex("dbo.DaysOfTheWeekModels", new[] { "DaysOfTheWeek_Id" });
            DropColumn("dbo.DaysOfTheWeekModels", "DaysOfTheWeek_Id");
            DropColumn("dbo.DaysOfTheWeekModels", "DayKey");
        }
    }
}
