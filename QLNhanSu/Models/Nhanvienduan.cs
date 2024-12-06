using System;

namespace QLNhanSu.Models
{
    internal class Nhanvienduan
    {
      
        public int MaDuAn { get; set; }
        public int MaNhanVien { get; set; }
        public string VaiTro { get; set; }
        public DateTime NgayThamGia { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
