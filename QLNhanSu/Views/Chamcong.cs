using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNhanSu.Views
{
    public partial class Chamcong : Form
    {
        public Chamcong()
        {
            InitializeComponent();
            load_data();
        }
        QLNhanSuDataContext db= new QLNhanSuDataContext();
       
        private void button1_Click_1(object sender, EventArgs e)
        {

            string ten=string.Empty;
            int so_buoi_nghi;
            DateTime ngay_cham_cong= DateTime.Parse(dateTimePicker1.Text);

            if (textBox2.Text != "")
            {
                so_buoi_nghi = Convert.ToInt32(textBox2.Text);
            }
            else
            {
                so_buoi_nghi = 0;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
                return;
            }
            if (textBox1.Text!="" )
            {
                ten= textBox1.Text;
                var st = new tbl_ChamCong
                {
                    ten_nhan_vien = ten,
                    so_ngay_nghi = so_buoi_nghi,
                    thang_nam = ngay_cham_cong,
                };
                db.tbl_ChamCongs.InsertOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!");
                textBox1.Text = "";
                textBox2.Text = "";
                load_data();

            }
            
            
           
            
        }
       
       public void load_data()
        {
            var st = from s in db.tbl_ChamCongs select s;
            dataGridView1.DataSource = st;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string timkiem = textBox3.Text;
            var st = from s in db.tbl_ChamCongs where (s.ten_nhan_vien==timkiem) select s;
            dataGridView1 .DataSource = st;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
