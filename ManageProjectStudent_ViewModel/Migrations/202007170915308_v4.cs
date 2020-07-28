namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Decentralize", name: "Full Function", newName: "FullFunction");
            CreateTable(
                "dbo.Form",
                c => new
                    {
                        FormID = c.String(nullable: false, maxLength: 100, unicode: false),
                        FormName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.FormID);
            
            AddColumn("dbo.Decentralize", "View", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Decentralize", "FormID");
            AddForeignKey("dbo.Decentralize", "FormID", "dbo.Form", "FormID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Decentralize", "FormID", "dbo.Form");
            DropIndex("dbo.Decentralize", new[] { "FormID" });
            DropColumn("dbo.Decentralize", "View");
            DropTable("dbo.Form");
            RenameColumn(table: "dbo.Decentralize", name: "FullFunction", newName: "Full Function");
        }
    }
}
