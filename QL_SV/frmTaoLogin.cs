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
    public partial class frmTaoLogin : Form
    {
        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false; // tắt ràng buộc khóa ngoại
            this.GIANGVIEN1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIANGVIEN1TableAdapter.Fill(this.DS.GIANGVIEN1);

            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN"; // hiện lên
            cmbKhoa.ValueMember = "TENSERVER"; //
            cmbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;// bật tắt theo phân quyền
                cmbRoles.Items.RemoveAt(3);
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            if (Program.mGroup == "KHOA")
            {
                cmbRoles.SelectedIndex = 1;
                cmbRoles.Enabled = false;
            }
            if (Program.mGroup == "PKETOAN")
            {
                cmbRoles.SelectedIndex = 3;
                cmbRoles.Enabled = false;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return; // Hệ thống chưa chọn đã chạy => Kết thúc
                Program.servername = cmbKhoa.SelectedValue.ToString();
                //if (Program.mGroup == "PGV" && cmbKhoa.SelectedIndex == 1)
                //{
                //    MessageBox.Show("Bạn không có quyền truy cập cái này", "", MessageBoxButtons.OK);
                //    cmbKhoa.SelectedIndex = 1;
                //    cmbKhoa.SelectedIndex = 0;
                //    return;
                //}
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
                    this.GIANGVIEN1TableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GIANGVIEN1TableAdapter.Fill(this.DS.GIANGVIEN1);
                    cmbMaGV.DataSource = bdsGV1;  // sao chép bds_dspm đã load ở form đăng nhập  qua
                    cmbMaGV.DisplayMember = "TEN";
                    cmbMaGV.ValueMember = "MAGV";

                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoLogin_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Tên đăng nhập or mật khẩu bị trống");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TaoTaiKhoan"))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@LGNAME", SqlDbType.VarChar, 50).Value = txtTenDangNhap.Text;
                    cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 50).Value = txtMatKhau.Text;
                    cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 50).Value = cmbMaGV.Text.ToString();
                    cmd.Parameters.Add("@ROLE", SqlDbType.VarChar, 50).Value = cmbRoles.Text;
                    MessageBox.Show("tenDN : " + txtTenDangNhap.Text + " matkhau: " + txtMatKhau.Text + " magv: " + cmbMaGV.Text.ToString() + " role: " + cmbRoles.Text);

                    SqlParameter prmt = new SqlParameter();
                    prmt = cmd.Parameters.Add("RETURN_VALUE", SqlDbType.Int);
                    prmt.Direction = ParameterDirection.ReturnValue;

                    try
                    {
                        MessageBox.Show(" Tạo tài khoản mới thành công !");
                        txtTenDangNhap.Text = "";
                        txtMatKhau.Text = "";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        int check = (int)cmd.Parameters["return_value"].Value;
                        if (check == 1)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại\n\n " + ex.Message);
                        }
                        if (check == 2)
                        {
                            MessageBox.Show("Mã giảng viên đã tồn tại\n\n " + ex.Message);
                        }
                        con.Close();
                    }
                    con.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaGV.SelectedValue != null)
            {
                txtTenGV.Text = cmbMaGV.SelectedValue.ToString();
            }
        }
    }
}