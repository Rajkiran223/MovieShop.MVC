namespace MovieShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMovieCastTable : DbMigration
    {
        public override void Up()
        {
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
        
        public override void Down()
        {
            DropTable("dbo.MovieCast");
        }
    }
}
