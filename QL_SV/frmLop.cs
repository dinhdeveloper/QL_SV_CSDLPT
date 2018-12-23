using DevExpress.Utils.OAuth.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SV
{
    public partial class frmLop : Form
    {
        int vitri = 0;
        String maKhoa = "";
        bool kt;
        public frmLop()
        {

            InitializeComponent();
            groupBox1.Enabled = false;
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false; // tắt ràng buộc khóa ngoại
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN); //gọi danh sách lớp vào trong table
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            maKhoa = ((DataRowView)bdsLop[0])["MAKH"].ToString();//set  mặc định txtMaKhoa
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                btnTaiLai.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = false;

            }
            if(Program.mGroup == "KHOA"|| Program.mGroup == "USER")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnHieuChinh.Enabled = false;
                btnGhi.Enabled = false;
            }

           
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue!= null)
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
                    maKhoa = ((DataRowView)bdsLop[0])["MAKH"].ToString();
                }
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position; //lấy vị trí lớp
            groupBox1.Enabled = true;
            bdsLop.AddNew(); //thêm mới 1 hàng vào danh sách
            txtMaLop.Focus();
            txtMaKhoa.Text = maKhoa;
            kt = false; 
            cmbKhoa.Enabled = false; 
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled =btnTaiLai.Enabled =false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            groupBox1.Enabled = true;       
            cmbKhoa.Enabled = false;
            kt = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           String malop = "";
            //if (bdsSV.Count > 0)
            //{
            //    MessageBox.Show("K hông thể xóa lớp này vì đã có sinh viên", "",
            //           MessageBoxButtons.OK);
            //    return;
            //}
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    MessageBox.Show(bdsLop.Position+" ");
                    bdsLop.RemoveCurrent(); //xóa đi hàng hiện tại ra khỏi dataSet
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;       
                    this.lOPTableAdapter.Update(this.DS.LOP);            

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lớp đã có sinh viên không thể xóa \n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.DS.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }
            }

            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnThem.Enabled == false) bdsLop.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            
            if (kt == false) // Dùng để kiểm tra button "Thêm"
            {
                using (SqlConnection con = new SqlConnection(Program.connstr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_KiemTraMaLopTonTai"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text);
                        con.Open();
                        int success = (int)cmd.ExecuteScalar();
                        if (success == 1)
                        {
                            MessageBox.Show("Mã lớp bị trùng");
                            return;
                        }
                        con.Close();
                    }
                }
            }
            

            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);
                cmbKhoa.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.DS.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            
        }
    }
}
