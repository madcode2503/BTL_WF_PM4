﻿using QLNhanSu.Controllers;
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
    public partial class Form_PhongBan : Form
    {
        private readonly PhongBanController phongBanController = new PhongBanController();
        public Form_PhongBan()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txt_tenphongban.Clear();
            txt_maphongban.Clear();
        }
        private void LoadData()
        {
            var result = phongBanController.GetAllPhongBan();
            DataGridViewPhongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (result.ErrCode == EnumErrcode.Success)
            {

                DataGridViewPhongBan.DataSource = result.Data;
                DataGridViewPhongBan.Refresh();
            }
            else
            {
                DataGridViewPhongBan.DataSource = null;
                MessageBox.Show(result.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DataGridViewPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DataGridViewPhongBan.Rows[e.RowIndex];
                    txt_tenphongban.Text = row.Cells["ten"].Value?.ToString();
                    txt_maphongban.Text = row.Cells["ma"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tenphongban.Text) || string.IsNullOrWhiteSpace(txt_maphongban.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newPhongBan = new tbl_PhongBan
                {
                    ten = txt_tenphongban.Text,
                    ma = txt_maphongban.Text
                };

                var result = phongBanController.AddPhongBan(newPhongBan);
                MessageBox.Show(result.ErrDesc, "Thông báo", result.ErrCode == EnumErrcode.Success ? MessageBoxButtons.OK : MessageBoxButtons.OK, result.ErrCode == EnumErrcode.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (result.ErrCode == EnumErrcode.Success)
                {
                    ClearForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewPhongBan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một phòng ban để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(DataGridViewPhongBan.SelectedRows[0].Cells["id"].Value?.ToString(), out int id))
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var updatedPhongBan = new tbl_PhongBan
                {
                    id = id,
                    ten = txt_tenphongban.Text,
                    ma = txt_maphongban.Text
                };

                var result = phongBanController.EditPhongBan(updatedPhongBan);
                MessageBox.Show(result.ErrDesc, "Thông báo", result.ErrCode == EnumErrcode.Success ? MessageBoxButtons.OK : MessageBoxButtons.OK, result.ErrCode == EnumErrcode.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (result.ErrCode == EnumErrcode.Success)
                {
                    ClearForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewPhongBan.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = DataGridViewPhongBan.SelectedRows[0].Index;
                    int idToDelete = Convert.ToInt32(DataGridViewPhongBan.Rows[selectedRowIndex].Cells["id"].Value);

                    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng ban này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        var result = phongBanController.DeletePhongBan(idToDelete);
                        MessageBox.Show(result.ErrDesc, "Thông báo", result.ErrCode == EnumErrcode.Success ? MessageBoxButtons.OK : MessageBoxButtons.OK, result.ErrCode == EnumErrcode.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                        if (result.ErrCode == EnumErrcode.Success)
                        {
                            LoadData();
                            ClearForm();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phòng ban cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_PhongBan_Load(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                Width = Parent.Width;
                Height = Parent.Height;
            }
            LoadData();
        }
    }
}