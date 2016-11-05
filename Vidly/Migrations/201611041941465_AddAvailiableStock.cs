namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailiableStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailiable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailiable");
        }
    }
}
