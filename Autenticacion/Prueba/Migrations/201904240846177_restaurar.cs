namespace Prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restaurar : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "CodCat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CodCat", c => c.String(maxLength: 128));
        }
    }
}
