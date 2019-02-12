namespace AquaWebStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.Hsuits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Photo = c.String(),
                        Sex = c.String(),
                        Size = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Collection_CollectionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Collections", t => t.Collection_CollectionId)
                .Index(t => t.Collection_CollectionId);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        FeedbackId = c.Int(nullable: false, identity: true),
                        Author = c.String(),
                        PostTime = c.DateTime(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.FeedbackId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        TimeStamp = c.DateTime(nullable: false),
                        Status = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        EMail = c.String(),
                        Phone = c.String(),
                        HSuit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Hsuits", t => t.HSuit_Id)
                .Index(t => t.HSuit_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        EMail = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "HSuit_Id", "dbo.Hsuits");
            DropForeignKey("dbo.Hsuits", "Collection_CollectionId", "dbo.Collections");
            DropIndex("dbo.Orders", new[] { "HSuit_Id" });
            DropIndex("dbo.Hsuits", new[] { "Collection_CollectionId" });
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Hsuits");
            DropTable("dbo.Collections");
        }
    }
}
