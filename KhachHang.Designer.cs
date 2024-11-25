namespace QLSDT
{
    partial class KhachHang
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
			this.dgvKhachHang = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.lblDienThoai = new System.Windows.Forms.Label();
			this.lblMaKH = new System.Windows.Forms.Label();
			this.lblTenKhach = new System.Windows.Forms.Label();
			this.lblDiaChi = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.qLSDTDataSet = new QLSDT.QLSDTDataSet();
			this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.khachHangTableAdapter = new QLSDT.QLSDTDataSetTableAdapters.KhachHangTableAdapter();
			this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.qLSDTDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvKhachHang
			// 
			this.dgvKhachHang.AutoGenerateColumns = false;
			this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachHangDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn});
			this.dgvKhachHang.DataSource = this.khachHangBindingSource;
			this.dgvKhachHang.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dgvKhachHang.Location = new System.Drawing.Point(68, 190);
			this.dgvKhachHang.Name = "dgvKhachHang";
			this.dgvKhachHang.ReadOnly = true;
			this.dgvKhachHang.RowHeadersWidth = 51;
			this.dgvKhachHang.RowTemplate.Height = 24;
			this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKhachHang.Size = new System.Drawing.Size(873, 215);
			this.dgvKhachHang.TabIndex = 22;
			this.dgvKhachHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKhachHang_MouseClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Location = new System.Drawing.Point(67, 415);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(874, 63);
			this.panel2.TabIndex = 21;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(696, 11);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(92, 39);
			this.btnExit.TabIndex = 15;
			this.btnExit.Text = "Đóng";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(265, 11);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(92, 39);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(469, 11);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(92, 39);
			this.btnSua.TabIndex = 13;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(64, 11);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(92, 39);
			this.btnThem.TabIndex = 11;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.mtbDienThoai);
			this.panel1.Controls.Add(this.txtDiaChi);
			this.panel1.Controls.Add(this.txtTenKH);
			this.panel1.Controls.Add(this.txtMaKH);
			this.panel1.Controls.Add(this.lblDienThoai);
			this.panel1.Controls.Add(this.lblMaKH);
			this.panel1.Controls.Add(this.lblTenKhach);
			this.panel1.Controls.Add(this.lblDiaChi);
			this.panel1.Location = new System.Drawing.Point(67, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(874, 143);
			this.panel1.TabIndex = 20;
			// 
			// txtEmail
			// 
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.Location = new System.Drawing.Point(585, 100);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(223, 22);
			this.txtEmail.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(500, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Email";
			// 
			// mtbDienThoai
			// 
			this.mtbDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mtbDienThoai.Location = new System.Drawing.Point(585, 58);
			this.mtbDienThoai.Name = "mtbDienThoai";
			this.mtbDienThoai.Size = new System.Drawing.Size(184, 22);
			this.mtbDienThoai.TabIndex = 9;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDiaChi.Location = new System.Drawing.Point(585, 15);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(223, 22);
			this.txtDiaChi.TabIndex = 8;
			// 
			// txtTenKH
			// 
			this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTenKH.Location = new System.Drawing.Point(149, 63);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(155, 22);
			this.txtTenKH.TabIndex = 7;
			// 
			// txtMaKH
			// 
			this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaKH.Location = new System.Drawing.Point(149, 19);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new System.Drawing.Size(155, 22);
			this.txtMaKH.TabIndex = 5;
			// 
			// lblDienThoai
			// 
			this.lblDienThoai.AutoSize = true;
			this.lblDienThoai.Location = new System.Drawing.Point(500, 60);
			this.lblDienThoai.Name = "lblDienThoai";
			this.lblDienThoai.Size = new System.Drawing.Size(69, 16);
			this.lblDienThoai.TabIndex = 4;
			this.lblDienThoai.Text = "Điện thoại:";
			// 
			// lblMaKH
			// 
			this.lblMaKH.AutoSize = true;
			this.lblMaKH.Location = new System.Drawing.Point(24, 21);
			this.lblMaKH.Name = "lblMaKH";
			this.lblMaKH.Size = new System.Drawing.Size(101, 16);
			this.lblMaKH.TabIndex = 3;
			this.lblMaKH.Text = "Mã khách hàng:";
			// 
			// lblTenKhach
			// 
			this.lblTenKhach.AutoSize = true;
			this.lblTenKhach.Location = new System.Drawing.Point(24, 65);
			this.lblTenKhach.Name = "lblTenKhach";
			this.lblTenKhach.Size = new System.Drawing.Size(106, 16);
			this.lblTenKhach.TabIndex = 2;
			this.lblTenKhach.Text = "Tên khách hàng:";
			// 
			// lblDiaChi
			// 
			this.lblDiaChi.AutoSize = true;
			this.lblDiaChi.Location = new System.Drawing.Point(500, 17);
			this.lblDiaChi.Name = "lblDiaChi";
			this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
			this.lblDiaChi.TabIndex = 1;
			this.lblDiaChi.Text = "Địa chỉ:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(350, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(321, 29);
			this.label1.TabIndex = 19;
			this.label1.Text = "DANH MỤC KHÁCH HÀNG";
			// 
			// qLSDTDataSet
			// 
			this.qLSDTDataSet.DataSetName = "QLSDTDataSet";
			this.qLSDTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// khachHangBindingSource
			// 
			this.khachHangBindingSource.DataMember = "KhachHang";
			this.khachHangBindingSource.DataSource = this.qLSDTDataSet;
			// 
			// khachHangTableAdapter
			// 
			this.khachHangTableAdapter.ClearBeforeFill = true;
			// 
			// maKhachHangDataGridViewTextBoxColumn
			// 
			this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "MaKhachHang";
			this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "MaKhachHang";
			this.maKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
			this.maKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tenKhachHangDataGridViewTextBoxColumn
			// 
			this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
			this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "TenKhachHang";
			this.tenKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// dienThoaiDataGridViewTextBoxColumn
			// 
			this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
			this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "DienThoai";
			this.dienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
			// 
			// diaChiDataGridViewTextBoxColumn
			// 
			this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
			this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
			this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
			// 
			// KhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 491);
			this.Controls.Add(this.dgvKhachHang);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "KhachHang";
			this.Text = "KhachHang";
			this.Load += new System.EventHandler(this.KhachHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.qLSDTDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
		private QLSDTDataSet qLSDTDataSet;
		private System.Windows.Forms.BindingSource khachHangBindingSource;
		private QLSDTDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
	}
}