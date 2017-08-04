namespace FilmSitesi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "Suresi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Films", "Puanı", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "Puanı", c => c.Int(nullable: false));
            AlterColumn("dbo.Films", "Suresi", c => c.Int(nullable: false));
        }
    }
}
