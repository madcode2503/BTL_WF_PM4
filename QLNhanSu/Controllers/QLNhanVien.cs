using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhanSu.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLNhanSu.Controllers
{
    internal static class QLNhanVien
    {

        public static QLNhanSuDataContext db = new QLNhanSuDataContext();

        public static FunctionResult<List<tbl_NhanVien>> getStaff()
        {
            FunctionResult<List<tbl_NhanVien>> data = new FunctionResult<List<tbl_NhanVien>>(); ;
            try
            {
                var staff = db.tbl_NhanViens;
                if (staff.Any())
                {
                    //lay dc du lieu tu csdl(success)
                    data.ErrCode = EnumErrcode.Success;
                    data.ErrDesc = "Lay du lieu thanh cong";
                    data.Data = staff.ToList();
                }
                else
                {
                    //empty
                    data.ErrCode = EnumErrcode.Empty;
                    data.ErrDesc = "Du lieu trong ccsdl dang trong";
                    data.Data = null;

                }
            }
            catch (Exception ex)
            {
                //error
                data.ErrCode = EnumErrcode.Error;
                data.ErrDesc = "Co loi xay ra trong qua trinh lay du lieu tai khoan. Chi tiet loi: " + ex.Message;

                data.Data = null;
            }
            return data;

        }
        public static List<string> GetTenChucVu()
        {
            try
            {

                return db.tbl_ChucVus.Select(cv => cv.ten).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy tên chức vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }
        public static List<string> GetTenPhong()
        {
            try
            {

                return db.tbl_PhongBans.Select(pb => pb.ten).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy tên phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }


        public static void AddNhanVien(string ho, string ten, DateTime ngaySinh, bool gioiTinh, string email, string sdt, string cccd, string maPhong, string diachi, string maChucVu)
        {
            try
            {
                // Tạo đối tượng nhân viên mới
                tbl_NhanVien nhanVien = new tbl_NhanVien
                {
                    ho = ho,
                    ten = ten,
                    ngay_sinh = ngaySinh,
                    gioi_tinh = gioiTinh,
                    dia_chi = diachi,
                    email = email,
                    so_dien_thoai = sdt,
                    cccd = cccd,
                    ten_phong_ban = maPhong,
                    ten_chuc_vu = maChucVu
                };

                db.tbl_NhanViens.InsertOnSubmit(nhanVien);

                db.SubmitChanges();

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteNhanVien(int id)
        {
            FunctionResult<string> rs = new FunctionResult<string>();
            var staff = db.tbl_NhanViens.Where(emp => emp.id == id).FirstOrDefault();
            if (staff != null)
            {
                db.tbl_NhanViens.DeleteOnSubmit(staff);
                db.SubmitChanges();
                rs.ErrCode = EnumErrcode.Success;
                rs.ErrDesc = "xoa thanh cong";

            }
            else
            {
                rs.ErrCode = EnumErrcode.Error;
                rs.ErrDesc = "xoa that bai";
            }
        }
        public static void UpdateNhanVien(int id, string ho, string ten, DateTime ngaySinh, bool gioiTinh, string email,string sdt, string cccd,   string tenPhong, string diachi, string tenChucVu)
        {
            try
            {
                tbl_NhanVien nhanVien = db.tbl_NhanViens.FirstOrDefault(nv => nv.id == id);
                if (nhanVien == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên với ID đã cho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nhanVien.ho = ho;
                nhanVien.ten = ten;
                nhanVien.ngay_sinh = ngaySinh;
                nhanVien.gioi_tinh = gioiTinh;
                nhanVien.dia_chi = diachi;
                nhanVien.email = email;
                nhanVien.so_dien_thoai = sdt;
                nhanVien.cccd = cccd;
                nhanVien.ten_phong_ban = tenPhong;
                nhanVien.ten_chuc_vu = tenChucVu;

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                // Thông báo thành công
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<tbl_NhanVien> Search(string searchQuery)
        {
            return getStaff().Data
                .Where(staff => staff.ho.ToLower().Contains(searchQuery.ToLower()) || // Tìm kiếm theo họ
                                staff.ten.ToLower().Contains(searchQuery.ToLower()) || // Tìm kiếm theo tên
                                staff.so_dien_thoai.Contains(searchQuery) || // Tìm kiếm theo số điện thoại
                                staff.email.ToLower().Contains(searchQuery.ToLower()) || // Tìm kiếm theo email
                                staff.dia_chi.ToLower().Contains(searchQuery.ToLower()) || // Tìm kiếm theo địa chỉ
                                staff.cccd.Contains(searchQuery) || // Tìm kiếm theo CCCD
                                staff.ten_phong_ban.ToLower().Contains(searchQuery.ToLower()) || // Tìm kiếm theo tên phòng ban
                                staff.ten_chuc_vu.ToLower().Contains(searchQuery.ToLower())) // Tìm kiếm theo tên chức vụ
                .ToList();
        }
    }
}