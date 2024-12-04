namespace MarketDatabase.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BarcodeNo = c.String(),
                        ProductName = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockProducts",
                c => new
                    {
                        StokId = c.Int(nullable: false, identity: true),
                        BarcodeNo = c.String(),
                        BrandName = c.String(),
                        CategoryName = c.String(),
                        ProductName = c.String(),
                        Amount = c.Int(nullable: false),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchaseData = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StokId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StockProducts");
            DropTable("dbo.Sales");
        }
    }
}
