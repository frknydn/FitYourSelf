namespace FitYourSelf.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "Protein", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Foods", "Şeker");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "Şeker", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Foods", "Protein");
        }
    }
}
