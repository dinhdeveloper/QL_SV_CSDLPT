using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SV
{
    public partial class frmSinhVien : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;
        int vitri = 0;
        public frmSinhVien()
        {
            InitializeComponent();
            dataGridView1.Controls.Add(dtp);
            dtp.Visible=false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
            dtp.TextChanged += new EventHandler(dtp_TextChange);

        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false; // tắt ràng buộc khóa ngoại
            reloadLopAndSV();
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
                btnPhucHoi.Enabled = dataGridView1.Enabled = btnGhi.Enabled = groupBox1.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnTaiLai.Enabled = groupBox1.Enabled = dataGridView1.Enabled = false;
            }
            bdsSINHVIEN.Filter = string.Format("MALOP LIKE '" + cmbMaLop.SelectedValue.ToString() + "'"); // Lọc sinh viên với mã lớp       
            txtMaLop.Text = cmbMaLop.SelectedValue.ToString();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return; // Hệ thống chưa chọn đã chạy => Kết thúc
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
                    reloadLopAndSV(); // tải mới lại Lớp và sinh viên
                    cmbMaLop.DataSource = bdsLOP;  // sao chép bds_dspm đã load ở form đăng nhập  qua
                    cmbMaLop.DisplayMember = "TENLOP";
                    cmbMaLop.ValueMember = "MALOP";
                }
            }
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaLop.SelectedValue != null)
            {
                bdsSINHVIEN.Filter = string.Format("MALOP LIKE '" + cmbMaLop.SelectedValue.ToString() + "'");
                txtMaLop.Text = cmbMaLop.SelectedValue.ToString();
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dataGridView1.Enabled = true;
            btnHieuChinh.Enabled = btnXoa.Enabled = btnThem.Enabled = cmbKhoa.Enabled = cmbMaLop.Enabled = false;
            txtMaLop.Text = cmbMaLop.SelectedValue.ToString();
            dataGridView1.Rows[0].Cells[3].Value = "false";
            dataGridView1.Rows[0].Cells[8].Value = "false";
            dataGridView1.Rows[0].Cells[7].Value = "";
            dataGridView1.Rows[0].Cells[4].Value = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SINHVIEN where masv='000'", con);
                da.InsertCommand = new SqlCommand("sp_InsertSv", con);
                da.InsertCommand.CommandType = CommandType.StoredProcedure;

                da.InsertCommand.Parameters.Add("@MASV", SqlDbType.Char, 12, "masv");
                da.InsertCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 40, "ho");
                da.InsertCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 10, "ten");
                da.InsertCommand.Parameters.Add("@MALOP", SqlDbType.Char, 8, "malop");
                da.InsertCommand.Parameters.Add("@PHAI", SqlDbType.Bit, 10, "phai");
                da.InsertCommand.Parameters.Add("@NGAYSINH", SqlDbType.DateTime, 10, "ngaysinh");
                da.InsertCommand.Parameters.Add("@NOISINH", SqlDbType.NVarChar, 40, "noisinh");
                da.InsertCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 80, "diachi");
                da.InsertCommand.Parameters.Add("@GHICHU", SqlDbType.NText, 8, "ghichu");
                da.InsertCommand.Parameters.Add("@NGHIHOC", SqlDbType.Bit, 10, "nghihoc");
                DataSet ds = new DataSet();
                da.Fill(ds, "BANGSV");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.EndEdit();
                    DataRow newRow = ds.Tables["BANGSV"].NewRow();
                    newRow["masv"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (IsWordsOnly(dataGridView1.Rows[i].Cells[1].Value.ToString()) == false || IsWordsOnly(dataGridView1.Rows[i].Cells[2].Value.ToString()) == false)
                    {
                        MessageBox.Show("Họ và Tên chỉ có thể nhập chữ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        newRow["ho"] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        newRow["ten"] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    }

                    newRow["phai"] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    try
                    {
                        String ngaySinh = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        ngaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");
                        newRow["ngaysinh"] = ngaySinh;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("- Ngày sinh không hợp lệ - Ví dụ hợp lệ : 15/08/1997 \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (IsWordsOnly(dataGridView1.Rows[i].Cells[5].Value.ToString()) == false )
                    {
                        MessageBox.Show("Nơi sinh chỉ có thể nhập chữ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        newRow["noisinh"] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    }
                    newRow["diachi"] = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    newRow["ghichu"] = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    newRow["nghihoc"] = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    newRow["malop"] = txtMaLop.Text;
                    ds.Tables["BANGSV"].Rows.Add(newRow);
                }
                da.Update(ds, "BANGSV");
                //xóa table dataGridView1 
                dataGridView1.Rows.Clear();
                con.Close();
                reloadLopAndSV(); // tải mới lại Lớp và sinh viên
            }
            dataGridView1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = cmbKhoa.Enabled = btnHieuChinh.Enabled = cmbKhoa.Enabled = cmbMaLop.Enabled = true;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSINHVIEN.Position;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = cmbKhoa.Enabled = cmbMaLop.Enabled = false;
            groupBox1.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsWordsOnly(txtNoiSinh.Text.ToString()) == false)
            {
                MessageBox.Show("Nơi sinh chỉ có thể nhập chữ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (IsWordsOnly(txtHo.Text.ToString()) == false|| IsWordsOnly(txtTen.Text.ToString()) == false)
            {
                MessageBox.Show("Họ và Tên chỉ có thể nhập chữ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                bdsSINHVIEN.EndEdit();
                bdsSINHVIEN.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                cmbKhoa.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = cmbMaLop.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dataGridView1.Enabled = false;
            dataGridView1.Rows.Clear();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = cmbKhoa.Enabled = btnHieuChinh.Enabled = cmbKhoa.Enabled = cmbMaLop.Enabled = true;

            try
            {
                reloadLopAndSV(); // tải mới lại Lớp và sinh viên
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String masv = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?? ", "Xác nhận",
                     MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MASV"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MASV", masv);
                    bdsSINHVIEN.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.DS.LOP);
                    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MASV", bdsSINHVIEN);
                    return;
                }
            }

            if (bdsSINHVIEN.Count == 0) btnXoa.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            MessageBox.Show(rowindex.ToString());

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //Khi user thêm 1 dòng mới tự động set giá trị mặc định cho cột giới tính, nghỉ học, ghi chú
            int i = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[i].Cells[3].Value = "false";
            dataGridView1.Rows[i].Cells[8].Value = "false";
            dataGridView1.Rows[i].Cells[7].Value = " ";
            dataGridView1.Rows[i].Cells[4].Value = DateTime.Now.ToString("dd/MM/yyyy");
           
        }

        private void xóaDòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(rowindex);

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSINHVIEN.CancelEdit();
            if (btnThem.Enabled == false) bdsSINHVIEN.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }
        private void reloadLopAndSV()
        {
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            this.lOPTableAdapter.Fill(this.DS.LOP);
        }
        bool IsWordsOnly(string str)
        {
            str = str.ToLower();
            foreach (char c in str)
            {
                if (c < 'a' || c > 'z')
                    return false;
            }

            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Column5":
                    _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y);
                    dtp.MaxDate = DateTime.Now;
                    dtp.Visible = true;
                    dtp.Value = DateTime.ParseExact(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), "dd/MM/yyyy", CultureInfo.InstalledUICulture);
                    break;
            }
        }
        private void dtp_TextChange(object sender , EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text.ToString();
            
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
           dtp.Visible = false;
        }
    }
}
