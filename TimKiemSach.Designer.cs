namespace QLSDT
{
    partial class TimKiemSach
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
			this.dgvSach = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.txtND = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rdMaSach = new System.Windows.Forms.RadioButton();
			this.rdTenSach = new System.Windows.Forms.RadioButton();
			this.rdNamXB = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSach
			// 
			this.dgvSach.AllowUserToAddRows = false;
			this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSach.Location = new System.Drawing.Point(12, 226);
			this.dgvSach.Name = "dgvSach";
			this.dgvSach.ReadOnly = true;
			this.dgvSach.RowHeadersWidth = 51;
			this.dgvSach.RowTemplate.Height = 24;
			this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSach.Size = new System.Drawing.Size(1003, 232);
			this.dgvSach.TabIndex = 25;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(880, 475);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 37);
			this.button1.TabIndex = 61;
			this.button1.Text = "Quay Lại";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(740, 156);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(144, 33);
			this.btnTim.TabIndex = 57;
			this.btnTim.Text = "Tìm kiếm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// txtND
			// 
			this.txtND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtND.Location = new System.Drawing.Point(455, 159);
			this.txtND.Name = "txtND";
			this.txtND.Size = new System.Drawing.Size(254, 30);
			this.txtND.TabIndex = 56;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(189, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 29);
			this.label2.TabIndex = 55;
			this.label2.Text = "Nội dung tìm kiếm";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(18, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(383, 29);
			this.label1.TabIndex = 62;
			this.label1.Text = "Mời Chọn Tìm Kiếm Sách Theo:";
			// 
			// rdMaSach
			// 
			this.rdMaSach.AutoSize = true;
			this.rdMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdMaSach.Location = new System.Drawing.Point(250, 101);
			this.rdMaSach.Name = "rdMaSach";
			this.rdMaSach.Size = new System.Drawing.Size(130, 33);
			this.rdMaSach.TabIndex = 63;
			this.rdMaSach.TabStop = true;
			this.rdMaSach.Text = "Mã sách";
			this.rdMaSach.UseVisualStyleBackColor = true;
			// 
			// rdTenSach
			// 
			this.rdTenSach.AutoSize = true;
			this.rdTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdTenSach.Location = new System.Drawing.Point(440, 101);
			this.rdTenSach.Name = "rdTenSach";
			this.rdTenSach.Size = new System.Drawing.Size(141, 33);
			this.rdTenSach.TabIndex = 64;
			this.rdTenSach.TabStop = true;
			this.rdTenSach.Text = "Tên sách";
			this.rdTenSach.UseVisualStyleBackColor = true;
			// 
			// rdNamXB
			// 
			this.rdNamXB.AutoSize = true;
			this.rdNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNamXB.Location = new System.Drawing.Point(618, 101);
			this.rdNamXB.Name = "rdNamXB";
			this.rdNamXB.Size = new System.Drawing.Size(192, 33);
			this.rdNamXB.TabIndex = 65;
			this.rdNamXB.TabStop = true;
			this.rdNamXB.Text = "Năm xuất bản";
			this.rdNamXB.UseVisualStyleBackColor = true;
			// 
			// TimKiemSach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 528);
			this.Controls.Add(this.rdNamXB);
			this.Controls.Add(this.rdTenSach);
			this.Controls.Add(this.rdMaSach);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtND);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvSach);
			this.Name = "TimKiemSach";
			this.Text = "TimKiemSach";
			((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdMaSach;
		private System.Windows.Forms.RadioButton rdTenSach;
		private System.Windows.Forms.RadioButton rdNamXB;
	}
}