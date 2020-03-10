namespace casino_oxana_back.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgBalance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Balance");
        }
    }
}
