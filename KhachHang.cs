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
    public partial class KhachHang : Form
    {
		KetNoi kn = new KetNoi();
		string laydl = "SELECT * FROM KhachHang";
		public KhachHang()
        {
            InitializeComponent();
			dgvKhachHang.DataSource = kn.readData(laydl);
		}

		private void KhachHang_Load(object sender, EventArgs e)
		{
			
		}

		private void dgvKhachHang_MouseClick(object sender, MouseEventArgs e)
		{
			var row = dgvKhachHang.CurrentRow;
			txtMaKH.Text = row.Cells[0].Value.ToString();
			txtTenKH.Text = row.Cells[1].Value.ToString();
			txtEmail.Text = row.Cells[2].Value.ToString();
			mtbDienThoai.Text = row.Cells[3].Value.ToString();
			txtDiaChi.Text = row.Cells[4].Value.ToString();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string tenkh = txtTenKH.Text;
			string email = txtEmail.Text;
			string dienthoai = mtbDienThoai.Text;
			string diachi = txtDiaChi.Text;
			string sql = "INSERT INTO KhachHang(TenKhachHang,Email,DienThoai,DiaChi) VALUES(@tenkh,@email,@dienthoai,@diachi)";
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@tenkh", tenkh));
			parameters.Add(new SqlParameter("@email", email));
			parameters.Add(new SqlParameter("@dienthoai", dienthoai));
			parameters.Add(new SqlParameter("@diachi", diachi));
			kn.createUpdateDelete(sql, parameters);
			dgvKhachHang.DataSource = kn.readData(laydl);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string makh = txtMaKH.Text;
			if(string.IsNullOrEmpty(makh))
			{
				MessageBox.Show("Vui lòng chọn thông tin cần xóa!", "Thông báo");
				return;
			}	
			string sql = "delete from khachhang where MaKhachHang = @makh";
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@makh", makh));
			kn.createUpdateDelete(sql, parameters);
			dgvKhachHang.DataSource = kn.readData(laydl);
			MessageBox.Show("Xóa thành công");
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string makh = txtMaKH.Text;
			string tenkh = txtTenKH.Text;
			string email = txtEmail.Text;
			string dienthoai = mtbDienThoai.Text;
			string diachi = txtDiaChi.Text;
			string sql = "update khachhang set TenKhachHang=@tenkh,Email=@email,DienThoai=@dienthoai,DiaChi=@diachi where MaKhachHang=@makh";
			List<SqlParameter > parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@makh", makh));
			parameters.Add(new SqlParameter("@tenkh", tenkh));
			parameters.Add(new SqlParameter("@email", email));
			parameters.Add(new SqlParameter("@dienthoai", dienthoai));
			parameters.Add(new SqlParameter("@diachi", diachi));
			kn.createUpdateDelete(sql, parameters);
			dgvKhachHang.DataSource = kn.readData(laydl);
			MessageBox.Show("Sửa thành công");
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
