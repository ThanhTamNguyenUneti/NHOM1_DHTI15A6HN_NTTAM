using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSDT
{
	public partial class TheLoai : Form
	{
		KetNoi kn = new KetNoi();
		string laydl = "select * from theloai";
		public TheLoai()
		{
			InitializeComponent();
			dataGridView1.DataSource = kn.readData(laydl);
		}

		private void btnThem1_Click(object sender, EventArgs e)
		{
			string ten_tl = txtTentL.Text;
			string mo_ta = txtMoTa.Text;
			string sql = "insert into theloai(TenTheLoai,MoTa) values(@ten_tl,@mo_ta)";
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@ten_tl", ten_tl));
			parameters.Add(new SqlParameter("@mo_ta", mo_ta));
			kn.createUpdateDelete(sql,parameters);
			dataGridView1.DataSource = kn.readData(laydl);
			MessageBox.Show("Thêm thành công!");
		}

		private void btnSua1_Click(object sender, EventArgs e)
		{
			string ma_tl = txtMaTL.Text;
			string ten_tl = txtTentL.Text;
			string mo_ta = txtMoTa.Text;
			string sql = "update theloai set TenTheLoai=@ten_tl,MoTa=@mo_ta where MaTheLoai=@ma_tl";
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@ma_tl", ma_tl));
			parameters.Add(new SqlParameter("@ten_tl", ten_tl));
			parameters.Add(new SqlParameter("@mo_ta", mo_ta));
			kn.createUpdateDelete(sql,parameters);
			dataGridView1.DataSource = kn.readData(laydl);
			MessageBox.Show("Sửa thành công!");
		}

		private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
		{
			var row = dataGridView1.CurrentRow;
			txtMaTL.Text = row.Cells[0].Value.ToString();
			txtTentL.Text = row.Cells[1].Value.ToString();
			txtMoTa.Text = row.Cells[2].Value.ToString();
		}

		private void btnXoa1_Click(object sender, EventArgs e)
		{
			string ma_tl = txtMaTL.Text;
			string sql = "delete from theloai where MaTheLoai=@ma_tl";
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@ma_tl", ma_tl));
			kn.createUpdateDelete(sql,parameters);
			dataGridView1.DataSource= kn.readData(laydl);
			MessageBox.Show("Xóa thành công!");
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
