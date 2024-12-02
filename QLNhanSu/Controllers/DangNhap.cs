using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Controllers
{
    internal class DangNhap
    {
        private QLNhanSuDataContext db = new QLNhanSuDataContext(); // Kết nối cơ sở dữ liệu

        public FunctionResult<bool> dangnhap(string tenDangNhap, string matKhau)
        {
            // Kết quả trả về
            FunctionResult<bool> rs = new FunctionResult<bool>();

            try
            {
                // Kiểm tra thông tin nhập liệu
                if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
                {
                    rs.ErrCode = EnumErrcode.Empty;
                    rs.ErrDesc = "Vui lòng nhập đầy đủ thông tin!";
                    rs.Data = false;
                    return rs;
                }

                // Truy vấn tài khoản từ cơ sở dữ liệu
                var taiKhoan = db.tbl_TaiKhoans
                                 .FirstOrDefault(t => t.ten_dang_nhap == tenDangNhap && t.mat_khau == matKhau);

                // Kiểm tra kết quả truy vấn
                if (taiKhoan != null)
                {
                    rs.ErrCode = EnumErrcode.Success;
                    rs.ErrDesc = "Đăng nhập thành công!";
                    rs.Data = true; // Trả về true nếu đăng nhập thành công
                }
                else
                {
                    rs.ErrCode = EnumErrcode.Empty;
                    rs.ErrDesc = "Tên đăng nhập hoặc mật khẩu không chính xác!";
                    rs.Data = false;
                }
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrcode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong quá trình xử lý: " + ex.Message;
                rs.Data = false;
            }

            return rs;
        }
    }


}
