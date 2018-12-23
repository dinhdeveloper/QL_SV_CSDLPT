namespace QL_SV
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false; // tắt ràng buộc khóa ngoại
            this.dIEMTableAdapter.Fill(this.DS.DIEM);
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
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
            cmbLanThi.SelectedIndex = 0;
            txtTenLop.Text = cmbMaLop.SelectedValue.ToString();
            txtTenMon.Text = cmbMaMon.SelectedValue.ToString();
            btnGhi.Enabled = false;

        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
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
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.DS.LOP);
                    cmbMaLop.DataSource = bdsLOP;  // sao chép bds_dspm đã load ở form đăng nhập  qua
                    cmbMaLop.DisplayMember = "malop";
                    cmbMaLop.ValueMember = "tenlop";
                    clearTextBox();
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaLop.SelectedValue != null)
            {
                txtTenLop.Text = cmbMaLop.SelectedValue.ToString();
            }
        }

        private void cmbMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaMon.SelectedValue != null)
            {
                txtTenMon.Text = cmbMaMon.SelectedValue.ToString();
            }
        }

        public void clearTextBox()
        {
            txtTenLop.Text = "";
            txtTenMon.Text = "";
            cmbLanThi.SelectedIndex = 0;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbKhoa.Enabled = true;
            groupBox1.Enabled = true;
            btnBatDau.Enabled = true;
            btnHieuChinh.Enabled = true;
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            btnGhi.Enabled = false;
        }

        private void btnBatDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbMaLop.Text == "" || cmbMaMon.Text == "" || cmbLanThi.SelectedIndex == -1)
            {
                MessageBox.Show("Mã lớp hoặc mã môn hoặc lần thi bị trống");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetValueDiem"))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MALOP", SqlDbType.Char, 8).Value = cmbMaLop.Text;
                    cmd.Parameters.Add("@MAMH", SqlDbType.Char, 6).Value = cmbMaMon.Text;
                    cmd.Parameters.Add("@LAN", SqlDbType.SmallInt).Value = cmbLanThi.SelectedItem;
                    SqlParameter prmt = new SqlParameter();
                    prmt = cmd.Parameters.Add("RETURN_VALUE", SqlDbType.Int);
                    prmt.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery();
                    int check = (int)cmd.Parameters["return_value"].Value;
                    if (check == 1)
                    {
                        MessageBox.Show("- Lớp không có sinh viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        con.Close();
                        return;
                    }
                    if (check == 2)
                    {
                        MessageBox.Show("- Cần nhập điểm LẦN 1 trước  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        con.Close();
                        return;
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TableDiem");
                    con.Close();

                    dataGridView1.AutoGenerateColumns = true; // hiển thị các cột tương ứng với các trường dữ liệu có sẵn
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "TableDiem";
                    dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[1].HeaderText = "Họ tên";
                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[2].HeaderText = "Điểm";
                }
            }
            btnGhi.Enabled = true;
            btnBatDau.Enabled = groupBox1.Enabled = cmbKhoa.Enabled = btnHieuChinh.Enabled = false;
        }

        //private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (cmbMaLop.Text == "" || cmbMaMon.Text == "" || cmbLanThi.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Mã lớp hoặc mã môn hoặc lần thi bị trống");
        //        return;
        //    }

        //    using (SqlConnection con = new SqlConnection(Program.connstr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("sp_GetValueTableDiem"))
        //        {
        //            cmd.Connection = con;
        //            con.Open();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add("@MALOP", SqlDbType.Char, 8).Value = cmbMaLop.Text;
        //            cmd.Parameters.Add("@MAMH", SqlDbType.Char, 6).Value = cmbMaMon.Text;
        //            cmd.Parameters.Add("@LAN", SqlDbType.SmallInt).Value = cmbLanThi.SelectedItem;
        //            SqlParameter prmt = new SqlParameter();
        //            prmt = cmd.Parameters.Add("RETURN_VALUE", SqlDbType.Int);
        //            prmt.Direction = ParameterDirection.ReturnValue;

        //            cmd.ExecuteNonQuery();
        //            int check = (int)cmd.Parameters["return_value"].Value;
        //            if (check == 1)
        //            {
        //                MessageBox.Show("Lớp không có sinh viên có điểm \n\n ");
        //                con.Close();
        //                return;
        //            }

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataSet ds = new DataSet();
        //            da.Fill(ds, "TableDiem");

        //            con.Close();
        //            dataGridView1.AutoGenerateColumns = true; // hiển thị các cột tương ứng với các trường dữ liệu có sẵn
        //            dataGridView1.DataSource = ds;
        //            dataGridView1.DataMember = "TableDiem";
        //            dataGridView1.Columns[0].HeaderText = "Mã sinh viên - Họ và tên";
        //            dataGridView1.Columns[0].ReadOnly = true;
        //            dataGridView1.Columns[1].HeaderText = "Mã môn học";
        //            dataGridView1.Columns[1].ReadOnly = true;
        //            dataGridView1.Columns[2].HeaderText = "Lần";
        //            dataGridView1.Columns[2].ReadOnly = true;
        //            dataGridView1.Columns[3].HeaderText = "Điểm";
        //        }
        //    }
        //    btnBatDau.Enabled = groupBox1.Enabled = btnHieuChinh.Enabled = cmbKhoa.Enabled = false;
        //    btnGhi.Enabled = true;
        //}
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                using (SqlConnection con = new SqlConnection(Program.connstr))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DIEM where masv='000'", con);
                    da.InsertCommand = new SqlCommand("sp_InsertValueDiem", con);
                    da.InsertCommand.CommandType = CommandType.StoredProcedure;

                    da.InsertCommand.Parameters.Add("@MASV", SqlDbType.Char, 12, "masv");
                    da.InsertCommand.Parameters.Add("@MAMH", SqlDbType.Char, 6, "mamh");
                    da.InsertCommand.Parameters.Add("@LAN", SqlDbType.SmallInt, 1, "lan");
                    da.InsertCommand.Parameters.Add("@DIEM", SqlDbType.Float, 8, "diem");

                    DataSet ds = new DataSet();
                    da.Fill(ds, "BANGDIEM");
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.EndEdit();
                        DataRow newRow = ds.Tables["BANGDIEM"].NewRow();
                        newRow["masv"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        newRow["mamh"] = cmbMaMon.Text;
                        newRow["lan"] = cmbLanThi.SelectedItem;
                        if (IsDigitsOnly(dataGridView1.Rows[i].Cells[2].Value.ToString()) == false)
                        {
                            MessageBox.Show("Điểm chỉ từ 0 đến 10 và chỉ có số !! Vui lòng kiểm tra lại ");
                            return;
                        }
                        float f = float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        if (f >= 0 && f <= 10)
                        {
                            newRow["diem"] = dataGridView1.Rows[i].Cells[2].Value;
                        }
                        else
                        {
                            MessageBox.Show("Điểm chỉ từ 0 đến 10 !! Vui lòng kiểm tra lại ");
                            return;
                        }
                        ds.Tables["BANGDIEM"].Rows.Add(newRow);
                    }
                    da.Update(ds, "BANGDIEM");
                    //xóa table dataGridView1 
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    con.Close();
                }        
            //if (kt == true) // Hiệu chỉnh
            //{
            //    using (SqlConnection con = new SqlConnection(Program.connstr))
            //    {
            //        con.Open();
            //        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DIEM where masv='000'", con);
            //        da.InsertCommand = new SqlCommand("sp_UpdateValueTableDiem", con);
            //        da.InsertCommand.CommandType = CommandType.StoredProcedure;

            //        da.InsertCommand.Parameters.Add("@MASV", SqlDbType.Char, 12, "masv");
            //        da.InsertCommand.Parameters.Add("@MAMH", SqlDbType.Char, 6, "mamh");
            //        da.InsertCommand.Parameters.Add("@LAN", SqlDbType.SmallInt, 1, "lan");
            //        da.InsertCommand.Parameters.Add("@DIEM", SqlDbType.Float, 8, "diem");

            //        DataSet ds = new DataSet();
            //        da.Fill(ds, "BANGDIEM");
            //        for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //        {
            //            dataGridView1.EndEdit();
            //            DataRow newRow = ds.Tables["BANGDIEM"].NewRow();
            //            newRow["masv"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //            newRow["mamh"] = cmbMaMon.Text;
            //            newRow["lan"] = cmbLanThi.SelectedItem;
            //            float f = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            //            if (f>=0 && f<=10)
            //            {
            //                newRow["diem"] = dataGridView1.Rows[i].Cells[3].Value;
            //            }
            //            else
            //            {
            //                MessageBox.Show("Điểm chỉ từ 0 đến 10 !! Vui lòng kiểm tra lại ");
            //                return;
            //            }
            //            ds.Tables["BANGDIEM"].Rows.Add(newRow);
            //        }
            //        da.Update(ds, "BANGDIEM");
            //        //xóa table dataGridView1 
            //        dataGridView1.DataSource = null;
            //        dataGridView1.Columns.Clear();
            //        con.Close();
            //    }
            //}
            btnGhi.Enabled = false;
            btnBatDau.Enabled = groupBox1.Enabled = cmbKhoa.Enabled = btnHieuChinh.Enabled = true;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '.' || c > '9')
                    return false;
            }

            return true;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("- Điểm nhập vào bị lỗi vui lòng kiểm tra lại !! \n" +"- " +e.Context.ToString());     
        }

        private void btnHieChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
