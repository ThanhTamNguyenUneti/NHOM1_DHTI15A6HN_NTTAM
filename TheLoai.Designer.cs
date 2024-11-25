namespace QLSDT
{
	partial class TheLoai
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnXoa1 = new System.Windows.Forms.Button();
			this.btnSua1 = new System.Windows.Forms.Button();
			this.btnThem1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtMoTa = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTentL = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaTL = new System.Windows.Forms.TextBox();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.txtMaTL);
			this.panel4.Controls.Add(this.btnExit);
			this.panel4.Controls.Add(this.btnXoa1);
			this.panel4.Controls.Add(this.btnSua1);
			this.panel4.Controls.Add(this.btnThem1);
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Controls.Add(this.txtMoTa);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txtTentL);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(12, 87);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(532, 415);
			this.panel4.TabIndex = 40;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Yellow;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(422, 353);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(93, 40);
			this.btnExit.TabIndex = 39;
			this.btnExit.Text = "Đóng";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnXoa1
			// 
			this.btnXoa1.Location = new System.Drawing.Point(288, 354);
			this.btnXoa1.Name = "btnXoa1";
			this.btnXoa1.Size = new System.Drawing.Size(92, 40);
			this.btnXoa1.TabIndex = 38;
			this.btnXoa1.Text = "Xóa";
			this.btnXoa1.UseVisualStyleBackColor = true;
			this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
			// 
			// btnSua1
			// 
			this.btnSua1.Location = new System.Drawing.Point(149, 354);
			this.btnSua1.Name = "btnSua1";
			this.btnSua1.Size = new System.Drawing.Size(92, 40);
			this.btnSua1.TabIndex = 37;
			this.btnSua1.Text = "Sửa";
			this.btnSua1.UseVisualStyleBackColor = true;
			this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
			// 
			// btnThem1
			// 
			this.btnThem1.Location = new System.Drawing.Point(18, 353);
			this.btnThem1.Name = "btnThem1";
			this.btnThem1.Size = new System.Drawing.Size(92, 40);
			this.btnThem1.TabIndex = 36;
			this.btnThem1.Text = "Thêm";
			this.btnThem1.UseVisualStyleBackColor = true;
			this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.dataGridView1.Location = new System.Drawing.Point(3, 155);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(526, 172);
			this.dataGridView1.TabIndex = 35;
			this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "MaTheLoai";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã thể loại";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "TenTheLoai";
			this.dataGridViewTextBoxColumn2.HeaderText = "Tên thể loại";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "MoTa";
			this.dataGridViewTextBoxColumn3.HeaderText = "Mô tả";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// txtMoTa
			// 
			this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMoTa.Location = new System.Drawing.Point(138, 93);
			this.txtMoTa.Multiline = true;
			this.txtMoTa.Name = "txtMoTa";
			this.txtMoTa.Size = new System.Drawing.Size(377, 56);
			this.txtMoTa.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Mô tả";
			// 
			// txtTentL
			// 
			this.txtTentL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTentL.Location = new System.Drawing.Point(138, 60);
			this.txtTentL.Name = "txtTentL";
			this.txtTentL.Size = new System.Drawing.Size(223, 22);
			this.txtTentL.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Mã thể loại";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Tên thể loại";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(156, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 58);
			this.label1.TabIndex = 41;
			this.label1.Text = "DANH MỤCTHỂ LOẠI\r\n\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtMaTL
			// 
			this.txtMaTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaTL.Location = new System.Drawing.Point(138, 19);
			this.txtMaTL.Name = "txtMaTL";
			this.txtMaTL.ReadOnly = true;
			this.txtMaTL.Size = new System.Drawing.Size(223, 22);
			this.txtMaTL.TabIndex = 40;
			// 
			// TheLoai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 514);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel4);
			this.Name = "TheLoai";
			this.Text = "TheLoai";
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnXoa1;
		private System.Windows.Forms.Button btnSua1;
		private System.Windows.Forms.Button btnThem1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.TextBox txtMoTa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTentL;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaTL;
	}
}