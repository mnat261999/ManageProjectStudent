namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassGroupOfSubject",
                c => new
                    {
                        GroupID = c.String(nullable: false, maxLength: 10, unicode: false),
                        GroupName = c.String(maxLength: 100),
                        StaffID = c.String(maxLength: 10, unicode: false),
                        SubjectID = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.GroupID)
                .ForeignKey("dbo.Staff", t => t.StaffID)
                .ForeignKey("dbo.Subject", t => t.SubjectID)
                .Index(t => t.StaffID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        StaffID = c.String(nullable: false, maxLength: 10, unicode: false),
                        StaffName = c.String(maxLength: 100),
                        CardID = c.String(maxLength: 8000, unicode: false),
                        BirthDay = c.DateTime(nullable: false, storeType: "date"),
                        Email = c.String(maxLength: 200, unicode: false),
                        Address = c.String(maxLength: 4000),
                        Phone = c.String(maxLength: 30, unicode: false),
                        Status = c.Boolean(nullable: false),
                        Sex = c.String(maxLength: 10),
                        StaffTypeID = c.String(maxLength: 10, unicode: false),
                        FacultyID = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.StaffID)
                .ForeignKey("dbo.Faculty", t => t.FacultyID)
                .ForeignKey("dbo.StaffType", t => t.StaffTypeID)
                .Index(t => t.StaffTypeID)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.Faculty",
                c => new
                    {
                        FacultyID = c.String(nullable: false, maxLength: 10, unicode: false),
                        FacultyName = c.String(maxLength: 100),
                        FoundedYear = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.FacultyID);
            
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        ClassID = c.String(nullable: false, maxLength: 10, unicode: false),
                        ClassName = c.String(maxLength: 100),
                        FacultyID = c.String(maxLength: 10, unicode: false),
                        Course = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.ClassID)
                .ForeignKey("dbo.Course", t => t.Course)
                .ForeignKey("dbo.Faculty", t => t.FacultyID)
                .Index(t => t.FacultyID)
                .Index(t => t.Course);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseID = c.String(nullable: false, maxLength: 10, unicode: false),
                        StartYear = c.DateTime(nullable: false, storeType: "date"),
                        EndYear = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.CourseID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 10, unicode: false),
                        StudentName = c.String(maxLength: 100),
                        BirthDay = c.DateTime(nullable: false, storeType: "date"),
                        CardID = c.String(maxLength: 8000, unicode: false),
                        Email = c.String(maxLength: 200, unicode: false),
                        Address = c.String(maxLength: 4000),
                        StartYear = c.DateTime(nullable: false, storeType: "date"),
                        Status = c.Boolean(nullable: false),
                        Sex = c.String(maxLength: 10),
                        Phone = c.String(maxLength: 30, unicode: false),
                        FacultyID = c.String(maxLength: 10, unicode: false),
                        ClassID = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Class", t => t.ClassID)
                .ForeignKey("dbo.Faculty", t => t.FacultyID)
                .Index(t => t.FacultyID)
                .Index(t => t.ClassID);
            
            CreateTable(
                "dbo.ExamResult",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 10, unicode: false),
                        ExamTimesID = c.String(nullable: false, maxLength: 10, unicode: false),
                        SubjectID = c.String(nullable: false, maxLength: 10, unicode: false),
                        Grade = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.StudentID, t.ExamTimesID, t.SubjectID })
                .ForeignKey("dbo.ExamTimes", t => t.ExamTimesID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.ExamTimesID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.ExamTimes",
                c => new
                    {
                        ExamTimesID = c.String(nullable: false, maxLength: 10, unicode: false),
                        Times = c.Int(nullable: false),
                        ExamTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExamTimesID);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        SubjectID = c.String(nullable: false, maxLength: 10, unicode: false),
                        SubjectName = c.String(maxLength: 100),
                        StartDay = c.DateTime(nullable: false, storeType: "date"),
                        EndDay = c.DateTime(nullable: false, storeType: "date"),
                        FacultyID = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.SubjectID)
                .ForeignKey("dbo.Faculty", t => t.FacultyID)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ProjectID = c.String(nullable: false, maxLength: 10, unicode: false),
                        ProjectName = c.String(maxLength: 4000),
                        StartDay = c.DateTime(nullable: false, storeType: "date"),
                        EndDay = c.DateTime(nullable: false, storeType: "date"),
                        StaffID = c.String(maxLength: 10, unicode: false),
                        SubjectID = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.Staff", t => t.StaffID)
                .ForeignKey("dbo.Subject", t => t.SubjectID)
                .Index(t => t.StaffID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.ProjectTask",
                c => new
                    {
                        ProjectID = c.String(nullable: false, maxLength: 10, unicode: false),
                        TaskID = c.String(nullable: false, maxLength: 10, unicode: false),
                        TaskName = c.String(maxLength: 100),
                        StartDay = c.DateTime(nullable: false, storeType: "date"),
                        EndDay = c.DateTime(nullable: false, storeType: "date"),
                        FileName = c.String(maxLength: 100),
                        LinkFile = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => new { t.ProjectID, t.TaskID })
                .ForeignKey("dbo.Project", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ResultProject",
                c => new
                    {
                        ProjectID = c.String(nullable: false, maxLength: 10, unicode: false),
                        StudentID = c.String(nullable: false, maxLength: 10, unicode: false),
                        Grade = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ProjectID, t.StudentID })
                .ForeignKey("dbo.Project", t => t.ProjectID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.ProjectID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.SubjectAssignment",
                c => new
                    {
                        TrainingProgramID = c.String(nullable: false, maxLength: 10, unicode: false),
                        FacultyID = c.String(nullable: false, maxLength: 10, unicode: false),
                        SubjectID = c.String(nullable: false, maxLength: 10, unicode: false),
                        Semester = c.String(maxLength: 4000),
                        SchoolYear = c.DateTime(nullable: false, storeType: "date"),
                        Credits = c.Int(nullable: false),
                        TheoreticalLesson = c.Int(nullable: false),
                        PracticalLesson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TrainingProgramID, t.FacultyID, t.SubjectID })
                .ForeignKey("dbo.Faculty", t => t.FacultyID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .ForeignKey("dbo.TrainingProgram", t => t.TrainingProgramID, cascadeDelete: true)
                .Index(t => t.TrainingProgramID)
                .Index(t => t.FacultyID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.TrainingProgram",
                c => new
                    {
                        TrainingProgramID = c.String(nullable: false, maxLength: 10, unicode: false),
                        TrainingProgramName = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.TrainingProgramID);
            
            CreateTable(
                "dbo.TeachAndStudy",
                c => new
                    {
                        StaffID = c.String(nullable: false, maxLength: 10, unicode: false),
                        StudentID = c.String(nullable: false, maxLength: 10, unicode: false),
                        SubjectID = c.String(nullable: false, maxLength: 10, unicode: false),
                        Semester = c.String(maxLength: 100),
                        SchoolYear = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => new { t.StaffID, t.StudentID, t.SubjectID })
                .ForeignKey("dbo.Staff", t => t.StaffID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.StaffID)
                .Index(t => t.StudentID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.StudentClassGroup",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 10, unicode: false),
                        GroupID = c.String(nullable: false, maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.GroupID })
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.ClassGroupOfSubject", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.StaffType",
                c => new
                    {
                        StaffTypeID = c.String(nullable: false, maxLength: 10, unicode: false),
                        StaffTypeName = c.String(maxLength: 100),
                        DecentralizeModel_StrFrmID = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.StaffTypeID)
                .ForeignKey("dbo.Decentralize", t => t.DecentralizeModel_StrFrmID)
                .Index(t => t.DecentralizeModel_StrFrmID);
            
            CreateTable(
                "dbo.Decentralize",
                c => new
                    {
                        FormID = c.String(nullable: false, maxLength: 100, unicode: false),
                        StaffTypeID = c.String(maxLength: 10, unicode: false),
                        FullFunction = c.Boolean(name: "Full Function", nullable: false),
                        Add = c.Boolean(nullable: false),
                        Edit = c.Boolean(nullable: false),
                        Delete = c.Boolean(nullable: false),
                        Access = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FormID);
            
            CreateTable(
                "dbo.Language",
                c => new
                    {
                        LanguageID = c.String(nullable: false, maxLength: 10, unicode: false),
                        LanguageName = c.String(maxLength: 100),
                        Default = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LanguageID);
            
            CreateTable(
                "dbo.Language_Word",
                c => new
                    {
                        LanguageID = c.String(nullable: false, maxLength: 10, unicode: false),
                        WordID = c.String(nullable: false, maxLength: 10, unicode: false),
                        Mean = c.String(maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.LanguageID, t.WordID })
                .ForeignKey("dbo.Language", t => t.LanguageID, cascadeDelete: true)
                .ForeignKey("dbo.Word", t => t.WordID, cascadeDelete: true)
                .Index(t => t.LanguageID)
                .Index(t => t.WordID);
            
            CreateTable(
                "dbo.Word",
                c => new
                    {
                        WordID = c.String(nullable: false, maxLength: 10, unicode: false),
                        WordName = c.String(maxLength: 100),
                        Module = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.WordID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Language_Word", "WordID", "dbo.Word");
            DropForeignKey("dbo.Language_Word", "LanguageID", "dbo.Language");
            DropForeignKey("dbo.StudentClassGroup", "GroupID", "dbo.ClassGroupOfSubject");
            DropForeignKey("dbo.Staff", "StaffTypeID", "dbo.StaffType");
            DropForeignKey("dbo.StaffType", "DecentralizeModel_StrFrmID", "dbo.Decentralize");
            DropForeignKey("dbo.Staff", "FacultyID", "dbo.Faculty");
            DropForeignKey("dbo.StudentClassGroup", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Student", "FacultyID", "dbo.Faculty");
            DropForeignKey("dbo.TeachAndStudy", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.TeachAndStudy", "StudentID", "dbo.Student");
            DropForeignKey("dbo.TeachAndStudy", "StaffID", "dbo.Staff");
            DropForeignKey("dbo.SubjectAssignment", "TrainingProgramID", "dbo.TrainingProgram");
            DropForeignKey("dbo.SubjectAssignment", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.SubjectAssignment", "FacultyID", "dbo.Faculty");
            DropForeignKey("dbo.Project", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.Project", "StaffID", "dbo.Staff");
            DropForeignKey("dbo.ResultProject", "StudentID", "dbo.Student");
            DropForeignKey("dbo.ResultProject", "ProjectID", "dbo.Project");
            DropForeignKey("dbo.ProjectTask", "ProjectID", "dbo.Project");
            DropForeignKey("dbo.Subject", "FacultyID", "dbo.Faculty");
            DropForeignKey("dbo.ExamResult", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.ClassGroupOfSubject", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.ExamResult", "StudentID", "dbo.Student");
            DropForeignKey("dbo.ExamResult", "ExamTimesID", "dbo.ExamTimes");
            DropForeignKey("dbo.Student", "ClassID", "dbo.Class");
            DropForeignKey("dbo.Class", "FacultyID", "dbo.Faculty");
            DropForeignKey("dbo.Class", "Course", "dbo.Course");
            DropForeignKey("dbo.ClassGroupOfSubject", "StaffID", "dbo.Staff");
            DropIndex("dbo.Language_Word", new[] { "WordID" });
            DropIndex("dbo.Language_Word", new[] { "LanguageID" });
            DropIndex("dbo.StaffType", new[] { "DecentralizeModel_StrFrmID" });
            DropIndex("dbo.StudentClassGroup", new[] { "GroupID" });
            DropIndex("dbo.StudentClassGroup", new[] { "StudentID" });
            DropIndex("dbo.TeachAndStudy", new[] { "SubjectID" });
            DropIndex("dbo.TeachAndStudy", new[] { "StudentID" });
            DropIndex("dbo.TeachAndStudy", new[] { "StaffID" });
            DropIndex("dbo.SubjectAssignment", new[] { "SubjectID" });
            DropIndex("dbo.SubjectAssignment", new[] { "FacultyID" });
            DropIndex("dbo.SubjectAssignment", new[] { "TrainingProgramID" });
            DropIndex("dbo.ResultProject", new[] { "StudentID" });
            DropIndex("dbo.ResultProject", new[] { "ProjectID" });
            DropIndex("dbo.ProjectTask", new[] { "ProjectID" });
            DropIndex("dbo.Project", new[] { "SubjectID" });
            DropIndex("dbo.Project", new[] { "StaffID" });
            DropIndex("dbo.Subject", new[] { "FacultyID" });
            DropIndex("dbo.ExamResult", new[] { "SubjectID" });
            DropIndex("dbo.ExamResult", new[] { "ExamTimesID" });
            DropIndex("dbo.ExamResult", new[] { "StudentID" });
            DropIndex("dbo.Student", new[] { "ClassID" });
            DropIndex("dbo.Student", new[] { "FacultyID" });
            DropIndex("dbo.Class", new[] { "Course" });
            DropIndex("dbo.Class", new[] { "FacultyID" });
            DropIndex("dbo.Staff", new[] { "FacultyID" });
            DropIndex("dbo.Staff", new[] { "StaffTypeID" });
            DropIndex("dbo.ClassGroupOfSubject", new[] { "SubjectID" });
            DropIndex("dbo.ClassGroupOfSubject", new[] { "StaffID" });
            DropTable("dbo.Word");
            DropTable("dbo.Language_Word");
            DropTable("dbo.Language");
            DropTable("dbo.Decentralize");
            DropTable("dbo.StaffType");
            DropTable("dbo.StudentClassGroup");
            DropTable("dbo.TeachAndStudy");
            DropTable("dbo.TrainingProgram");
            DropTable("dbo.SubjectAssignment");
            DropTable("dbo.ResultProject");
            DropTable("dbo.ProjectTask");
            DropTable("dbo.Project");
            DropTable("dbo.Subject");
            DropTable("dbo.ExamTimes");
            DropTable("dbo.ExamResult");
            DropTable("dbo.Student");
            DropTable("dbo.Course");
            DropTable("dbo.Class");
            DropTable("dbo.Faculty");
            DropTable("dbo.Staff");
            DropTable("dbo.ClassGroupOfSubject");
        }
    }
}
