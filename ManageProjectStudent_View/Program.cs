using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using ManageProjectStudent_Interface;
using ManageProjectStudent_ViewModel;

namespace ManageProjectStudent_View
{
    static class Config
    {
        public static UnityContainer Container { get; private set; } = new UnityContainer();

        public static void Register()
        {
            // Thu
            Container.RegisterType<IStaff, StaffViewModel>();
            Container.RegisterType<IStudent, StudentViewModel>();
            Container.RegisterType<IClass, ClassViewModel>();
            Container.RegisterType<IFaculty, FacultyViewModel>();
            Container.RegisterType<IProject, ProjectViewModel>();
            Container.RegisterType<IProjectTask, ProjectTaskViewModel>();
            Container.RegisterType<ISubject, SubjectViewModel>();
            Container.RegisterType<ICourse, CourseViewModel>();
            Container.RegisterType<IStaffType, StaffTypeViewModel>();
            Container.RegisterType<IDecentralize, DecentralizeViewModel>();
            Container.RegisterType<IForm, FormViewModel>();
            // Thu
            // Thong
            Container.RegisterType<IManageClass, ManageClassViewModel>();
            Container.RegisterType<IManageFaculty, ManageFacultyViewModel>();
            Container.RegisterType<IManageCourse, ManageCourseViewModel>();
            Container.RegisterType<IManageSubject, ManageSubjectViewModel>();
            Container.RegisterType<ISubmitProject, SubmitProjectViewModel>();
            // Thong

            // Thong
            Container.RegisterType<IAddGroupForSubject, AddGroupForSubjectViewModel>();
            Container.RegisterType<IManageMultiLanguage, ManageMultiLanguageViewModel>();
            // Thong
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config.Register();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHome());
        }
    }
}
