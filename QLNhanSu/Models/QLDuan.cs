using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Models
{
    internal class QLDuan
    {
        public class DuAn
        {
            public int ID { get; set; } // ID dự án
            public string Ten { get; set; } // Tên dự án
            public string Ma { get; set; } // Mã dự án
            public DateTime NgayBatDau { get; set; } // Ngày bắt đầu
            public DateTime NgayKetThuc { get; set; } // Ngày kết thúc
            public string TrangThai { get; set; } // Trạng thái
            public string MoTa { get; set; } // Mô tả
        }
    
    }
}
