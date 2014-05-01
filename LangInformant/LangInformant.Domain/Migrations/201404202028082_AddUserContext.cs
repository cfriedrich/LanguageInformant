namespace LangInformant.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Country = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            AddColumn("dbo.Lessons", "User_UserID", c => c.Int());
            CreateIndex("dbo.Lessons", "User_UserID");
            AddForeignKey("dbo.Lessons", "User_UserID", "dbo.Users", "UserID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lessons", "User_UserID", "dbo.Users");
            DropIndex("dbo.Lessons", new[] { "User_UserID" });
            DropColumn("dbo.Lessons", "User_UserID");
            DropTable("dbo.Users");
        }
    }
}
