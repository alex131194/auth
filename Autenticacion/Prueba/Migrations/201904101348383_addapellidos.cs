namespace Prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addapellidos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Apellidos", c => c.String(nullable: true, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Apellidos");
        }
    }
}
