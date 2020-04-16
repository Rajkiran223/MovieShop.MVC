namespace MovieShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMovieCast : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.MovieCast");
            DropTable("dbo.MovieCrew");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MovieCrew",
                c => new
                    {
                        MovieId = c.Int(nullable: false),
                        CrewId = c.Int(nullable: false),
                        Department = c.String(nullable: false, maxLength: 128),
                        Job = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.MovieId, t.CrewId, t.Department, t.Job });
            
            CreateTable(
                "dbo.MovieCast",
                c => new
                    {
                        MovieId = c.Int(nullable: false),
                        CastId = c.Int(nullable: false),
                        Character = c.String(nullable: false, maxLength: 450),
                    })
                .PrimaryKey(t => new { t.MovieId, t.CastId, t.Character });
            
        }
    }
}
