namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Decentralize");
            AlterColumn("dbo.Decentralize", "StaffTypeID", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AddPrimaryKey("dbo.Decentralize", new[] { "FormID", "StaffTypeID" });
            CreateIndex("dbo.Decentralize", "StaffTypeID");
            AddForeignKey("dbo.Decentralize", "StaffTypeID", "dbo.StaffType", "StaffTypeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Decentralize", "StaffTypeID", "dbo.StaffType");
            DropIndex("dbo.Decentralize", new[] { "StaffTypeID" });
            DropPrimaryKey("dbo.Decentralize");
            AlterColumn("dbo.Decentralize", "StaffTypeID", c => c.String(maxLength: 10, unicode: false));
            AddPrimaryKey("dbo.Decentralize", "FormID");
        }
    }
}
