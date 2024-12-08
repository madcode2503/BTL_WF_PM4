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
            LoadMaNhanVien();   // Tải danh sách Mã Nhân Viên vào ComboBox
        }

        private NhanVienDuAnController controller = new NhanVienDuAnController();

        private void LoadData()
        {
            //dataGridView1.DataSource = controller.GetAll();
            var result = controller.GetAll();
            if (result.ErrCode == EnumErrcode.Success)
            {
                dataGridView1.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.ErrDesc);
            }
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
                    cbbmaduan.DisplayMember = "ten";  // Hiển thị Mã Dự Án
                    cbbmaduan.ValueMember = "id";   // Gắn giá trị là ID
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



            //try
            //{
            //    var duanController = new DuanController();
            //    var result = duanController.GetAllDuAn();
            //    if (result.ErrCode == EnumErrcode.Success)
            //    {
            //        cbbmaduan.DataSource = result.Data;
            //        cbbmaduan.DisplayMember = "ten";
            //        cbbmaduan.ValueMember = "id";
            //    }
            //    else
            //    {
            //        MessageBox.Show(result.ErrDesc);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi khi tải danh sách Mã Dự Án: {ex.Message}");
            //}
        }

        private void LoadMaNhanVien()
        {
            //try
            //{
            //    var result = QLNhanVien.getStaff();
            //    if (result.ErrCode == EnumErrcode.Success)
            //    {
            //        cbbmanhanvien.DataSource = result.Data;
            //        cbbmanhanvien.DisplayMember = "ten";  // Hiển thị tên nhân viên
            //        cbbmanhanvien.ValueMember = "id";        // Gắn giá trị là ID nhân viên
            //    }
            //    else
            //    {
            //        MessageBox.Show(result.ErrDesc);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi khi tải danh sách Mã Nhân Viên: {ex.Message}");
            //}

            try
            {
                var result = QLNhanVien.getStaff();
                if (result.ErrCode == EnumErrcode.Success)
                {
                    var dataWithFullName = result.Data.Cast<dynamic>() // Ép kiểu sang dynamic để xử lý các cột không cố định
                                            .Select(x => new
                                            {
                                                x.id,            
                                                ho_ten = $"{x.ho} {x.ten}"
                                            }).ToList();

                    cbbmanhanvien.DataSource = dataWithFullName;
                    cbbmanhanvien.DisplayMember = "ho_ten"; 
                    cbbmanhanvien.ValueMember = "id";     
                }
                else
                {
                    MessageBox.Show(result.ErrDesc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách Mã Nhân Viên: {ex.Message}");
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
            //try
            //{
            //    int maDuAn = Convert.ToInt32(cbbmaduan.SelectedValue);
            //    int maNhanVien = Convert.ToInt32(txtmanhanvien.Text);

            //    controller.Delete(maDuAn, maNhanVien);
            //    MessageBox.Show("Xóa thành công!");
            //    LoadData();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi xóa nhân viên tham gia: " + ex.Message);
            //}

            try
            {
                int maDuAn = Convert.ToInt32(cbbmaduan.SelectedValue);
                int maNhanVien = Convert.ToInt32(cbbmanhanvien.SelectedValue);

                var result = controller.Delete(maDuAn, maNhanVien);
                MessageBox.Show(result.ErrDesc);
                if (result.ErrCode == EnumErrcode.Success)
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nhân viên tham gia: {ex.Message}");
            }

      
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cbbmaduan.SelectedValue == null)
            //    {
            //        MessageBox.Show("Vui lòng chọn Mã Dự Án!");
            //        return;
            //    }

            //    //var nv = new Nhanvienduan
            //    //{

            //    //    MaDuAn = Convert.ToInt32(cbbmaduan.SelectedValue),
            //    //    MaNhanVien = Convert.ToInt32(txtmanhanvien.Text),
            //    //    VaiTro = cbbvaitro.Text,
            //    //    NgayThamGia = dtpngaybatdau.Value,
            //    //    NgayKetThuc = dtpngayketthuc.Value
            //    //};
            //    var nv = new tbl_ThamGiaDuAn
            //    {
            //        ma_du_an = Convert.ToInt32(cbbmaduan.SelectedValue),
            //        ma_nhan_vien = Convert.ToInt32(txtmanhanvien.Text),
            //        vai_tro = cbbvaitro.Text,
            //        ngay_tham_gia = dtpngaybatdau.Value,
            //        ngay_roi_khoi = dtpngayketthuc.Value
            //    };

            //    controller.Edit(nv);
            //    MessageBox.Show("Cập nhật thành công!");
            //    LoadData();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi sửa nhân viên tham gia: " + ex.Message);
            //}

            try
            {
                var updatedRecord = new tbl_ThamGiaDuAn
                {
                    ma_du_an = Convert.ToInt32(cbbmaduan.SelectedValue),
                    ma_nhan_vien = Convert.ToInt32(cbbmanhanvien.SelectedValue),
                    vai_tro = cbbvaitro.Text,
                    ngay_tham_gia = dtpngaybatdau.Value,
                    ngay_roi_khoi = dtpngayketthuc.Value
                };

                var result = controller.Edit(updatedRecord);
                MessageBox.Show(result.ErrDesc);
                if (result.ErrCode == EnumErrcode.Success)
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa nhân viên tham gia: {ex.Message}");
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

                //var nv = new Nhanvienduan
                //{
                //    MaDuAn = Convert.ToInt32(cbbmaduan.SelectedValue),
                //    MaNhanVien = Convert.ToInt32(txtmanhanvien.Text),
                //    VaiTro = cbbvaitro.Text,
                //    NgayThamGia = dtpngaybatdau.Value,
                //    NgayKetThuc = dtpngayketthuc.Value
                //};
                var nv = new tbl_ThamGiaDuAn
                {
                    ma_du_an = Convert.ToInt32(cbbmaduan.SelectedValue),
                    ma_nhan_vien = Convert.ToInt32(cbbmanhanvien.SelectedValue),
                    vai_tro = cbbvaitro.Text,
                    ngay_tham_gia = dtpngaybatdau.Value,
                    ngay_roi_khoi = dtpngayketthuc.Value
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
            //if (e.RowIndex >= 0)
            //{
            //    txtmanhanvien.Text = dataGridView1.Rows[e.RowIndex].Cells["ma_nhan_vien"].Value?.ToString() ?? string.Empty;

            //    if (dataGridView1.Rows[e.RowIndex].Cells["ma_du_an"].Value != null)
            //    {
            //        cbbmaduan.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["ma_du_an"].Value;
            //    }

            //    if (dataGridView1.Rows[e.RowIndex].Cells["vai_tro"].Value != null)
            //    {
            //        cbbvaitro.Text = dataGridView1.Rows[e.RowIndex].Cells["vai_tro"].Value.ToString();
            //    }

            //    dtpngaybatdau.Value = dataGridView1.Rows[e.RowIndex].Cells["ngay_tham_gia"].Value != null
            //        ? Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["ngay_tham_gia"].Value)
            //        : DateTime.Now;

            //    dtpngayketthuc.Value = dataGridView1.Rows[e.RowIndex].Cells["ngay_ket_thuc"].Value != null
            //        ? Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["ngay_ket_thuc"].Value)
            //        : DateTime.Now;
            //}

            if (e.RowIndex >= 0)
            {
                cbbmanhanvien.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["ma_nhan_vien"].Value;
                cbbmaduan.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["ma_du_an"].Value;
                cbbvaitro.Text = dataGridView1.Rows[e.RowIndex].Cells["vai_tro"].Value?.ToString() ?? string.Empty;
                dtpngaybatdau.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["ngay_tham_gia"].Value ?? DateTime.Now);
                dtpngayketthuc.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["ngay_roi_khoi"].Value ?? DateTime.Now);
            }
        }


    }
}
