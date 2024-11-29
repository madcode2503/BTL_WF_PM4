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
    public partial class Form_ChucVu : Form
    {
        private ChucVuController chucVuController = new ChucVuController();

        public Form_ChucVu()
        {
            InitializeComponent();
            LoadData();
        }

        private void ClearForm()
        {
            txtTenChucVu.Clear();
            txtLuongCoBan.Clear();
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvChucVu.Rows[e.RowIndex];
                    txtTenChucVu.Text = row.Cells["TenChucVu"].Value.ToString();
                    txtLuongCoBan.Text = row.Cells["LuongCoBan"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }


        private void LoadData()
        {
            var result = chucVuController.GetAllChucVu();
            dgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (result.ErrCode == EnumErrcode.Success)
            {
                dgvChucVu.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.ErrDesc);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenChucVu.Text) || string.IsNullOrEmpty(txtLuongCoBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                if (!decimal.TryParse(txtLuongCoBan.Text, out decimal luongCoBan))
                {
                    MessageBox.Show("Lương cơ bản không hợp lệ.");
                    return;
                }

                var newChucVu = new ChucVu
                {
                    TenChucVu = txtTenChucVu.Text,
                    LuongCoBan = luongCoBan
                };

                var result = chucVuController.AddChucVu(newChucVu);
                if (result.ErrCode == EnumErrcode.Success)
                {
                    MessageBox.Show(result.ErrDesc);
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(result.ErrDesc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChucVu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một chức vụ để sửa.");
                    return;
                }

                if (string.IsNullOrEmpty(txtTenChucVu.Text) || string.IsNullOrEmpty(txtLuongCoBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                if (!int.TryParse(dgvChucVu.SelectedRows[0].Cells["ID"].Value.ToString(), out int id) ||
                    !decimal.TryParse(txtLuongCoBan.Text, out decimal luongCoBan))
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.");
                    return;
                }

                var updatedChucVu = new ChucVu
                {
                    ID = id,
                    TenChucVu = txtTenChucVu.Text,
                    LuongCoBan = luongCoBan
                };

                var result = chucVuController.EditChucVu(updatedChucVu);
                if (result.ErrCode == EnumErrcode.Success)
                {
                    MessageBox.Show(result.ErrDesc);
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(result.ErrDesc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChucVu.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dgvChucVu.SelectedRows[0].Index;
                    int idToDelete = Convert.ToInt32(dgvChucVu.Rows[selectedRowIndex].Cells["ID"].Value);

                    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        var result = chucVuController.DeleteChucVu(idToDelete);
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
                else
                {
                    MessageBox.Show("Vui lòng chọn một chức vụ cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
