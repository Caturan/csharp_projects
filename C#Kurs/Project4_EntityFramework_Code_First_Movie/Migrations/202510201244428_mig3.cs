namespace Project4_EntityFramework_Code_First_Movie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
