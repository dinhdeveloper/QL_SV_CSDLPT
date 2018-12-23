using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SV.Report
{
    public partial class Frpt_DsThiHetMon : Form
    {
        public Frpt_DsThiHetMon()
        {
            InitializeComponent();
        }

        private void Frpt_PhieuDiemThi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;           
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
            }
            else
            {
                cmbKhoa.Enabled = false;
            }

            txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            txtMaMon.Text = cmbTenMon.SelectedValue.ToString();
            cmbLanThi.SelectedIndex = 0;
            dtpNgayThi.Format = DateTimePickerFormat.Custom;
            dtpNgayThi.CustomFormat = "dd-MM-yyyy";
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenLop.SelectedValue != null)
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            }
        }

        private void cmbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenMon.SelectedValue != null)
            {
                txtMaMon.Text = cmbTenMon.SelectedValue.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String malop = cmbTenLop.SelectedValue.ToString();
            String mamonhoc = cmbTenMon.SelectedValue.ToString();
          
            Xrpt_DsThiHetMon rpt = new Xrpt_DsThiHetMon(malop);
            rpt.lblLop.Text = cmbTenLop.Text;   
            rpt.lblMonHoc.Text = cmbTenMon.Text;
            rpt.lblNgayThi.Text = dtpNgayThi.Text;
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                    return; // Hệ thống chưa chọn đã chạy => Kết thúc
                Program.servername = cmbKhoa.SelectedValue.ToString();
                if (Program.mGroup == "PGV" && cmbKhoa.SelectedIndex == 1)
                {
                    MessageBox.Show("Bạn không có quyền truy cập cái này", "", MessageBoxButtons.OK);
                    cmbKhoa.SelectedIndex = 1;
                    cmbKhoa.SelectedIndex = 0;
                    return;
                }
                if (cmbKhoa.SelectedIndex != Program.mKhoa)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                else
                {
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.DS.LOP);
                    txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
                }
            }
        }
    }
}
