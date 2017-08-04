namespace FilmSitesi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urls",
                c => new
                    {
                        UrlId = c.Int(nullable: false, identity: true),
                        UrlAdresi = c.String(),
                        film_FilmId = c.Int(),
                    })
                .PrimaryKey(t => t.UrlId)
                .ForeignKey("dbo.Films", t => t.film_FilmId)
                .Index(t => t.film_FilmId);
            
            AddColumn("dbo.Films", "ResimPath", c => c.String(nullable: false));
            AddColumn("dbo.Films", "Suresi", c => c.Int(nullable: false));
            AddColumn("dbo.Films", "Puanı", c => c.Int(nullable: false));
            DropColumn("dbo.Films", "Url");
            DropColumn("dbo.Films", "Resim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Resim", c => c.String(nullable: false));
            AddColumn("dbo.Films", "Url", c => c.String(nullable: false));
            DropForeignKey("dbo.Urls", "film_FilmId", "dbo.Films");
            DropIndex("dbo.Urls", new[] { "film_FilmId" });
            DropColumn("dbo.Films", "Puanı");
            DropColumn("dbo.Films", "Suresi");
            DropColumn("dbo.Films", "ResimPath");
            DropTable("dbo.Urls");
        }
    }
}
