using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SV
{
    public partial class frmDangNhap : Form
    {
        public static bool ktDN = false;
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qL_SVDataSet.V_DS_PHANMANH);
        
            cbbTenKhoa.SelectedIndex = 1;
            cbbTenKhoa.SelectedIndex = 0;
        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenKhoa.SelectedValue != null)
            {
                Program.servername = cbbTenKhoa.SelectedValue.ToString();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text.Trim() == "" || txtPassword.Text.Trim()=="")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu trống","Lỗi đăng nhập",MessageBoxButtons.OK);
                txtLoginName.Focus();
                return ;
            }
            Program.mlogin = txtLoginName.Text;
            Program.password = txtPassword.Text;
            if (Program.KetNoi() == 0) return;
            Program.mKhoa = cbbTenKhoa.SelectedIndex;
            Program.bds_dspm = bdsDSPhanManh;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.mKhoa = cbbTenKhoa.SelectedIndex; 
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MAGV.Text =" Mã giảng viên : " +  Program.username;
            Program.frmChinh.HOTEN.Text =" Họ tên : " + Program.mHoten;
            Program.frmChinh.NHOM.Text = " Nhóm : " + Program.mGroup;
            MessageBox.Show(" Xin chào " + Program.mHoten);         
            Program.frmChinh.enableButton();//set hiện các btn : điêm, Lop, MonHOc
            if (Program.mGroup == "USER")
            {
                Program.frmChinh.btnHocPhi.Enabled = false;
                Program.frmChinh.btnTaoLogin.Enabled = false; // không cho user tạo login
            }
            if (Program.mGroup == "PKETOAN")
            {
                Program.frmChinh.unEnableButton();// Không cho phòng kế toán làm việc với lớp, điểm,...
                Program.frmChinh.btnHocPhi.Enabled = true;
                Program.frmChinh.btnInDSDongHP.Enabled = true;
            }
            this.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void btnDontClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĐÃ NÓI KHÔNG ĐƯỢC CLICK MÀ !!!!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            txtLoginName.Text = "HUY_CNTT";
            txtPassword.Text = "123";
            btnDangNhap_Click(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("ĐÃ NÓI KHÔNG ĐƯỢC CLICK MÀ !!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cbbTenKhoa.SelectedIndex = 1;
            txtLoginName.Text = "A_HP";
            txtPassword.Text = "123";
            btnDangNhap_Click(sender, e);
        }
    }
}
