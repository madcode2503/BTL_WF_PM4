using System;
using System.Windows.Forms;
using QLNhanSu.Controllers;

namespace QLNhanSu.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
           
        }

        // Hàm hiển thị form con trong panel1
        private void ShowFormInPanel(Form childForm)
        {
            // Xóa các form con hiện có trong panel1
            PanelNhanVien.Controls.Clear();

            // Cấu hình form con
            childForm.TopLevel = false;   // Không phải cửa sổ độc lập
            childForm.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
            childForm.Dock = DockStyle.Fill; // Chiếm toàn bộ panel

            // Thêm form con vào panel1 và hiển thị
            PanelNhanVien.Controls.Add(childForm);
            childForm.Show();
        }

        // Sự kiện click vào menu QLNhanVien
        private void qLNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo instance của form QLNhanVien
            QLNhanVienForm qLNhanVienForm = new QLNhanVienForm();

            // Hiển thị form con trong panel1
            ShowFormInPanel(qLNhanVienForm);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Thiết lập các thông số ban đầu cho FormMain nếu cần
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
              "Bạn có chắc chắn muốn đăng xuất không?",
              "Xác nhận",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); 
                frm_DangNhap form = new frm_DangNhap();
                form.Show();
            }
        }
        private void qLLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLLuong frm_QLLuong = new frm_QLLuong();

            ShowFormInPanel(frm_QLLuong);
        }

        private void qLPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PhongBan form_PhongBan = new Form_PhongBan();
            ShowFormInPanel(form_PhongBan);
        }

        private void qLNhanVienDuAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvienthamgia Frm_Nhanvienthamgia = new frmNhanvienthamgia();
            ShowFormInPanel(Frm_Nhanvienthamgia);
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCong chamcong = new ChamCong();
            ShowFormInPanel(chamcong);
        }

        private void qLChứcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qLChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ChucVu form_ChucVu = new Form_ChucVu();
            ShowFormInPanel(form_ChucVu);
        }
    }
}
