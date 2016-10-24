namespace SklepInternetowy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniePolaOpisSkrocony : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kurs", "OpisSkrucony", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kurs", "OpisSkrucony");
        }
    }
}
