using QLNhanSu.Controllers;
using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLNhanSu.Views
{
    public partial class ChamCong : Form
    {
        QLNhanSuDataContext db = new QLNhanSuDataContext();
        public ChamCong()
        {
            InitializeComponent();
            load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ten = string.Empty;
            int manv;
            int so_buoi_nghi;
            DateTime ngay_cham_cong = DateTime.Parse(dateTimePicker1.Text);

            if (textBox2.Text != "")
            {
                so_buoi_nghi = Convert.ToInt32(textBox2.Text);
            }
            else
            {
                so_buoi_nghi = 0;
            }
            if (textBox1.Text == "" || textBox3.Text=="")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
                return;
            }
            if (textBox1.Text != "" && textBox3.Text!="")
            {
                ten = textBox1.Text;
                manv=Convert.ToInt32(textBox3.Text);
                QLChamCong.ThemNhanVien(manv, ten, so_buoi_nghi, ngay_cham_cong);
                MessageBox.Show("Cập nhật thành công!");
                textBox1.Text = "";
                textBox2.Text = "";
                load_data();
            }
        }

        public void load_data()
        {
           
            var st = from s in db.tbl_ChamCongs select s;
            dataGridView2.DataSource = st;
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var st2 = db.tbl_NhanViens.Select(e => new { e.id, e.ho, e.ten });
            dataGridView1.DataSource = st2;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void button2_Click(object sender, EventArgs e) // Trang chủ
        {
            this.Hide();
            FormMain form = new FormMain();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e) // Tải lại
        {
            load_data();
        }

        private void button3_Click(object sender, EventArgs e) // Tìm kiếm
        {
            int timkiem=Convert.ToInt32( textBox4.Text);
            var st = db.tbl_ChamCongs.Where(z => z.ma_nhan_vien == timkiem);
            dataGridView2.DataSource = st;
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
