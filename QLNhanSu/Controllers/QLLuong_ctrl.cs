using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Controllers
{
    internal class QLLuong_ctrl
    {
        QLNhanSuDataContext db = new QLNhanSuDataContext();
        public FunctionResult<List<BangLuongDto>> GetAll(int thang, int nam)
        {
            FunctionResult<List<BangLuongDto>> rs = new FunctionResult<List<BangLuongDto>>();

            try
            {
                var query = from nv in db.tbl_NhanViens
                         join cc in db.tbl_ChamCongs on nv.id equals cc.ma_nhan_vien
                         where cc.thang_nam.HasValue && cc.thang_nam.Value.Month == thang && cc.thang_nam.Value.Year == nam
                         select new BangLuongDto
                         {
                             MaNhanVien = nv.id,
                             TenNhanVien = nv.ho + " " + nv.ten,
                             ChucVu = nv.ten_chuc_vu,
                             PhongBan = nv.ten_phong_ban,
                             SoNgayLam = (int)(DateTime.DaysInMonth(nam, thang) - cc.so_ngay_nghi), // Số ngày làm = tổng ngày trong tháng - số ngày nghỉ
                             Vang = (int)cc.so_ngay_nghi,
                             TangCa = (int)((DateTime.DaysInMonth(nam, thang) - cc.so_ngay_nghi > 20) 
                             ? (DateTime.DaysInMonth(nam, thang) - cc.so_ngay_nghi) - 20 : 0),
                             LuongCoBan = (decimal)db.tbl_ChucVus.FirstOrDefault(cv => cv.ten == nv.ten_chuc_vu).luong_co_ban,
                             Luong = CalculateLuong(
                                 (decimal)db.tbl_ChucVus.FirstOrDefault(cv => cv.ten == nv.ten_chuc_vu).luong_co_ban, 
                                 (int)(DateTime.DaysInMonth(nam, thang) - cc.so_ngay_nghi),
                                 (int)((DateTime.DaysInMonth(nam, thang) - cc.so_ngay_nghi > 20) ? (DateTime.DaysInMonth(nam, thang) - cc.so_ngay_nghi) - 20 : 0))
                         };

                foreach (var item in query)
                {
                    var exist = db.tbl_BangLuongs
                        .FirstOrDefault(bl => bl.ma_nhan_vien == item.MaNhanVien &&
                                              bl.thang.HasValue &&
                                              bl.thang.Value.Month == thang &&
                                              bl.thang.Value.Year == nam);

                    if (exist == null)
                    {
                        // Thêm dữ liệu mới vào bảng lương
                        db.tbl_BangLuongs.InsertOnSubmit(new tbl_BangLuong
                        {
                            ma_nhan_vien = item.MaNhanVien,
                            thang = new DateTime(nam, thang, 1),
                            luong_co_ban = item.LuongCoBan,
                            tong_luong = item.Luong
                        });
                    }
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                var result = query.ToList();  // Chuyển kết quả truy vấn thành danh sách

                if (result.Any())
                {
                    rs.ErrCode = EnumErrcode.Success;
                    rs.ErrDesc = "Success";
                    rs.Data = result;
                }
                else
                {
                    rs.ErrCode = EnumErrcode.Empty;
                    rs.ErrDesc = "No data found";
                    rs.Data = null;
                }
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrcode.Error;
                rs.ErrDesc = ex.Message;
                rs.Data = null;
            }

            return rs;
        }

        private decimal CalculateLuong(decimal luongCoBan, int soNgayLam, int soNgayTangCa)
        {
            decimal luongThang = luongCoBan;

            // Giảm lương nếu số ngày làm ít hơn 20 ngày
            if (soNgayLam < 20)
            {
                luongThang *= 0.8m;
            }

            luongThang += soNgayTangCa * (luongCoBan / 20); // Giả định mỗi ngày công chuẩn là 1/20 của lương cơ bản

            return luongThang;
        }
    }
}
