namespace Prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class camposNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Apellidos", c => c.String(maxLength: 100));
            AlterColumn("dbo.AspNetUsers", "MailContacto", c => c.String());
            AlterColumn("dbo.AspNetUsers", "NombreEmpresa", c => c.String(maxLength: 100));
            AlterColumn("dbo.AspNetUsers", "ServicioT", c => c.String(maxLength: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "ServicioT", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.AspNetUsers", "NombreEmpresa", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.AspNetUsers", "MailContacto", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Apellidos", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
