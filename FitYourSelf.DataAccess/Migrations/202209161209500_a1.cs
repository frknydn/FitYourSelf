namespace FitYourSelf.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserMeals", "Calorie", c => c.Double(nullable: false));
            DropColumn("dbo.UserMeals", "Portion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserMeals", "Portion", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.UserMeals", "Calorie", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
