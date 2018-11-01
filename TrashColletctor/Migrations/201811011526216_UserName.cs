namespace TrashColletctor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserName : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            AddColumn("dbo.Customers", "firstName", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Customers", "UserName", c => c.String());
            AddPrimaryKey("dbo.Customers", "firstName");
            DropColumn("dbo.Customers", "fristName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "fristName", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Customers");
            DropColumn("dbo.Customers", "UserName");
            DropColumn("dbo.Customers", "firstName");
            AddPrimaryKey("dbo.Customers", "fristName");
        }
    }
}
