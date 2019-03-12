namespace firstDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDataPlayers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Players (LastName) VALUES ('Jovanova')");
            Sql("INSERT INTO Players (FirstName) VALUES ('Viktorija')");
        }
        
        public override void Down()
        {
        }
    }
}
