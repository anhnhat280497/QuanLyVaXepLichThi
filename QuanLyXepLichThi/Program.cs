using QLXLT_Data.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXepLichThi
{
    static class Program
    {
        public static string usernameAdmin = "1";
        public static string passwordAdmin = "1";

        public static MainForm formMain;
        public static LoginForm formLogin;
        public static TeacherForm formGiangVien;
        public static ClassForm formLop;
        public static CreditClassForm formLopTinChi;
        public static SubjectForm formMon;
        public static RoomForm formPhong;
        //public static FormSinhVien formSinhVien;
        public static FormXepLichThi formXepLichThi;
        public static XLTContext dbContext;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formLogin = new LoginForm();
            khoiTaoContext();


            Application.Run(formLogin);
        }

        static void khoiTaoContext()
        {
            dbContext = new XLTContext();
            dbContext.Class.Load();
            dbContext.CreditClass.Load();
            dbContext.Person.Load();
            dbContext.Room.Load();
            dbContext.Student.Load();
            dbContext.Subject.Load();
            dbContext.Teacher.Load();
            dbContext.TestSchedule.Load();
            dbContext.TestScheduleDetail.Load();
        }
    }
}
