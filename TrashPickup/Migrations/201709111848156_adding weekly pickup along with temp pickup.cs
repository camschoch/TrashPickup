namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingweeklypickupalongwithtemppickup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RegularPickup", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "ActualPickup", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "Pickup");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Pickup", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "ActualPickup");
            DropColumn("dbo.AspNetUsers", "RegularPickup");
        }
    }
}
