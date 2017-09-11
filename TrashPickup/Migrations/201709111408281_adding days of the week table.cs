namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingdaysoftheweektable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.AddressModels");
            CreateTable(
                "dbo.DaysOfTheWeekModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.AddressModels", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.AddressModels", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.AddressModels");
            AlterColumn("dbo.AddressModels", "ID", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.DaysOfTheWeekModels");
            AddPrimaryKey("dbo.AddressModels", "ID");
        }
    }
}
