namespace ITI.MVC.Project.Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "KeyWord", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "KeyWord");
        }
    }
}
