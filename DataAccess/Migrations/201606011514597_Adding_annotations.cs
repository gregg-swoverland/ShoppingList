namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adding_annotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ShoppingLists", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ShoppingLists", "Color", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ShoppingLists", "Color", c => c.String());
            AlterColumn("dbo.ShoppingLists", "Name", c => c.String());
        }
    }
}
