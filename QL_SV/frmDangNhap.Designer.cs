namespace QL_SV
{
    partial class frmDangNhap
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
            System.Windows.Forms.Label tENCNLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SVDataSet = new QL_SV.QL_SVDataSet();
            this.bdsDSPhanManh = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnDontClick = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.v_DS_PHANMANHTableAdapter = new QL_SV.QL_SVDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            tENCNLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPhanManh)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel1
            // 
            tENCNLabel1.AutoSize = true;
            tENCNLabel1.Location = new System.Drawing.Point(123, 86);
            tENCNLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENCNLabel1.Name = "tENCNLabel1";
            tENCNLabel1.Size = new System.Drawing.Size(84, 21);
            tENCNLabel1.TabIndex = 2;
            tENCNLabel1.Text = "Tên Khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtLoginName);
            this.groupBox1.Controls.Add(tENCNLabel1);
            this.groupBox1.Controls.Add(this.cbbTenKhoa);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(272, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(827, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(513, 294);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(158, 39);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(297, 294);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(158, 39);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(271, 225);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(428, 29);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassword_KeyDown);
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(271, 153);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(428, 29);
            this.txtLoginName.TabIndex = 4;
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.DataSource = this.vDSPHANMANHBindingSource;
            this.cbbTenKhoa.DisplayMember = "TENCN";
            this.cbbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(271, 82);
            this.cbbTenKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(428, 29);
            this.cbbTenKhoa.TabIndex = 3;
            this.cbbTenKhoa.TabStop = false;
            this.cbbTenKhoa.ValueMember = "TENSERVER";
            this.cbbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.tENCNComboBox_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.qL_SVDataSet;
            // 
            // qL_SVDataSet
            // 
            this.qL_SVDataSet.DataSetName = "QL_SVDataSet";
            this.qL_SVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSPhanManh
            // 
            this.bdsDSPhanManh.DataMember = "V_DS_PHANMANH";
            this.bdsDSPhanManh.DataSource = this.qL_SVDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(453, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // btnDontClick
            // 
            this.btnDontClick.BackColor = System.Drawing.Color.Yellow;
            this.btnDontClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDontClick.ForeColor = System.Drawing.Color.Red;
            this.btnDontClick.Image = global::QL_SV.Properties.Resources.icons8_Spam_48px;
            this.btnDontClick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDontClick.Location = new System.Drawing.Point(1107, 253);
            this.btnDontClick.Margin = new System.Windows.Forms.Padding(4);
            this.btnDontClick.Name = "btnDontClick";
            this.btnDontClick.Size = new System.Drawing.Size(238, 60);
            this.btnDontClick.TabIndex = 3;
            this.btnDontClick.Text = "DO NOT CLICK";
            this.btnDontClick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDontClick.UseVisualStyleBackColor = false;
            this.btnDontClick.Click += new System.EventHandler(this.btnDontClick_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::QL_SV.Properties.Resources.icons8_Spam_48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1107, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "DO NOT CLICK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1370, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDontClick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPhanManh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDontClick;
        private System.Windows.Forms.Button button1;
        private QL_SVDataSet qL_SVDataSet;
        private System.Windows.Forms.BindingSource bdsDSPhanManh;
        private QL_SVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
    }
}