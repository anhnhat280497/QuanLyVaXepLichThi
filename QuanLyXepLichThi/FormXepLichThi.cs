using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLXLT_Data.Models;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Entity;

namespace QuanLyXepLichThi
{
    public partial class FormXepLichThi : DevExpress.XtraEditors.XtraForm
    {
        private List<CreditClass> listCreditClass;
        private List<Room> listRoom;
        List<TestScheduleDetail> listTest;
        private DateTime startDay, endDay;
        private String namHoc;
        private int hocKy;
        public FormXepLichThi()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            lapDanhSach();
            ShowDataCreditClass(gridControl1, gridView1, listCreditClass);
            ShowDataRoom(gridControl2, gridView2, listRoom);
        }

        void lapDanhSach()
        {
            listCreditClass = new List<CreditClass>();
            listRoom = new List<Room>();
            listCreditClass = Program.dbContext.CreditClass.Where(x => x.IsActive == true).ToList();
            listRoom = Program.dbContext.Room.ToList();
            namHoc = textEditNamHoc.Text.Trim();
            hocKy = int.Parse(numericUpDownHocKy.Text.Trim());
            startDay = dateEditStart.DateTime.Date;
            endDay = dateEditEnd.DateTime.Date;
        }

        public void ShowDataCreditClass(GridControl gridControl, GridView gridView, List<CreditClass> list)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT");
            dataTable.Columns.Add("SubjectId");
            dataTable.Columns.Add("TeacherId");
            dataTable.Columns.Add("IsActive");
            dataTable.Columns.Add("Id");
            dataTable.Columns["STT"].AutoIncrementStep = 1;
            dataTable.Columns["STT"].AutoIncrement = true;
            dataTable.Columns["STT"].AutoIncrementSeed = 1;

            foreach (var item in list)
            {
                dataTable.Rows.Add(null, item.SubjectId, item.TeacherId, item.IsActive, item.CreditClassId);
            }
            gridControl.DataSource = dataTable;
            gridView.Columns["Id"].Visible = false;
            gridView.Columns["STT"].Width = 40;
            gridView.Columns["STT"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["STT"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }
        public void ShowDataRoom(GridControl gridControl, GridView gridView, List<Room> list)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Seats");
            dataTable.Columns.Add("Id");
            dataTable.Columns["STT"].AutoIncrementStep = 1;
            dataTable.Columns["STT"].AutoIncrement = true;
            dataTable.Columns["STT"].AutoIncrementSeed = 1;

            foreach (var item in list)
            {
                dataTable.Rows.Add(null, item.Name, item.Seats, item.RoomId);
            }
            gridControl.DataSource = dataTable;
            gridView.Columns["Id"].Visible = false;
            gridView.Columns["STT"].Width = 40;
            gridView.Columns["STT"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["STT"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }
        void XepLichThi()
        {
            if(listCreditClass.Count == 0)
            {
                MessageBox.Show("Không thể xếp lịch thi vì danh sách lớp rỗng!");
                return;
            }
            TestSchedule testSchedule = new TestSchedule();
            testSchedule.Semester = hocKy;
            testSchedule.SchoolYear = namHoc;
            testSchedule.StartDay = startDay;
            testSchedule.EndDay = endDay;
            listTest = new List<TestScheduleDetail>();
            TestScheduleDetail testScheduleDetail;
            int coutStudent = 0;
            Room room;
            List<CreditClass> listCre = new List<CreditClass>();
            listCre = listCreditClass.ToList();
            foreach (CreditClass item in listCreditClass)
            {
                Program.dbContext.Entry(item).Collection(x => x.Students).Load();
                coutStudent = item.Students.Count();
                room = new Room();
                room = ChonPhong(coutStudent);
                if (room != null)
                {
                    testScheduleDetail = new TestScheduleDetail();
                    testScheduleDetail.CreditClass = item;
                    testScheduleDetail.Subject = Program.dbContext.Subject.Find(item.SubjectId);
                    testScheduleDetail.Teacher = Program.dbContext.Teacher.Find(21);
                    testScheduleDetail.Room = room;
                    listRoom.Remove(room);
                    listCre.Remove(item);
                    //Program.dbContext.CreditClass.Find(item.CreditClassId).IsActive = false;
                    //Program.dbContext.SaveChanges();
                }
            }
            if(listCre.Count > 0)
            {
                CreditClassGroup creditClass1, creditClass2;
                int chia2 = 0;
                foreach(CreditClass item in listCre)
                {
                    chia2 = item.Students.Count / 2;
                    creditClass1 = new CreditClassGroup();
                    for(int i = 0; i< chia2; i++)
                    {
                        creditClass1.Students.Add(item.Students.ElementAt(i));
                    }
                    creditClass2 = new CreditClassGroup();
                    for (int i = chia2; i < item.Students.Count(); i++)
                    {
                        creditClass2.Students.Add(item.Students.ElementAt(i));
                    }
                    item.CreditClassGroups.Add(creditClass1); // thêm cái list khác để remove xong add
                    item.CreditClassGroups.Add(creditClass2);
                }
            }
            
            testSchedule.TestScheduleDetails = listTest;
            //Program.dbContext.TestSchedule.Add(testSchedule);
            //Program.dbContext.SaveChanges();
        }

        private void BtnXepLichThi_Click(object sender, EventArgs e)
        {
            XepLichThi();
        }

        Room ChonPhong(int coutSt)
        {
            Room room = new Room();
            List<Room> list = new List<Room>();
            foreach(Room item in listRoom)
            {
                if(item.Seats >= coutSt)
                {
                    list.Add(item);
                }
            }
            if (list == null) return null;
            int minSeat = 1000;
            foreach(Room item in list)
            {
                if(item.Seats < minSeat)
                {
                    minSeat = item.Seats;
                    room = item;
                }
            }
            if (room != null) return room;
            return null;
        }
    }
}