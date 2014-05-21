namespace BookReviewer.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Book_Id", "dbo.Books");
            DropIndex("dbo.Reviews", new[] { "Book_Id" });
            AddColumn("dbo.Reviews", "BookId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "BookId");
            AddForeignKey("dbo.Reviews", "BookId", "dbo.Books", "Id", cascadeDelete: false);
            DropColumn("dbo.Reviews", "Book_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Book_Id", c => c.Int());
            DropForeignKey("dbo.Reviews", "BookId", "dbo.Books");
            DropIndex("dbo.Reviews", new[] { "BookId" });
            DropColumn("dbo.Reviews", "BookId");
            CreateIndex("dbo.Reviews", "Book_Id");
            AddForeignKey("dbo.Reviews", "Book_Id", "dbo.Books", "Id");
        }
    }
}
