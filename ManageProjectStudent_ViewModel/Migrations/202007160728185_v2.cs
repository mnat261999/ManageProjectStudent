namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StaffType", "DecentralizeModel_StrFrmID", "dbo.Decentralize");
            DropIndex("dbo.StaffType", new[] { "DecentralizeModel_StrFrmID" });
            DropColumn("dbo.StaffType", "DecentralizeModel_StrFrmID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StaffType", "DecentralizeModel_StrFrmID", c => c.String(maxLength: 100, unicode: false));
            CreateIndex("dbo.StaffType", "DecentralizeModel_StrFrmID");
            AddForeignKey("dbo.StaffType", "DecentralizeModel_StrFrmID", "dbo.Decentralize", "FormID");
        }
    }
}
