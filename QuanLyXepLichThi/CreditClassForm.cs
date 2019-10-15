using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using QLXLT_Data.Models;

namespace QuanLyXepLichThi
{
    public partial class CreditClassForm : DevExpress.XtraEditors.XtraForm
    {
        public CreditClassForm()
        {
            InitializeComponent();
            ShowData(gridControl1, gridView1, Program.dbContext.CreditClass.ToList());
        }

        public void ShowData(GridControl gridControl, GridView gridView, List<CreditClass> list)
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
            gridView.Columns["STT"].Width = 10;
            gridView.Columns["STT"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["STT"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(0);
            GridView view = sender as GridView;
            DataRow dataRow = view.GetDataRow(e.FocusedRowHandle);
            if (dataRow == null) return;
            int idClass = int.Parse(dataRow.ItemArray[4].ToString());
            CreditClass creditClass = Program.dbContext.CreditClass.Find(idClass);
            Program.dbContext.Entry(creditClass).Collection(x => x.Students).Load();
            List<Student> listStu = creditClass.Students.ToList();
            gridControl2.DataSource = new BindingList<Student>(listStu);
        }
    }
}