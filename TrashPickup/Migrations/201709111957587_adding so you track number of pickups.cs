namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingsoyoutracknumberofpickups : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NumberOfPickups", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "WeeklyStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "WeeklyStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "NumberOfPickups");
        }
    }
}
