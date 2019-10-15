using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QuanLyXepLichThi
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formLogin.Close();
        }

        void ShowForm(Form form)
        {
            form.Visible = true;
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Focus();
        }

        private void BtnXepLichThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.formXepLichThi == null)
            {
                Program.formXepLichThi = new FormXepLichThi();
            }
            ShowForm(Program.formXepLichThi);
        }

        private void BtnDSMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.formMon == null)
            {
                Program.formMon = new SubjectForm();
            }
            ShowForm(Program.formMon);
        }

        private void BtnDSLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.formLop == null)
            {
                Program.formLop = new ClassForm();
            }
            ShowForm(Program.formLop);
        }

        private void BtnDSPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.formPhong == null)
            {
                Program.formPhong = new RoomForm();
            }
            ShowForm(Program.formPhong);
        }

        private void BtnDSGiangVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.formGiangVien == null)
            {
                Program.formGiangVien = new TeacherForm();
            }
            ShowForm(Program.formGiangVien);
        }

        private void BtnDSLopTinChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.formLopTinChi == null)
            {
                Program.formLopTinChi = new CreditClassForm();
            }
            ShowForm(Program.formLopTinChi);
        }
    }
}