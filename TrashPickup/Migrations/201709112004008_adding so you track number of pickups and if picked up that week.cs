namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingsoyoutracknumberofpickupsandifpickedupthatweek : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "WeeklyStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "WeeklyStatus");
        }
    }
}
