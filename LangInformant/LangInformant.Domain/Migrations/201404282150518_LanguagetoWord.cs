namespace LangInformant.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LanguagetoWord : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Words", "Language_LanguageID", c => c.Int());
            CreateIndex("dbo.Words", "Language_LanguageID");
            AddForeignKey("dbo.Words", "Language_LanguageID", "dbo.Languages", "LanguageID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Words", "Language_LanguageID", "dbo.Languages");
            DropIndex("dbo.Words", new[] { "Language_LanguageID" });
            DropColumn("dbo.Words", "Language_LanguageID");
        }
    }
}
