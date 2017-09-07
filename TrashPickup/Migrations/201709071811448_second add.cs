namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondadd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressModels",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        City = c.String(),
                        Zip = c.Int(nullable: false),
                        HomeAddress = c.String(),
                        StateID = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        State = c.String(),
                        StateAbriviation = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.States");
            DropTable("dbo.AddressModels");
        }
    }
}
