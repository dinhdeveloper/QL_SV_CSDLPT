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
    public partial class Frpt_DanhSachDongHP : Form
    {
        public Frpt_DanhSachDongHP()
        {
            InitializeComponent();
        }
        private void Frpt_DanhSachDongHP_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
            txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            cmbHocKy.SelectedIndex = 0;
        }
        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenLop.SelectedValue != null)
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String malop  = cmbTenLop.SelectedValue.ToString();
            String nienkhoa = txtNienKhoa.Text;
            int hocky = Int32.Parse(cmbHocKy.SelectedItem.ToString());
            Xrpt_DanhSachDongHP rpt = new Xrpt_DanhSachDongHP(malop,nienkhoa,hocky);
            rpt.lblLOP.Text = cmbTenLop.Text;
            rpt.lblNIENKHOA.Text = nienkhoa;
            rpt.lblHOCKY.Text = cmbHocKy.SelectedItem.ToString();
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
        }
    }
}
