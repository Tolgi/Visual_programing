namespace firstDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDataTeams : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Teams (TeamName) VALUES ('ACEe')");
        }
        
        public override void Down()
        {
        }
    }
}
