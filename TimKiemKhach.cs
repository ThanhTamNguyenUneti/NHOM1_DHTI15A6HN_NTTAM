using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSDT
{
    public partial class TimKiemKhach : Form
    {
        KetNoi kn = new KetNoi();
        public TimKiemKhach()
        {
            InitializeComponent();
        }

		private void btnTim_Click(object sender, EventArgs e)
		{
            if (!string.IsNullOrEmpty(txtND.Text))
            {
				
				if((!rdMaKH.Checked) && (!rdTenKH.Checked))
				{
					MessageBox.Show("Vui chọn thông tin cần tìm");
				}
				else
				{
					if (rdMaKH.Checked)
					{
						string sql = "select * from khachhang where MaKhachHang = @makh";
						List<SqlParameter> parameters = new List<SqlParameter>();
						parameters.Add(new SqlParameter("@makh", txtND.Text));
						dgvKhachHang.DataSource = kn.readData(sql, parameters);
					}
					if (rdTenKH.Checked)
					{
						string sql = "select * from khachhang where TenKhachHang like '%'+ @tenkh +'%'";
						List<SqlParameter> parameters = new List<SqlParameter>();
						parameters.Add(new SqlParameter("@tenkh", txtND.Text));
						dgvKhachHang.DataSource = kn.readData(sql, parameters);
					}
				}	
			}
			else
			{
				MessageBox.Show("Vui lòng nhập thông tin cần tìm");
			}  
		}

		private void TimKiemKhach_Load(object sender, EventArgs e)
		{
		

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
