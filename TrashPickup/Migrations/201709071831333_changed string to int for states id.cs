namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedstringtointforstatesid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.States");
            AlterColumn("dbo.States", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.States", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.States");
            AlterColumn("dbo.States", "ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.States", "ID");
        }
    }
}
