namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreData : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres ( Name) values ('Action')");
            Sql("insert into Genres ( Name) values ('Comedy')");
            Sql("insert into Genres (Name) values ('Family')");
            Sql("insert into Genres ( Name) values ('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
