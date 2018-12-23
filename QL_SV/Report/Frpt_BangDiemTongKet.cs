using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_SV.Report
{
    public partial class Frpt_BangDiemTongKet : Form
    {
        public Frpt_BangDiemTongKet()
        {
            InitializeComponent();
        }

        private void Frpt_BangDiemTongKet_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Xrpt_BangDiemTongKet rpt = new Xrpt_BangDiemTongKet(cmbTenLop.SelectedValue.ToString());
            rpt.lblLOP.Text = cmbTenLop.Text;
            int width=rpt.xrPivotGrid1.ActualWidth; // get width of PivotGrid
            int widthMainPage= width + 230; 
            rpt.PageWidth = widthMainPage; // set width for Main Page
            rpt.xrLine1.WidthF = widthMainPage-200; // set width for Line
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenLop.SelectedValue != null)
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            }
            
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
