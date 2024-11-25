namespace QLSDT
{
    partial class TimKiemKhach
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
			this.btnTim = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dgvKhachHang = new System.Windows.Forms.DataGridView();
			this.txtND = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rdMaKH = new System.Windows.Forms.RadioButton();
			this.rdTenKH = new System.Windows.Forms.RadioButton();
			this.qLSDTDataSet1 = new QLSDT.QLSDTDataSet1();
			this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.khachHangTableAdapter = new QLSDT.QLSDTDataSet1TableAdapters.KhachHangTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qLSDTDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(704, 174);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(143, 33);
			this.btnTim.TabIndex = 41;
			this.btnTim.Text = "Tìm kiếm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(742, 485);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(143, 39);
			this.btnThoat.TabIndex = 40;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// dgvKhachHang
			// 
			this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhachHang.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dgvKhachHang.Location = new System.Drawing.Point(12, 249);
			this.dgvKhachHang.Name = "dgvKhachHang";
			this.dgvKhachHang.RowHeadersWidth = 51;
			this.dgvKhachHang.RowTemplate.Height = 24;
			this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKhachHang.Size = new System.Drawing.Size(873, 215);
			this.dgvKhachHang.TabIndex = 47;
			// 
			// txtND
			// 
			this.txtND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtND.Location = new System.Drawing.Point(325, 177);
			this.txtND.Name = "txtND";
			this.txtND.Size = new System.Drawing.Size(359, 30);
			this.txtND.TabIndex = 49;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(122, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(183, 25);
			this.label3.TabIndex = 48;
			this.label3.Text = "Nội dung tìm kiếm";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(47, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(465, 29);
			this.label1.TabIndex = 66;
			this.label1.Text = "Mời Chọn Tìm Kiếm Khách Hàng Theo:";
			// 
			// rdMaKH
			// 
			this.rdMaKH.AutoSize = true;
			this.rdMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdMaKH.Location = new System.Drawing.Point(211, 95);
			this.rdMaKH.Name = "rdMaKH";
			this.rdMaKH.Size = new System.Drawing.Size(241, 36);
			this.rdMaKH.TabIndex = 67;
			this.rdMaKH.TabStop = true;
			this.rdMaKH.Text = "Mã khách hàng";
			this.rdMaKH.UseVisualStyleBackColor = true;
			// 
			// rdTenKH
			// 
			this.rdTenKH.AutoSize = true;
			this.rdTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdTenKH.Location = new System.Drawing.Point(483, 95);
			this.rdTenKH.Name = "rdTenKH";
			this.rdTenKH.Size = new System.Drawing.Size(252, 36);
			this.rdTenKH.TabIndex = 68;
			this.rdTenKH.TabStop = true;
			this.rdTenKH.Text = "Tên khách hàng";
			this.rdTenKH.UseVisualStyleBackColor = true;
			// 
			// qLSDTDataSet1
			// 
			this.qLSDTDataSet1.DataSetName = "QLSDTDataSet1";
			this.qLSDTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// khachHangBindingSource
			// 
			this.khachHangBindingSource.DataMember = "KhachHang";
			this.khachHangBindingSource.DataSource = this.qLSDTDataSet1;
			// 
			// khachHangTableAdapter
			// 
			this.khachHangTableAdapter.ClearBeforeFill = true;
			// 
			// TimKiemKhach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(899, 538);
			this.Controls.Add(this.rdTenKH);
			this.Controls.Add(this.rdMaKH);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtND);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvKhachHang);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.btnThoat);
			this.Name = "TimKiemKhach";
			this.Text = "Tìm kiếm khách hàng";
			this.Load += new System.EventHandler(this.TimKiemKhach_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qLSDTDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdMaKH;
		private System.Windows.Forms.RadioButton rdTenKH;
		private QLSDTDataSet1 qLSDTDataSet1;
		private System.Windows.Forms.BindingSource khachHangBindingSource;
		private QLSDTDataSet1TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
	}
}