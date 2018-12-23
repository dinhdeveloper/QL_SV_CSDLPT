using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_SV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public frmMain()
        {
            InitializeComponent();
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Show();
            unEnableButton();
            btnTaoLogin.Enabled = false;
            btnDangXuat.Enabled = false;

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmDiem f = new frmDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra nếu form nào đang tồn tại thì tắt
            Form frmDN = this.CheckExists(typeof(frmDangNhap));
            Form frmDiem = this.CheckExists(typeof(frmDiem));
            Form frmHocPhi = this.CheckExists(typeof(frmHocPhi));
            Form frmLop = this.CheckExists(typeof(frmLop));
            Form frmMonHoc = this.CheckExists(typeof(frmMonHoc));         
            Form frmSV = this.CheckExists(typeof(frmSinhVien));
            Form frmTaoLogin = this.CheckExists(typeof(frmTaoLogin));
            Form Frpt_BangDiemMonHoc = this.CheckExists(typeof(Report.Frpt_BangDiemMonHoc));
            Form Frpt_BangDiemTongKet = this.CheckExists(typeof(Report.Frpt_BangDiemTongKet));
            Form Frpt_DanhSachDongHP = this.CheckExists(typeof(Report.Frpt_DanhSachDongHP));
            Form Frpt_DsThiHetMon = this.CheckExists(typeof(Report.Frpt_DsThiHetMon));
            Form Frpt_InDanhSachSinhVienLOP = this.CheckExists(typeof(Report.Frpt_InDanhSachSinhVienLOP));
            Form Frpt_PhieuDiemSV = this.CheckExists(typeof(Report.Frpt_PhieuDiemSV));
            if (frmDN != null)
            {
                frmDN.Close();
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
                this.MAGV.Text = "";
                this.HOTEN.Text = "";
                this.NHOM.Text = "";
                unEnableButton();
                btnDangXuat.Enabled = false;
                btnTaoLogin.Enabled = false;
            }
            if (frmDiem != null)
            {
                frmDiem.Close();
            }
            if(frmHocPhi != null)
            {
                frmHocPhi.Close();
            }
            if (frmMonHoc != null)
            {
                frmMonHoc.Close();
            }
            if (frmLop != null)
            {
                frmLop.Close();
            }
            if (frmSV != null)
            {
                frmSV.Close();
            }
            if (frmTaoLogin != null)
            {
                frmTaoLogin.Close();
            }
            if (Frpt_BangDiemMonHoc != null)
            {
                Frpt_BangDiemMonHoc.Close();
            }
            if (Frpt_BangDiemTongKet != null)
            {
                Frpt_BangDiemTongKet.Close();
            }
            if (Frpt_DanhSachDongHP != null)
            {
                Frpt_DanhSachDongHP.Close();
            }
            if (Frpt_DsThiHetMon != null)
            {
                Frpt_DsThiHetMon.Close();
            }
            if (Frpt_InDanhSachSinhVienLOP != null)
            {
                Frpt_InDanhSachSinhVienLOP.Close();
            }
            if (Frpt_PhieuDiemSV != null)
            {
                Frpt_PhieuDiemSV.Close();
            }
        }
        public void unEnableButton()
        {
            btnDiem.Enabled = false;
            btnLop.Enabled = false;
            btnMonHoc.Enabled = false;
            btnSinhVien.Enabled = false;
            btnHocPhi.Enabled = false;
            btnInDSDongHP.Enabled = false;
            btnInBDMonHoc.Enabled = false;
            btnInBDTongKet.Enabled = false;
            btnInDSSV.Enabled = false;
            btnInDSThiHetMon.Enabled = false;
            btnInPhieuDiemSV.Enabled = false;
        }
        private void enableButtonReport()
        {
            btnInBDMonHoc.Enabled = true;
            btnInBDTongKet.Enabled = true;
            btnInDSSV.Enabled = true;
            btnInDSThiHetMon.Enabled = true;
            btnInPhieuDiemSV.Enabled = true;
        }

        private void btnTaoLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoLogin f = new frmTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void Frpt_InDanhSachSinhVienLOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Report.Frpt_InDanhSachSinhVienLOP));
            if (frm != null) frm.Activate();
            else
            {
                Report.Frpt_InDanhSachSinhVienLOP f = new Report.Frpt_InDanhSachSinhVienLOP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Report.Frpt_BangDiemMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                Report.Frpt_BangDiemMonHoc f = new Report.Frpt_BangDiemMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Report.Frpt_DsThiHetMon));
            if (frm != null) frm.Activate();
            else
            {
                Report.Frpt_DsThiHetMon f = new Report.Frpt_DsThiHetMon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void RE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Report.Frpt_PhieuDiemSV));
            if (frm != null) frm.Activate();
            else
            {
                Report.Frpt_PhieuDiemSV f = new Report.Frpt_PhieuDiemSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Report.Frpt_BangDiemTongKet));
            if (frm != null) frm.Activate();
            else
            {
                Report.Frpt_BangDiemTongKet f = new Report.Frpt_BangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Report.Frpt_DanhSachDongHP));
            if (frm != null) frm.Activate();
            else
            {
                Report.Frpt_DanhSachDongHP f = new Report.Frpt_DanhSachDongHP();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
