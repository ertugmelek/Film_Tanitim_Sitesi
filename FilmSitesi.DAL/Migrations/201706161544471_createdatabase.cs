namespace FilmSitesi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "Resim", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "Resim", c => c.Binary(nullable: false));
        }
    }
}
