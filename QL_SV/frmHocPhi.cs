namespace QL_SV
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class frmHocPhi : Form
    {
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            btnGhi.Enabled = false;
            btnTaiLai.Enabled = false;
            
        }

        private void btnBatDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetInfoSV"))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MASV", SqlDbType.Char, 12).Value = txtMaSV.Text;

                    SqlParameter prmt = new SqlParameter();
                    prmt = cmd.Parameters.Add("RETURN_VALUE", SqlDbType.Int);
                    prmt.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    int check = (int)cmd.Parameters["return_value"].Value;
                    if (check == 1)
                    {
                        MessageBox.Show("Sinh viên đã nhập không tồn tại !! \n Hoặc Sinh viên đó đã nghỉ học !! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    con.Close();
                }
            }

            string strLenh = "EXEC sp_GetInfoSV '" + txtMaSV.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            txtHoTen.Text = Program.myReader.GetString(0);
            txtMaLop.Text = Program.myReader.GetString(1);
            Program.myReader.Close();

            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetInfoHpSv"))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MASV", SqlDbType.Char, 12).Value = txtMaSV.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TableHP");
                    con.Close();
                    dataGridView1.AutoGenerateColumns = true; // hiển thị các cột tương ứng với các trường dữ liệu có sẵn
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "TableHP";
                    dataGridView1.Columns[0].HeaderText = "Niên khóa";
                    dataGridView1.Columns[1].HeaderText = "Học kỳ";
                    dataGridView1.Columns[2].HeaderText = "Học phí";
                    dataGridView1.Columns[2].DefaultCellStyle.Format = "#,####0";
                    dataGridView1.Columns[3].HeaderText = "Số tiền đã đóng";
                    dataGridView1.Columns[3].DefaultCellStyle.Format = "#,####0";


                }
            }
            txtMaSV.Enabled = false;
            btnGhi.Enabled = true;
            btnTaiLai.Enabled = true;
            btnBatDau.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtHoTen.Text = "";
            txtMaLop.Text = "";
            txtMaSV.Text = "";
            txtMaSV.Enabled = true;
            btnBatDau.Enabled = true;
            btnGhi.Enabled = false;
            btnTaiLai.Enabled = false;
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOCPHI where masv='000'", con);
                da.InsertCommand = new SqlCommand("sp_InsertValueHP", con);
                da.InsertCommand.CommandType = CommandType.StoredProcedure;

                da.InsertCommand.Parameters.Add("@MASV", SqlDbType.Char, 12, "masv");
                da.InsertCommand.Parameters.Add("@NIENKHOA", SqlDbType.NVarChar, 50, "nienkhoa");
                da.InsertCommand.Parameters.Add("@HOCKY", SqlDbType.Int, 10, "hocky");
                da.InsertCommand.Parameters.Add("@HOCPHI", SqlDbType.Int, 20, "hocphi");
                da.InsertCommand.Parameters.Add("@SOTIENDADONG", SqlDbType.Int, 20, "SOTIENDADONG");

                DataSet ds = new DataSet();
                da.Fill(ds, "BANGHP");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.EndEdit();
                    DataRow newRow = ds.Tables["BANGHP"].NewRow();
                    newRow["masv"] = txtMaSV.Text;
                    if (IsSchoolYearFormat(dataGridView1.Rows[i].Cells[0].Value.ToString()) == false)
                    {
                        MessageBox.Show("- Kiểm tra lại niên khóa vừa nhập !!! \n - Ví dụ đúng : 2010-2014 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        newRow["nienkhoa"] = dataGridView1.Rows[i].Cells[0].Value;
                    }
                    newRow["hocky"] = dataGridView1.Rows[i].Cells[1].Value;
                    int hocphi = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    if(hocphi < 0 || hocphi > 8000000)
                    {                     
                        MessageBox.Show("Học phí từ 0 VND đến 8.000.000 VND !! Vui lòng kiểm tra lại ");
                        return;
                    }
                    else
                    {
                        newRow["hocphi"] = dataGridView1.Rows[i].Cells[2].Value;
                    }
                    int sotiendadong = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    if(sotiendadong == hocphi || sotiendadong == 0)
                    {
                         newRow["SOTIENDADONG"] = dataGridView1.Rows[i].Cells[3].Value;
                        
                    }
                    else
                    {
                        MessageBox.Show("Số tiền đã đóng phải bằng học phí hoặc bằng 0 VNĐ !! Vui lòng kiểm tra lại ");
                        return;
                    }
                    ds.Tables["BANGHP"].Rows.Add(newRow);
                }

                da.Update(ds, "BANGHP");
                //xóa table dataGridView1 
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                con.Close();
            }
            btnGhi.Enabled = false;
            btnBatDau.Enabled = true;
            groupBox1.Enabled = true;
            txtHoTen.Text = "";
            txtMaLop.Text = "";
            txtMaSV.Text = "";
            txtMaSV.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("- Dữ liệu nhập vào bị lỗi vui lòng kiểm tra lại !! \n" + "- " + e.Context.ToString());
        }
        private bool IsSchoolYearFormat(string schoolYear)
        {
            String[] splitWord = schoolYear.Trim().Split('-');
            int yearOne, yearTwo;
            if(splitWord.Length != 2) // kiểm tra định dạng phải là (2010-2014)
            {
                return false; 
            }
            if(!int.TryParse(splitWord[0],out yearOne)) // kiểm tra năm đầu phải là số, gán yearOne = năm đầu
            {
                return false;
            }
            if (!int.TryParse(splitWord[1], out yearTwo)) // kiểm tra năm hai phải là số, gán yearTwo = năm sau
            {
                return false;
            }
            return yearTwo - 4 == yearOne && yearTwo > 1900 && yearOne > 1900 && yearTwo > yearOne; // Kiểm tra 1 sinh viên học tối đa 4 năm , năm sau phải lớn hơn năm đầu
        }
    }
}
