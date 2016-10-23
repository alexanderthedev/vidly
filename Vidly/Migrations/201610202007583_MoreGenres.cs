namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into GenreTypes (Name) VALUES ('Action') ");
            Sql("INSERT into GenreTypes (Name) VALUES ('Romantic') ");
            Sql("INSERT into GenreTypes (Name) VALUES ('Cartoon') ");

        }

        public override void Down()
        {
        }
    }
}
