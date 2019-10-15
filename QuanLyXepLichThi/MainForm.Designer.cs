namespace QuanLyXepLichThi
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnXepLichThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDSLopTinChi = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnXepLichThi,
            this.btnDSMon,
            this.btnDSLop,
            this.btnDSPhong,
            this.btnDSGiangVien,
            this.btnDSLopTinChi});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(757, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnXepLichThi
            // 
            this.btnXepLichThi.Caption = "Xếp lịch thi tự động";
            this.btnXepLichThi.Id = 1;
            this.btnXepLichThi.Name = "btnXepLichThi";
            this.btnXepLichThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnXepLichThi_ItemClick);
            // 
            // btnDSMon
            // 
            this.btnDSMon.Caption = "Danh sách môn";
            this.btnDSMon.Id = 2;
            this.btnDSMon.Name = "btnDSMon";
            this.btnDSMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDSMon_ItemClick);
            // 
            // btnDSLop
            // 
            this.btnDSLop.Caption = "Danh sách lớp";
            this.btnDSLop.Id = 3;
            this.btnDSLop.Name = "btnDSLop";
            this.btnDSLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDSLop_ItemClick);
            // 
            // btnDSPhong
            // 
            this.btnDSPhong.Caption = "Danh sách phòng";
            this.btnDSPhong.Id = 4;
            this.btnDSPhong.Name = "btnDSPhong";
            this.btnDSPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDSPhong_ItemClick);
            // 
            // btnDSGiangVien
            // 
            this.btnDSGiangVien.Caption = "Danh sách giảng viên";
            this.btnDSGiangVien.Id = 5;
            this.btnDSGiangVien.Name = "btnDSGiangVien";
            this.btnDSGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDSGiangVien_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXepLichThi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDSMon);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSLop);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDSPhong);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDSGiangVien);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 408);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(757, 31);
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDSLopTinChi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // btnDSLopTinChi
            // 
            this.btnDSLopTinChi.Caption = "Danh sách lớp tín chỉ";
            this.btnDSLopTinChi.Id = 6;
            this.btnDSLopTinChi.Name = "btnDSLopTinChi";
            this.btnDSLopTinChi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDSLopTinChi_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 439);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnXepLichThi;
        private DevExpress.XtraBars.BarButtonItem btnDSMon;
        private DevExpress.XtraBars.BarButtonItem btnDSLop;
        private DevExpress.XtraBars.BarButtonItem btnDSPhong;
        private DevExpress.XtraBars.BarButtonItem btnDSGiangVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDSLopTinChi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}