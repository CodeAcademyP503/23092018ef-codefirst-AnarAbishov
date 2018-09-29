namespace BankCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        DateCredit = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 55),
                        Surname = c.String(nullable: false, maxLength: 55),
                        PasportNumber = c.String(nullable: false, maxLength: 55),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.PasportNumber, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditInfoes", "UserId", "dbo.Users");
            DropIndex("dbo.Users", new[] { "PasportNumber" });
            DropIndex("dbo.CreditInfoes", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.CreditInfoes");
        }
    }
}
