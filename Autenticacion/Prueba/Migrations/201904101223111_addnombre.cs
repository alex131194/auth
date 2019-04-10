namespace Prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnombre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nombre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Nombre");
        }
    }
}
