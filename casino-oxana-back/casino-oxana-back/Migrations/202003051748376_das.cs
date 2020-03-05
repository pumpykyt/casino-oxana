namespace casino_oxana_back.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class das : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
          
        }
        
        public override void Down()
        {
       
            DropIndex("dbo.UserBalance", new[] { "Id" });
           
        }
    }
}
