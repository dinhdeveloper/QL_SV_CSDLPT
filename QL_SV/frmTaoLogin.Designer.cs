namespace QL_SV
{
    partial class frmTaoLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoLogin = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.bdsGV1 = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QL_SV.DS();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bdsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.GIANGVIENTableAdapter = new QL_SV.DSTableAdapters.GIANGVIENTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.dSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GIANGVIEN1TableAdapter = new QL_SV.DSTableAdapters.GIANGVIEN1TableAdapter();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTenGV);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTaoLogin);
            this.panel1.Controls.Add(this.cmbRoles);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbMaGV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(330, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 339);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QL_SV.Properties.Resources.Exit_24_icon;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(561, 287);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 35);
            this.btnThoat.TabIndex = 48;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTaoLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoLogin.Image = global::QL_SV.Properties.Resources.Button_Add_24_icon;
            this.btnTaoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoLogin.Location = new System.Drawing.Point(439, 287);
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.Size = new System.Drawing.Size(85, 35);
            this.btnTaoLogin.TabIndex = 47;
            this.btnTaoLogin.Text = "Tạo login";
            this.btnTaoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoLogin.UseVisualStyleBackColor = true;
            this.btnTaoLogin.Click += new System.EventHandler(this.btnTaoLogin_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Items.AddRange(new object[] {
            "PGV",
            "KHOA",
            "USER",
            "PKETOAN"});
            this.cmbRoles.Location = new System.Drawing.Point(287, 231);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(260, 27);
            this.cmbRoles.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nhóm quyền";
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.DataSource = this.bdsGV1;
            this.cmbMaGV.DisplayMember = "MAGV";
            this.cmbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaGV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(287, 181);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(260, 27);
            this.cmbMaGV.TabIndex = 44;
            this.cmbMaGV.ValueMember = "TEN";
            this.cmbMaGV.SelectedIndexChanged += new System.EventHandler(this.cmbMaGV_SelectedIndexChanged);
            // 
            // bdsGV1
            // 
            this.bdsGV1.DataMember = "GIANGVIEN1";
            this.bdsGV1.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mã giảng viên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(287, 131);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(260, 27);
            this.txtMatKhau.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(287, 81);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(260, 27);
            this.txtTenDangNhap.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên đăng nhập";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownHeight = 123;
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.DropDownWidth = 123;
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.IntegralHeight = false;
            this.cmbKhoa.Location = new System.Drawing.Point(287, 29);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(260, 29);
            this.cmbKhoa.TabIndex = 2;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Khoa";
            // 
            // bdsGiangVien
            // 
            this.bdsGiangVien.DataMember = "GIANGVIEN";
            this.bdsGiangVien.DataSource = this.DS;
            // 
            // GIANGVIENTableAdapter
            // 
            this.GIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(406, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(521, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "TẠO TÀI KHOẢN ĐĂNG NHẬP";
            // 
            // dSBindingSource
            // 
            this.dSBindingSource.DataSource = this.DS;
            this.dSBindingSource.Position = 0;
            // 
            // GIANGVIEN1TableAdapter
            // 
            this.GIANGVIEN1TableAdapter.ClearBeforeFill = true;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.Location = new System.Drawing.Point(561, 182);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(108, 27);
            this.txtTenGV.TabIndex = 49;
            // 
            // frmTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaoLogin";
            this.Text = "Tạo login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoLogin;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsGiangVien;
        private DSTableAdapters.GIANGVIENTableAdapter GIANGVIENTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource dSBindingSource;
        private System.Windows.Forms.BindingSource bdsGV1;
        private DSTableAdapters.GIANGVIEN1TableAdapter GIANGVIEN1TableAdapter;
        private System.Windows.Forms.TextBox txtTenGV;
    }
}