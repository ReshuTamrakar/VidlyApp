namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesName : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name = 'Monthly' where Id = 1");
            Sql("update MembershipTypes set Name = 'Quaterly' where Id = 2");
            Sql("update MembershipTypes set Name = 'Annual' where Id = 3");
            Sql("update MembershipTypes set Name = 'DayWise' where Id = 4");

        }

        public override void Down()
        {
        }
    }
}


