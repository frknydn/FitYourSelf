namespace FitYourSelf.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kritik : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserInfoes", "WaterAmount");
            DropColumn("dbo.UserInfoes", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserInfoes", "MyProperty", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoes", "WaterAmount", c => c.Double());
        }
    }
}
