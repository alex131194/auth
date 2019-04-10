namespace Prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmailcontacto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MailContacto", c => c.String(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MailContacto");
        }
    }
}
