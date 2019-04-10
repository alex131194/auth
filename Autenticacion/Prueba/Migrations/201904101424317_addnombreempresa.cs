namespace Prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnombreempresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NombreEmpresa", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NombreEmpresa");
        }
    }
}
