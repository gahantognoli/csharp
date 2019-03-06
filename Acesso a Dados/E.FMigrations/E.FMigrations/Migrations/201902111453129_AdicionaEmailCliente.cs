namespace E.FMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionaEmailCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Email");
        }
    }
}
