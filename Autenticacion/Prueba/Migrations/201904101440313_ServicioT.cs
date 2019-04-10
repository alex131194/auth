namespace Prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServicioT : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ServicioT", c => c.String(nullable: false, maxLength: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ServicioT");
        }
    }
}
