namespace casino_oxana_back.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg142 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserBalance", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.UserBalance", new[] { "Id" });
            AddColumn("dbo.AspNetUsers", "Balance", c => c.Int(nullable: false));
            DropTable("dbo.UserBalance");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserBalance",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AllWinningsAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.AspNetUsers", "Balance");
            CreateIndex("dbo.UserBalance", "Id");
            AddForeignKey("dbo.UserBalance", "Id", "dbo.AspNetUsers", "Id");
        }
    }
}
