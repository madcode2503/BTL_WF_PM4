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
            txtID.Clear();
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

                    txtID.Text = row.Cells["id"].Value.ToString();
                    txtTenChucVu.Text = row.Cells["ten"].Value.ToString();
                    txtLuongCoBan.Text = row.Cells["luong_co_ban"].Value.ToString();
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
            if (result.ErrCode == EnumErrcode.Success)
            {
                dgvChucVu.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.ErrDesc);
            }
        }


        private void quảnLýChứcVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtTenChucVu.Text) || string.IsNullOrEmpty(txtLuongCoBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                var newChucVu = new tbl_ChucVu
                {
                    id = int.Parse(txtID.Text),
                    ten = txtTenChucVu.Text,  
                    luong_co_ban = decimal.Parse(txtLuongCoBan.Text)
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
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtTenChucVu.Text) || string.IsNullOrEmpty(txtLuongCoBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                if (!int.TryParse(txtID.Text, out int id) || !decimal.TryParse(txtLuongCoBan.Text, out decimal luongCoBan))
                {
                    MessageBox.Show("ID hoặc Lương cơ bản không hợp lệ.");
                    return;
                }

                var updatedChucVu = new tbl_ChucVu
                {
                    id = id,
                    ten = txtTenChucVu.Text,
                    luong_co_ban = luongCoBan
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
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Vui lòng nhập ID của chức vụ cần xóa.");
                    return;
                }

                int idToDelete = int.Parse(txtID.Text);

                var result = chucVuController.DeleteChucVu(idToDelete);
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

        private void txtTenChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
