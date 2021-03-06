namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableChanges : DbMigration
    {
        public override void Up()
        {
            DropTable("DevTest");

            CreateTable(
                "dbo.DevTest",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompaignName = c.String(),
                        Date = c.DateTime(nullable: false),
                        Clicks = c.Int(nullable: false),
                        Conversions = c.Int(nullable: false),
                        Impressions = c.Int(),
                        AffiliateName = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DevTest");
        }
    }
}
