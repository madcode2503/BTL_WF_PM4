using QLNhanSu.Controllers;
using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Views
{
    public partial class frmNhanvienthamgia : Form
    {
        public frmNhanvienthamgia()
        {
            InitializeComponent();
            LoadData();     // Tải dữ liệu cho DataGridView
            LoadMaDuAn();   // Tải danh sách Mã Dự Án vào ComboBox
        }

        private QLNhanvienduan controller = new QLNhanvienduan();

        private void LoadData()
        {
            dataGridView1.DataSource = controller.GetAll();
        }
        private void LoadMaDuAn()
        {
            try
            {
                var duanController = new DuanController();
                var listDuAn = duanController.GetAllDuAn();

                if (listDuAn != null && listDuAn.Count > 0)
                {
                    // Gắn dữ liệu vào ComboBox
                    cbbmaduan.DataSource = listDuAn;
                    cbbmaduan.DisplayMember = "Ma";  // Hiển thị Mã Dự Án
                    cbbmaduan.ValueMember = "ID";   // Gắn giá trị là ID
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu Mã Dự Án!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách Mã Dự Án: " + ex.Message);
            }
        }


        private void cbbmanhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maDuAn = Convert.ToInt32(cbbmaduan.SelectedValue);
                int maNhanVien = Convert.ToInt32(txtmanhanvien.Text);

                controller.Delete(maDuAn, maNhanVien);
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên tham gia: " + ex.Message);
            }
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbmaduan.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn Mã Dự Án!");
                    return;
                }

                var nv = new Nhanvienduan
                {
                
                    MaDuAn = Convert.ToInt32(cbbmaduan.SelectedValue),
                    MaNhanVien = Convert.ToInt32(txtmanhanvien.Text),
                    VaiTro = cbbvaitro.Text,
                    NgayThamGia = dtpngaybatdau.Value,
                    NgayKetThuc = dtpngayketthuc.Value
                };
                controller.Update(nv);
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhân viên tham gia: " + ex.Message);
            }
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbmaduan.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn Mã Dự Án!");
                    return;
                }

                var nv = new Nhanvienduan
                {
                    MaDuAn = Convert.ToInt32(cbbmaduan.SelectedValue),
                    MaNhanVien = Convert.ToInt32(txtmanhanvien.Text),
                    VaiTro = cbbvaitro.Text,
                    NgayThamGia = dtpngaybatdau.Value,
                    NgayKetThuc = dtpngayketthuc.Value
                };
                controller.Add(nv);
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên tham gia: " + ex.Message);
            }
        }


        private void dtpngaybatdau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpngayketthuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtmanhanvien.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNhanVien"].Value?.ToString() ?? string.Empty;

                if (dataGridView1.Rows[e.RowIndex].Cells["MaDuAn"].Value != null)
                {
                    cbbmaduan.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["MaDuAn"].Value;
                }

                if (dataGridView1.Rows[e.RowIndex].Cells["VaiTro"].Value != null)
                {
                    cbbvaitro.Text = dataGridView1.Rows[e.RowIndex].Cells["VaiTro"].Value.ToString();
                }

                dtpngaybatdau.Value = dataGridView1.Rows[e.RowIndex].Cells["NgayThamGia"].Value != null
                    ? Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayThamGia"].Value)
                    : DateTime.Now;

                dtpngayketthuc.Value = dataGridView1.Rows[e.RowIndex].Cells["NgayKetThuc"].Value != null
                    ? Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayKetThuc"].Value)
                    : DateTime.Now;
            }
        }


    }
}
