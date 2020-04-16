namespace MovieShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteUserMovieReviewRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Review", "MovieId", "dbo.Movie");
            DropForeignKey("dbo.Review", "UserId", "dbo.User");
            DropIndex("dbo.Review", new[] { "UserId" });
            DropIndex("dbo.Review", new[] { "MovieId" });
            DropTable("dbo.Review");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Review",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                        Rating = c.Decimal(precision: 18, scale: 2),
                        ReviewText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Review", "MovieId");
            CreateIndex("dbo.Review", "UserId");
            AddForeignKey("dbo.Review", "UserId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Review", "MovieId", "dbo.Movie", "Id", cascadeDelete: true);
        }
    }
}
