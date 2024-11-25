using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSDT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.Close();
        }

		private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form khach = new KhachHang();
            this.Hide();
            khach.ShowDialog();
            this.Show();
		}

		private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form timkiem = new TimKiemKhach();
			this.Hide();
			timkiem.ShowDialog();
			this.Show();
		}

		private void tácGiảThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form tac_gia = new TacGiaTL();
			this.Hide();
			tac_gia.ShowDialog();
			this.Show();
		}

		private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form tim_kiem_sach = new TimKiemSach();
			this.Hide();
			tim_kiem_sach.ShowDialog();
			this.Show();
		}

		private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form sach = new Sach();
			this.Hide();
			sach.ShowDialog();
			this.Show();
		}

		private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form don_hang = new DonHang();
			this.Hide();
			don_hang.ShowDialog();
			this.Show();
		}

		

		private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form the_loai = new TheLoai();
			this.Hide();
			the_loai.ShowDialog();
			this.Show();
		}

		private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form don_dh = new DonDH();
			this.Hide();
			don_dh.ShowDialog();
			this.Show();
		}
	}
}
