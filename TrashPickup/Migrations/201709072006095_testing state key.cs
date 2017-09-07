namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testingstatekey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "StateKey", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "StateKey");
        }
    }
}
