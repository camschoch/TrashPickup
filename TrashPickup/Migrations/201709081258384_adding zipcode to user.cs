namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingzipcodetouser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ZipCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ZipCode");
        }
    }
}
