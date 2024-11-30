using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhanSu.Controllers;
using QLNhanSu.Models;
using QLNhanSu.Views.ComponentQLNhanVien;

namespace QLNhanSu.Views
{
    public partial class QLNhanVienForm : Form
    {
        private tbl_NhanVien selectedNhanVien;
        public QLNhanVienForm()
        {
            InitializeComponent();
            SetPlaceholder(txt_Search, "Nhập kí tự bạn muốn tìm kiếm...");

        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            // Khi TextBox nhận focus (user click vào), placeholder sẽ biến mất
            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            // Khi TextBox mất focus, nếu không có giá trị, placeholder sẽ hiển thị lại
            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }
        private void QLNhanVienForm_Load(object sender, EventArgs e)
        {
            Width = Parent.Width;
            Height = Parent.Height;
            // lay du lieu tu csdl va hien thi len datagridview
            var staff = QLNhanVien.getStaff();
            //switch tab tab - rs.err- enter
            switch (staff.ErrCode)
            {
                case Models.EnumErrcode.Error:
                    MessageBox.Show(staff.ErrDesc, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrcode.Success:
              
                    tbl_DuLieu_QLNhanVien.DataSource = staff.Data;
                    break;
                case Models.EnumErrcode.Empty:
                    MessageBox.Show(staff.ErrDesc, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FormAdd f = new FormAdd();
            f.ShowDialog();
        }

        private void tbl_DuLieu_QLNhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && tbl_DuLieu_QLNhanVien.Rows.Count > 0)
            {
                var r = tbl_DuLieu_QLNhanVien.Rows[e.RowIndex];
                selectedNhanVien = new tbl_NhanVien
                {
                    id = Convert.ToInt32(r.Cells["id"].Value),
                    ho = r.Cells["ho"].Value.ToString(),
                    ten = r.Cells["ten"].Value.ToString(),
                    so_dien_thoai = r.Cells["so_dien_thoai"].Value.ToString(),
                    email = r.Cells["email"].Value.ToString(),
                    dia_chi = r.Cells["dia_chi"].Value.ToString(),
                    ngay_sinh = Convert.ToDateTime(r.Cells["ngay_sinh"].Value),
                    ten_phong_ban = r.Cells["ten_phong_ban"].Value.ToString(),
                    ten_chuc_vu = r.Cells["ten_chuc_vu"].Value.ToString(),
                    cccd = r.Cells["cccd"].Value.ToString(),
                    gioi_tinh = Convert.ToBoolean(r.Cells["gioi_tinh"].Value)
                };
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (selectedNhanVien != null)
            {
                // Mở FormUpdate và truyền thông tin nhân viên vào
                FormUpdate f = new FormUpdate(selectedNhanVien);
                f.ShowDialog();
            }
            else
            {
                // Nếu chưa chọn nhân viên, hiển thị thông báo
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (selectedNhanVien != null)
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa dữ liệu này không?", "Xác Nhận Xóa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = selectedNhanVien.id;
                    QLNhanVien.DeleteNhanVien(id);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txt_Search.Text;
            if (!string.IsNullOrEmpty(searchQuery))
            {
                if(searchQuery== "Nhập kí tự bạn muốn tìm kiếm...")
                {
                    return;
                }
                var filteredStaff = QLNhanVien.Search(searchQuery);
                tbl_DuLieu_QLNhanVien.DataSource = filteredStaff;
            }
            else
            {
                LoadData();
            }
        }
        public void LoadData()
        {
            var staff = QLNhanVien.getStaff();
            {
                tbl_DuLieu_QLNhanVien.DataSource = null;
                tbl_DuLieu_QLNhanVien.DataSource = staff.Data;

            }
        }
    }
}
