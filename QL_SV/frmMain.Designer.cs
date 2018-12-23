namespace QL_SV
{
    partial class frmMain
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
        public void enableButton()
        {
            btnDiem.Enabled = true;
            btnLop.Enabled = true;
            btnMonHoc.Enabled = true;
            btnSinhVien.Enabled = true;
            btnDangXuat.Enabled = true;
            btnTaoLogin.Enabled = true;
            btnInBDMonHoc.Enabled = true;
            btnInBDTongKet.Enabled = true;
            btnInDSSV.Enabled = true;
            btnInDSThiHetMon.Enabled = true;
            btnInPhieuDiemSV.Enabled = true;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnTaoLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBDMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSThiHetMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnInPhieuDiemSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBDTongKet = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSDongHP = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbon});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = global::QL_SV.Properties.Resources.Login_32_icon;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 14;
            this.btnDangXuat.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Shutdown_24px_1;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // ribbon
            // 
            this.ribbon.ItemLinks.Add(this.btnTaoLogin);
            this.ribbon.Name = "ribbon";
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Caption = "Tạo login";
            this.btnTaoLogin.Id = 15;
            this.btnTaoLogin.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Plus_24px_2;
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoLogin_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 4;
            this.btnLop.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_School_40px;
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 9;
            this.btnMonHoc.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Book_40px;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick_1);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh viên";
            this.btnSinhVien.Id = 12;
            this.btnSinhVien.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Student_Male_40px;
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnDiem
            // 
            this.btnDiem.Caption = "Điểm";
            this.btnDiem.Id = 13;
            this.btnDiem.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Graduation_Cap_24px;
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiem_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 11;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.CausesValidation = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.barButtonItem1,
            this.btnLop,
            this.barButtonItem3,
            this.btnMonHoc,
            this.btnSinhVien,
            this.btnDiem,
            this.btnDangXuat,
            this.btnTaoLogin,
            this.btnHocPhi,
            this.btnInDSSV,
            this.btnInBDMonHoc,
            this.btnInDSThiHetMon,
            this.btnInPhieuDiemSV,
            this.btnInBDTongKet,
            this.btnInDSDongHP});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Caption = "Học Phí";
            this.btnHocPhi.Id = 16;
            this.btnHocPhi.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Money_Bag_24px;
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocPhi_ItemClick);
            // 
            // btnInDSSV
            // 
            this.btnInDSSV.Caption = "In danh sách sinh viên";
            this.btnInDSSV.Id = 17;
            this.btnInDSSV.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Student_Male_24px;
            this.btnInDSSV.Name = "btnInDSSV";
            this.btnInDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Frpt_InDanhSachSinhVienLOP_ItemClick);
            // 
            // btnInBDMonHoc
            // 
            this.btnInBDMonHoc.Caption = "In bảng điểm môn học";
            this.btnInBDMonHoc.Id = 18;
            this.btnInBDMonHoc.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Graduation_Cap_25px_2;
            this.btnInBDMonHoc.Name = "btnInBDMonHoc";
            this.btnInBDMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // btnInDSThiHetMon
            // 
            this.btnInDSThiHetMon.Caption = "In danh sách thi hết môn";
            this.btnInDSThiHetMon.Id = 19;
            this.btnInDSThiHetMon.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Report_Card_25px;
            this.btnInDSThiHetMon.Name = "btnInDSThiHetMon";
            this.btnInDSThiHetMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnInPhieuDiemSV
            // 
            this.btnInPhieuDiemSV.Caption = "In phiếu điểm sinh viên";
            this.btnInPhieuDiemSV.Id = 20;
            this.btnInPhieuDiemSV.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Elective_25px;
            this.btnInPhieuDiemSV.Name = "btnInPhieuDiemSV";
            this.btnInPhieuDiemSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RE_ItemClick);
            // 
            // btnInBDTongKet
            // 
            this.btnInBDTongKet.Caption = "In bảng điểm tổng kết";
            this.btnInBDTongKet.Id = 21;
            this.btnInBDTongKet.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Rating_25px;
            this.btnInBDTongKet.Name = "btnInBDTongKet";
            this.btnInBDTongKet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // btnInDSDongHP
            // 
            this.btnInDSDongHP.Caption = "In danh sách đóng học phí";
            this.btnInDSDongHP.Id = 22;
            this.btnInDSDongHP.ImageOptions.Image = global::QL_SV.Properties.Resources.icons8_Money_25px;
            this.btnInDSDongHP.Name = "btnInDSDongHP";
            this.btnInDSDongHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Danh mục";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDiem);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHocPhi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnInDSSV);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnInPhieuDiemSV);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnInDSThiHetMon);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnInDSDongHP);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnInBDMonHoc);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnInBDTongKet);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Report_Group";
            // 
            // MAGV
            // 
            this.MAGV.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(41, 17);
            this.MAGV.Text = "MAGV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(46, 17);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(45, 17);
            this.NHOM.Text = "NHOM";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MAGV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        public DevExpress.XtraBars.BarButtonItem btnLop;
        public DevExpress.XtraBars.BarButtonItem btnMonHoc;
        public DevExpress.XtraBars.BarButtonItem btnSinhVien;
        public DevExpress.XtraBars.BarButtonItem btnDiem;
        public DevExpress.XtraBars.BarButtonItem btnTaoLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        public DevExpress.XtraBars.BarButtonItem btnHocPhi;
        public DevExpress.XtraBars.BarButtonItem btnInDSDongHP;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        public DevExpress.XtraBars.BarButtonItem btnInDSSV;
        public DevExpress.XtraBars.BarButtonItem btnInBDMonHoc;
        public DevExpress.XtraBars.BarButtonItem btnInDSThiHetMon;
        public DevExpress.XtraBars.BarButtonItem btnInPhieuDiemSV;
        public DevExpress.XtraBars.BarButtonItem btnInBDTongKet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon;
    }
}

