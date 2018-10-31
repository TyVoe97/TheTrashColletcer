namespace TrashColletctor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Zipcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Zipcode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PhoneNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "PhoneNumber");
            DropColumn("dbo.Customers", "Zipcode");
        }
    }
}
