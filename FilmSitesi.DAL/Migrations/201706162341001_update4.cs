namespace FilmSitesi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Aciklama", c => c.String());
            DropColumn("dbo.Films", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Description", c => c.String());
            DropColumn("dbo.Films", "Aciklama");
        }
    }
}
