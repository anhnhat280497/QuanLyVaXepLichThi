using QLXLT_Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXLT_Data.Data
{
    class DataSeeder
    {
        private static XLTContext context;
        public static void Seed(XLTContext context)
        {
            DataSeeder.context = context;
            SeedClass();
            SeedStudent();
            SeedRoom();
            SeedSubject();
            Seedteacher();
            SeedCreditClass();
        }

        private static void SeedCreditClass()
        {
            List<CreditClass> list = new List<CreditClass>();
            List<Student> listStudent;
            listStudent = new List<Student>();
            listStudent.AddRange(context.Student.Where(x=>x.ClassId == 1));
            list.Add(new CreditClass() { CreditClassId = 1, IsActive = true, SubjectId = 2 , TeacherId = 2, Students = listStudent });
            listStudent = new List<Student>();
            listStudent.AddRange(context.Student.Where(x => x.ClassId == 2));
            list.Add(new CreditClass() { CreditClassId = 2, IsActive = true, SubjectId = 1, TeacherId = 1 , Students = listStudent });
            listStudent = new List<Student>();
            listStudent.AddRange(context.Student.Where(x => x.ClassId == 3));
            list.Add(new CreditClass() { CreditClassId = 3, IsActive = false, SubjectId = 3, TeacherId = 1, Students = listStudent });
            context.CreditClass.AddRange(list);
            context.SaveChanges();
        }

        private static void SeedStudent()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { PersonId = 1, FirstName = "Nhật", LastName = "Nguyễn Anh", PersonCode = "N15DCCN037", ClassId = 1 });
            list.Add(new Student() { PersonId = 2, FirstName = "Lạc", LastName = "Đào Phi", PersonCode = "N15DCCN005", ClassId = 1 });
            list.Add(new Student() { PersonId = 3, FirstName = "Như", LastName = "Cao Huỳnh", PersonCode = "N15DCCN009", ClassId = 1 });
            list.Add(new Student() { PersonId = 4, FirstName = "Nhi", LastName = "Nguyễn Thị", PersonCode = "N15DCCN018", ClassId = 1 });
            list.Add(new Student() { PersonId = 5, FirstName = "Huệ", LastName = "Đỗ Thị", PersonCode = "N15DCCN045", ClassId = 1 });
            list.Add(new Student() { PersonId = 6, FirstName = "Thanh", LastName = "Trần Thị", PersonCode = "N15DCCN046", ClassId = 1 });
            list.Add(new Student() { PersonId = 7, FirstName = "Tính", LastName = "Mạc Đỗ Xuân", PersonCode = "N15DCCN036", ClassId = 1 });
            list.Add(new Student() { PersonId = 8, FirstName = "Nhung", LastName = "Nguyễn Đào Hồng", PersonCode = "N15DCCN065", ClassId = 1 });

            list.Add(new Student() { PersonId = 9, FirstName = "Tài", LastName = "Nguyễn Tấn", PersonCode = "N15DCCN100", ClassId = 2 });
            list.Add(new Student() { PersonId = 10, FirstName = "Cư", LastName = "Đào Văn", PersonCode = "N15DCCN101", ClassId = 2 });
            list.Add(new Student() { PersonId = 11, FirstName = "Tú", LastName = "Phan Văn", PersonCode = "N15DCCN102", ClassId = 2 });
            list.Add(new Student() { PersonId = 12, FirstName = "Khoa", LastName = "Phan Văn", PersonCode = "N15DCCN103", ClassId = 2 });
            list.Add(new Student() { PersonId = 13, FirstName = "Linh", LastName = "Trần Nhật", PersonCode = "N15DCCN104", ClassId = 2 });
            list.Add(new Student() { PersonId = 14, FirstName = "Sáng", LastName = "Lê Bá", PersonCode = "N15DCCN105", ClassId = 2 });
            list.Add(new Student() { PersonId = 15, FirstName = "Hiền", LastName = "Nguyễn Thu", PersonCode = "N15DCCN106", ClassId = 2 });
            list.Add(new Student() { PersonId = 16, FirstName = "Trang", LastName = "Phạm Thị Thùy", PersonCode = "N15DCCN107", ClassId = 2 });

            list.Add(new Student() { PersonId = 17, FirstName = "Hiệu", LastName = "Huỳnh Ngọc", PersonCode = "N16DCCN001", ClassId = 3 });
            list.Add(new Student() { PersonId = 18, FirstName = "Diệu", LastName = "Mai Ngọc", PersonCode = "N16DCCN002", ClassId = 3 });
            list.Add(new Student() { PersonId = 19, FirstName = "Thành", LastName = "Võ Trần", PersonCode = "N16DCCN003", ClassId = 3 });

            list.Add(new Student() { PersonId = 20, FirstName = "Hiệp", LastName = "Đinh Hoài", PersonCode = "N16DCCN100", ClassId = 4 });
            context.Student.AddRange(list);
            context.SaveChanges();
        }
        private static void SeedClass()
        {
            List<Class> list = new List<Class>();
            List<Student> listStudent;
            listStudent = new List<Student>();
            listStudent.Add(context.Student.Find(1));
            listStudent.Add(context.Student.Find(2));
            listStudent.Add(context.Student.Find(3));
            listStudent.Add(context.Student.Find(4));
            listStudent.Add(context.Student.Find(5));
            listStudent.Add(context.Student.Find(6));
            listStudent.Add(context.Student.Find(7));
            listStudent.Add(context.Student.Find(8));
            list.Add(new Class() { ClassId = 1, Name = "Công nghệ thông tin 2015 - 1", ClassCode = "D15CQCN01-N", Students = listStudent });
            listStudent = new List<Student>();
            listStudent.Add(context.Student.Find(9));
            listStudent.Add(context.Student.Find(10));
            listStudent.Add(context.Student.Find(11));
            listStudent.Add(context.Student.Find(12));
            listStudent.Add(context.Student.Find(13));
            listStudent.Add(context.Student.Find(14));
            listStudent.Add(context.Student.Find(15));
            listStudent.Add(context.Student.Find(16));
            list.Add(new Class() { ClassId = 2, Name = "Công nghệ thông tin 2015 - 2", ClassCode = "D15CQCN02-N", Students = listStudent });
            listStudent = new List<Student>();
            listStudent.Add(context.Student.Find(17));
            listStudent.Add(context.Student.Find(18));
            listStudent.Add(context.Student.Find(19));
            list.Add(new Class() { ClassId = 3, Name = "Công nghệ thông tin 2016 - 1", ClassCode = "D16CQCN01-N", Students = listStudent });
            listStudent = new List<Student>();
            listStudent.Add(context.Student.Find(20 ));
            list.Add(new Class() { ClassId = 4, Name = "Công nghệ thông tin 2016 - 2", ClassCode = "D16CQCN02-N", Students = listStudent });
            context.Class.AddRange(list);
            context.SaveChanges();
        }
        private static void SeedRoom()
        {
            List<Room> list = new List<Room>();
            list.Add(new Room() { RoomId = 1, Name = "2A01", Seats = 8 });
            list.Add(new Room() { RoomId = 2, Name = "2A02", Seats = 5 });
            list.Add(new Room() { RoomId = 3, Name = "2A03", Seats = 10 });
            list.Add(new Room() { RoomId = 4, Name = "2A04", Seats = 9 });

            list.Add(new Room() { RoomId = 5, Name = "2B01", Seats = 12 });
            list.Add(new Room() { RoomId = 6, Name = "2B02", Seats = 6 });
            list.Add(new Room() { RoomId = 7, Name = "2B03", Seats = 8 });
            list.Add(new Room() { RoomId = 8, Name = "2B04", Seats = 7 });
            context.Room.AddRange(list);
            context.SaveChanges();
        }
        private static void SeedSubject()
        {
            List<Subject> list = new List<Subject>();
            list.Add(new Subject() { SubjectId = 1, Name = "Cấu trúc dữ liệu", SubjectCode = "CTDL", TestTime = 90 });
            list.Add(new Subject() { SubjectId = 2, Name = "Cơ sở dữ liệu", SubjectCode = "CSDL", TestTime = 60 });
            list.Add(new Subject() { SubjectId = 3, Name = "Lập Trình C++", SubjectCode = "LTC++", TestTime = 120 });
            list.Add(new Subject() { SubjectId = 4, Name = "Lập Trình Vi Xử Lý", SubjectCode = "LTVXL", TestTime = 90 });
            list.Add(new Subject() { SubjectId = 5, Name = "Cơ sở dữ liệu phân tán", SubjectCode = "CSDLPT", TestTime = 60 });
            context.Subject.AddRange(list);
            context.SaveChanges();
        }
        private static void Seedteacher()
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { PersonId = 21, FirstName = "Trụ", LastName = "Huỳnh Trung", PersonCode = "GVHTT" });
            list.Add(new Teacher() { PersonId = 22, FirstName = "Thư", LastName = "Lưu Nguyễn Kỳ", PersonCode = "GVLNKT" });
            list.Add(new Teacher() { PersonId = 23, FirstName = "Sáu", LastName = "Nguyễn Văn", PersonCode = "GVNVS" });
            list.Add(new Teacher() { PersonId = 24, FirstName = "Duy", LastName = "Nguyễn Ngọc", PersonCode = "GVNND" });
            list.Add(new Teacher() { PersonId = 25, FirstName = "Hào", LastName = "Nguyễn Anh", PersonCode = "GVNAH" });
            list.Add(new Teacher() { PersonId = 26, FirstName = "Sơn", LastName = "Nguyễn Hồng", PersonCode = "GVNHS" });
            context.Teacher.AddRange(list);
            context.SaveChanges();
        }


        //private static void SeedPlayList()
        //{
        //    List<Playlist> listPlayList = new List<Playlist>();
        //    Playlist playList;
        //    playList = new Playlist()
        //    {
        //        PlayListId = 1,
        //        Name = "NhatNA 1111",
        //        CreateDate = DateTime.Now,
        //        IsPublic = true,
        //        UserId = 1
        //    };
        //    playList.Musics.Add(context.Music.Find(1));
        //    playList.Musics.Add(context.Music.Find(2));
        //    playList.CommentPlaylists.Add(context.CommentPlaylist.Find(4));
        //    playList.LikePlaylists.Add(context.LikePlaylist.Find(4));
        //    listPlayList.Add(playList);

        //    playList = new Playlist()
        //    {
        //        PlayListId = 2,
        //        Name = "111 First",
        //        CreateDate = DateTime.Now,
        //        IsPublic = true,
        //        UserId = 2
        //    };
        //    playList.Musics.Add(context.Music.Find(3));
        //    listPlayList.Add(playList);

        //    playList = new Playlist()
        //    {
        //        PlayListId = 3,
        //        Name = "NhatNA 2222",
        //        CreateDate = DateTime.Now,
        //        IsPublic = true,
        //        UserId = 1
        //    };
        //    playList.Musics.Add(context.Music.Find(1));
        //    playList.CommentPlaylists.Add(context.CommentPlaylist.Find(1));
        //    playList.LikePlaylists.Add(context.LikePlaylist.Find(1));
        //    listPlayList.Add(playList);
        //    context.Playlist.AddRange(listPlayList);
        //    context.SaveChanges();
        //}

        private static void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                ); // Add the original exception as the innerException
            }
        }
    }
}
