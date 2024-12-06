using QLNhanSu.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static QLNhanSu.Models.QLDuan;

namespace QLNhanSu.Views
{
    public partial class frm_QLDuan : Form
    {
        private DuanController _duAnController;

        public frm_QLDuan()
        {
            InitializeComponent();
            _duAnController = new DuanController();
            LoadDuAnData();
        }

        private void LoadDuAnData()
        {
            List<DuAn> danhSachDuAn = _duAnController.GetAllDuAn();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachDuAn;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin dự án!");
                return;
            }

            DuAn duAn = new DuAn
            {
                Ten = txtTen.Text,
                Ma = txtMa.Text,
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Value,
                TrangThai = comboBoxStatus.SelectedItem?.ToString(),
                MoTa = rtbMoTa.Text
            };

            // Gọi phương thức thêm từ Controller
            if (_duAnController.AddDuAn(duAn))
            {
                MessageBox.Show("Thêm dự án thành công!");
                LoadDuAnData(); // Tải lại dữ liệu
            }
            else
            {
                MessageBox.Show("Thêm dự án thất bại! Kiểm tra lại dữ liệu.");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                if (_duAnController.DeleteDuAn(id))
                {
                    MessageBox.Show("Xóa dự án thành công!");
                    LoadDuAnData();
                }
                else
                {
                    MessageBox.Show("Xóa dự án thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dự án để xóa!");
            }
        }

        private void brnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text)) // Kiểm tra nếu ID hợp lệ
            {
                DuAn duAn = new DuAn
                {
                    ID = int.Parse(txtID.Text),
                    Ten = txtTen.Text,
                    Ma = txtMa.Text,
                    NgayBatDau = dtpNgayBatDau.Value,
                    NgayKetThuc = dtpNgayKetThuc.Value,
                    TrangThai = comboBoxStatus.SelectedItem?.ToString() ?? "Đang hoạt động", // Giá trị mặc định
                    MoTa = rtbMoTa.Text
                };

                // Cập nhật dự án
                if (_duAnController.UpdateDuAn(duAn))
                {
                    MessageBox.Show("Cập nhật dự án thành công!");
                    LoadDuAnData(); // Tải lại dữ liệu
                }
                else
                {
                    MessageBox.Show("Cập nhật dự án thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dự án để sửa!");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng không nhấn vào tiêu đề cột
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Đổ dữ liệu từ hàng được chọn vào các trường nhập liệu
                txtID.Text = selectedRow.Cells["ID"].Value?.ToString();
                txtTen.Text = selectedRow.Cells["Ten"].Value?.ToString();
                txtMa.Text = selectedRow.Cells["Ma"].Value?.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(selectedRow.Cells["NgayBatDau"].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(selectedRow.Cells["NgayKetThuc"].Value);
                comboBoxStatus.SelectedItem = selectedRow.Cells["TrangThai"].Value?.ToString();
                rtbMoTa.Text = selectedRow.Cells["MoTa"].Value?.ToString();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng không click vào tiêu đề cột
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Đổ dữ liệu từ hàng được chọn vào các trường nhập liệu
                txtID.Text = selectedRow.Cells["ID"].Value?.ToString();
                txtTen.Text = selectedRow.Cells["Ten"].Value?.ToString();
                txtMa.Text = selectedRow.Cells["Ma"].Value?.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(selectedRow.Cells["NgayBatDau"].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(selectedRow.Cells["NgayKetThuc"].Value);
                comboBoxStatus.SelectedItem = selectedRow.Cells["TrangThai"].Value?.ToString();
                rtbMoTa.Text = selectedRow.Cells["MoTa"].Value?.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
