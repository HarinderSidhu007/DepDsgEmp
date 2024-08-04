namespace WebApplication2_DepDsgEmp_1147.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToDepDsgModels : DbMigration
    {
        public override void Up()
        {
            Sql("insert Departments values('Accounts')");
            Sql("insert Departments values('Sales')");
            Sql("insert Departments values('Mkt')");
            Sql("insert Departments values('Computers')");
            //Designations
            Sql("insert Designations values('PM')");
            Sql("insert Designations values('TL')");
            Sql("insert Designations values('Prog.')");
        }
        
        public override void Down()
        {
        }
    }
}
