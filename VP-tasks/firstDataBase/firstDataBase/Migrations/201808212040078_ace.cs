namespace firstDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ace : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Teams (TeamName) VALUES ('ACEe') (City) VALUES ('Radovishh') (Province) VALUES ('dasdasdasa')");
        }
        
        public override void Down()
        {
        }
    }
}
