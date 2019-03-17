namespace AquaWebStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aqua_DB_v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hsuits", "DefaultImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hsuits", "DefaultImage");
        }
    }
}
