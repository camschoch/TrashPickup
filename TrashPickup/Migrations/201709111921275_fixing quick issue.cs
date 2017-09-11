namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingquickissue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "WeeklyStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AddressModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Zip = c.Int(nullable: false),
                        HomeAddress = c.String(),
                        StateID = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.AspNetUsers", "WeeklyStatus");
        }
    }
}
