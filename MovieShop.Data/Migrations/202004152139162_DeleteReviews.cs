namespace MovieShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteReviews : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Review");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Review",
                c => new
                    {
                        MovieId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReviewText = c.String(),
                    })
                .PrimaryKey(t => new { t.MovieId, t.UserId });
            
        }
    }
}
