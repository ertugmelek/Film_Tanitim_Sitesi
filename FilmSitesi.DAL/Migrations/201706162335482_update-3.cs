namespace FilmSitesi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Description");
        }
    }
}
