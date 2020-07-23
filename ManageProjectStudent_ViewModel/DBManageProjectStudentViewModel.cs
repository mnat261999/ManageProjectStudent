using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model; 

namespace ManageProjectStudent_ViewModel
{
    public class DBManageProjectStudentViewModel : DbContext
    {
        public DBManageProjectStudentViewModel() : base("DBManageProjectStudent")
        {
            //var _InitIalizer = new MigrateDatabaseToLatestVersion<DBManageProjectStudentViewModel, Migrations.Configuration>();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBManageProjectStudentViewModel, Migrations.Configuration>());
        }

        public DbSet<StudentModel> StudentModels { get; set; }
        public DbSet<ProjectModel> ProjectModels { get; set; }
        public DbSet<ClassGroupOfSubject> ClassGroupOfSubjects { get; set; }
        public DbSet<ClassModel> ClassModels { get; set; }
        public DbSet<ExamResultModel> ExamResultModels { get; set; }
        public DbSet<ExamTimesModel> ExamTimesModels { get; set; }
        public DbSet<ProjectTaskModel> ProjectTaskModels { get; set; }
        public DbSet<ResultProjectModel> ResultProjectModels { get; set; }
        public DbSet<StaffModel> StaffModels { get; set; }
        public DbSet<StaffTypeModel> StaffTypeModels { get; set; }
        public DbSet<StudentClassGroup> StudentClassGroups { get; set; }
        public DbSet<SubjectAssignmentModel> SubjectAssignmentModels { get; set; }
        public DbSet<SubjectModel> SubjectModels { get; set; }
        public DbSet<TeachAndStudy> TeachAndStudies { get; set; }
        public DbSet<TrainingProgramModel> TrainingProgramModels { get; set; }
        public DbSet<FacultyModel> FacultyModels { get; set; }
        public DbSet<CourseModel> CourseModels { get; set; }

        public DbSet<WordModel> WordModels { get; set; }
        public DbSet<LanguageModel> LanguageModels { get; set; }
        public DbSet<LanguageWordModel> LanguageWordModels { get; set; }
        public DbSet<DecentralizeModel> DecentralizeModels { get; set; }
        public DbSet<FormModel> FormModels { get; set; }
    }
}
