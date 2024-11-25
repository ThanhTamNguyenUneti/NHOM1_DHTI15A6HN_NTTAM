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
    public partial class TimKiemSach : Form
    {
        KetNoi kn = new KetNoi();
        public TimKiemSach()
        {
            InitializeComponent();
        }

		private void btnTim_Click(object sender, EventArgs e)
		{
            if((!rdMaSach.Checked) && (!rdNamXB.Checked) &&(!rdTenSach.Checked)) 
            {
                MessageBox.Show("Vui lòng chọn thông tin cần tìm");
            }    
            else
            {
                if (string.IsNullOrEmpty(txtND.Text))
                {
                    MessageBox.Show("Vui lòng điền thông tin cần tìm");
                } 
                else
                {
                    if (rdMaSach.Checked)
                    {
                        string ma_sach = txtND.Text;
                        string sql = "SELECT * FROM SACH where MaSach = @ma_sach";
                        List<SqlParameter> parameters = new List<SqlParameter>();
                        parameters.Add(new SqlParameter("@ma_sach", ma_sach));
                        dgvSach.DataSource = kn.readData(sql,parameters);
					} 
                    if(rdTenSach.Checked)
                    {
						string ten_sach = txtND.Text;
						string sql = "SELECT * FROM SACH where TenSach Like '%'+@ten_sach+'%'";
						List<SqlParameter> parameters = new List<SqlParameter>();
						parameters.Add(new SqlParameter("@ten_sach", ten_sach));
						dgvSach.DataSource = kn.readData(sql, parameters);
					}   
                    if(rdNamXB.Checked)
                    {
						DateTime nam_xb;
						if (DateTime.TryParse(txtND.Text, out nam_xb))
						{
							string sql = "SELECT * FROM SACH WHERE NamXB = @nam_xb";
							List<SqlParameter> parameters = new List<SqlParameter>();
							parameters.Add(new SqlParameter("@nam_xb", nam_xb)); 
							dgvSach.DataSource = kn.readData(sql, parameters);
						}
						else
						{
							MessageBox.Show("Vui lòng nhập đúng định dạng ngày.");
						}
					}    
                }    
            }    
		}

		private void button1_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
