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
    }
}