using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    internal class BangLuongDto
    {
        //public int id { get; set; }  // ID
        public int MaNhanVien { get; set; }  // Mã nhân viên
        public string TenNhanVien { get; set; }  // Họ tên nhân viên
        public string ChucVu { get; set; }  // Chức vụ
        public string PhongBan { get; set; }  // Phòng ban
        public int SoNgayLam { get; set; }  // Số ngày làm
        public int Vang { get; set; }  // Số buổi vắng
        public int TangCa { get; set; } // Số buổi tăng ca
        public decimal LuongCoBan { get; set; }
        public decimal Luong { get; set; }  // Lương
    }
}
