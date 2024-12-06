using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Controllers
{
    internal class QLChamCong
    {
        public static QLNhanSuDataContext db= new QLNhanSuDataContext();

        public static void ThemNhanVien(int msnv,string ten,int so_ngay_nghi,DateTime nam_thang)
        {
            try
            {
                tbl_ChamCong chamcong = new tbl_ChamCong
                {
                    ma_nhan_vien = msnv,
                    ten_nhan_vien = ten,
                    so_ngay_nghi = so_ngay_nghi,
                    thang_nam = nam_thang
                };
                db.tbl_ChamCongs.InsertOnSubmit(chamcong);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}
