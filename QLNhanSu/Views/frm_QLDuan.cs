using QLNhanSu.Controllers;
using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static QLNhanSu.Models.QLDuan;

namespace QLNhanSu.Views
{
    public partial class frm_QLDuan : Form
    {
       private DuanController duanController = new DuanController();
        private int selectedProjectId ; 

        public frm_QLDuan()
        {
            InitializeComponent();
       
        }

        private void frm_QLDuan_Load(object sender, EventArgs e)
        {
            Width = Parent.Width;
            Height = Parent.Height;
            // lay du lieu tu csdl va hien thi len datagridview
            var projects = duanController.GetAllDuAn();
            //switch tab tab - rs.err- enter
            switch (projects.ErrCode)
            {
                case Models.EnumErrcode.Error:
                    MessageBox.Show(projects.ErrDesc, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrcode.Success:

                    tbl_duan_gridview.DataSource = projects.Data;
                    break;
                case Models.EnumErrcode.Empty:
                    MessageBox.Show(projects.ErrDesc, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenduan = txt_TenDuan.Text;
            string maduan = txt_MaDuan.Text;
            DateTime startDate = dtpNgayBatDau.Value;
            DateTime endDate = dtpNgayKetThuc.Value;
            string trangthai = comboBoxStatus.SelectedItem?.ToString() ?? "Đang hoạt động"; // Giá trị mặc định
            string mota = txt_Mota.Text;
            if (string.IsNullOrEmpty(tenduan) || string.IsNullOrEmpty(maduan) || string.IsNullOrEmpty(trangthai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (startDate >= endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải trước  ngày kết thúc!");
                return;
            }
            if (startDate < DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu không được là ngày trong quá khứ!");
                return;
            }
            if (duanController.CheckIfDuAnExists(maduan, tenduan))
            {
                MessageBox.Show("Mã dự án hoặc tên dự án đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DuanController.AddDuAn(tenduan, maduan, startDate, endDate, trangthai, mota);
            LoadData();
                }

        public void LoadData()
        {
            var projects = duanController.GetAllDuAn();
            switch (projects.ErrCode)
            {
                case Models.EnumErrcode.Error:
                    MessageBox.Show(projects.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrcode.Success:
                    tbl_duan_gridview.DataSource = null;
                    tbl_duan_gridview.DataSource = projects.Data;
                    break;
                case Models.EnumErrcode.Empty:
                    MessageBox.Show(projects.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbl_duan_gridview.DataSource = null;
                    break;
                default:
                    break;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedProjectId.ToString()))
            {
                MessageBox.Show("Vui lòng chọn một dự án để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenduan = txt_TenDuan.Text;
            DateTime startDate = dtpNgayBatDau.Value;
            DateTime endDate = dtpNgayKetThuc.Value;
            string trangthai = comboBoxStatus.SelectedItem?.ToString();
            string mota = txt_Mota.Text;
            string maduan =txt_MaDuan.Text;

            if (startDate >= endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!");
                return;
            }
            if (startDate < DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu không được là ngày trong quá khứ!");
                return;
            }

            duanController.UpdateDuAn(selectedProjectId, tenduan, maduan, startDate, endDate, trangthai, mota);

            LoadData();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedProjectId.ToString()))
            {
                MessageBox.Show("Vui lòng chọn một dự án để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dự án này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                var result = duanController.DeleteDuAn(selectedProjectId);
                if (result.ErrCode == EnumErrcode.Success)
                {
                    MessageBox.Show(result.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show(result.ErrDesc, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbl_duan_gridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra không click vào tiêu đề
            {
                var row = tbl_duan_gridview.Rows[e.RowIndex];
                selectedProjectId =int.Parse( row.Cells["id"].Value.ToString());
                txt_TenDuan.Text = row.Cells["ten"].Value?.ToString();
                txt_MaDuan.Text = row.Cells["ma"].Value?.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["ngay_bat_dau"].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["ngay_ket_thuc"].Value);
                comboBoxStatus.Text = row.Cells["trang_thai"].Value?.ToString();
                txt_Mota.Text = row.Cells["mo_ta"].Value?.ToString();
            }
        }
    }
}
