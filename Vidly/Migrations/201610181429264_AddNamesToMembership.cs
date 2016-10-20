namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNamesToMembership : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Free' WHERE Id='1';");
            Sql("UPDATE MembershipTypes SET Name='Monthly' WHERE Id='2';");
            Sql("UPDATE MembershipTypes SET Name=Three months' WHERE Id='3';");
            Sql("UPDATE MembershipTypes SET Name='Yearly' WHERE Id='4';");
        }
        
        public override void Down()
        {
        }
    }
}
