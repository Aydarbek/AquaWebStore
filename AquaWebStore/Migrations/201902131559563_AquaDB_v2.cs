namespace AquaWebStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AquaDB_v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Hsuits", "Collection_CollectionId", "dbo.Collections");
            DropForeignKey("dbo.Orders", "HSuit_Id", "dbo.Hsuits");
            DropIndex("dbo.Hsuits", new[] { "Collection_CollectionId" });
            DropIndex("dbo.Orders", new[] { "HSuit_Id" });
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        PhotoId = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        hsuit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.PhotoId)
                .ForeignKey("dbo.Hsuits", t => t.hsuit_Id)
                .Index(t => t.hsuit_Id);
            
            CreateTable(
                "dbo.PromoCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Discount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubOrders",
                c => new
                    {
                        SuborderId = c.Int(nullable: false, identity: true),
                        Qty = c.Int(nullable: false),
                        SubTotal = c.Int(nullable: false),
                        Hsuit_Id = c.Int(),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.SuborderId)
                .ForeignKey("dbo.Hsuits", t => t.Hsuit_Id)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Hsuit_Id)
                .Index(t => t.Order_OrderId);
            
            AddColumn("dbo.Hsuits", "Category_CategoryId", c => c.Int());
            AddColumn("dbo.Orders", "SubTotal", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Total", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "PromoCode_Id", c => c.Int());
            AlterColumn("dbo.Hsuits", "Size", c => c.String());
            CreateIndex("dbo.Hsuits", "Category_CategoryId");
            CreateIndex("dbo.Orders", "PromoCode_Id");
            AddForeignKey("dbo.Hsuits", "Category_CategoryId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Orders", "PromoCode_Id", "dbo.PromoCodes", "Id");
            DropColumn("dbo.Hsuits", "Photo");
            DropColumn("dbo.Hsuits", "Sex");
            DropColumn("dbo.Hsuits", "Collection_CollectionId");
            DropColumn("dbo.Orders", "HSuit_Id");
            DropTable("dbo.Collections");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Collections",
                c => new
                    {
                        CollectionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CollectionId);
            
            AddColumn("dbo.Orders", "HSuit_Id", c => c.Int());
            AddColumn("dbo.Hsuits", "Collection_CollectionId", c => c.Int());
            AddColumn("dbo.Hsuits", "Sex", c => c.String());
            AddColumn("dbo.Hsuits", "Photo", c => c.String());
            DropForeignKey("dbo.SubOrders", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.SubOrders", "Hsuit_Id", "dbo.Hsuits");
            DropForeignKey("dbo.Orders", "PromoCode_Id", "dbo.PromoCodes");
            DropForeignKey("dbo.Photos", "hsuit_Id", "dbo.Hsuits");
            DropForeignKey("dbo.Hsuits", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.SubOrders", new[] { "Order_OrderId" });
            DropIndex("dbo.SubOrders", new[] { "Hsuit_Id" });
            DropIndex("dbo.Orders", new[] { "PromoCode_Id" });
            DropIndex("dbo.Photos", new[] { "hsuit_Id" });
            DropIndex("dbo.Hsuits", new[] { "Category_CategoryId" });
            AlterColumn("dbo.Hsuits", "Size", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "PromoCode_Id");
            DropColumn("dbo.Orders", "Total");
            DropColumn("dbo.Orders", "SubTotal");
            DropColumn("dbo.Hsuits", "Category_CategoryId");
            DropTable("dbo.SubOrders");
            DropTable("dbo.PromoCodes");
            DropTable("dbo.Photos");
            DropTable("dbo.Categories");
            CreateIndex("dbo.Orders", "HSuit_Id");
            CreateIndex("dbo.Hsuits", "Collection_CollectionId");
            AddForeignKey("dbo.Orders", "HSuit_Id", "dbo.Hsuits", "Id");
            AddForeignKey("dbo.Hsuits", "Collection_CollectionId", "dbo.Collections", "CollectionId");
        }
    }
}
