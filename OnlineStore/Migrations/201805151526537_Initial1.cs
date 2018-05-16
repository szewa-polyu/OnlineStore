namespace OnlineStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "Brand_BrandId" });
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            AlterColumn("dbo.Brands", "BrandNo", c => c.String());
            AlterColumn("dbo.Products", "ProductNo", c => c.String());
            AlterColumn("dbo.Products", "Brand_BrandId", c => c.Int());
            AlterColumn("dbo.Products", "Category_CategoryId", c => c.Int());
            CreateIndex("dbo.Products", "Brand_BrandId");
            CreateIndex("dbo.Products", "Category_CategoryId");
            AddForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands", "BrandId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands");
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            DropIndex("dbo.Products", new[] { "Brand_BrandId" });
            AlterColumn("dbo.Products", "Category_CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Brand_BrandId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "ProductNo", c => c.String(nullable: false));
            AlterColumn("dbo.Brands", "BrandNo", c => c.String(nullable: false));
            CreateIndex("dbo.Products", "Category_CategoryId");
            CreateIndex("dbo.Products", "Brand_BrandId");
            AddForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands", "BrandId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
    }
}
