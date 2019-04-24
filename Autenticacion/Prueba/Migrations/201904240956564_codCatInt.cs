namespace Prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class codCatInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CodCat", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "CodCat", c => c.String(maxLength: 3));
        }
    }
}
