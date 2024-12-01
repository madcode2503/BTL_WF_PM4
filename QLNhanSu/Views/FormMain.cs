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

        private void qLLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLLuong frm_QLLuong = new frm_QLLuong();

            ShowFormInPanel(frm_QLLuong);
        }
    }
}
