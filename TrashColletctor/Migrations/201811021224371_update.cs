namespace TrashColletctor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "employeeId", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "emplyeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "emplyeeId", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "employeeId");
        }
    }
}
