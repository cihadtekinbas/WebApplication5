namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kapı",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MahalleKodu = c.Int(nullable: false),
                        Koordinatlar = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mahalles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MahalleName = c.String(),
                        Koordinatlar = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mahalles");
            DropTable("dbo.Kapı");
        }
    }
}
