using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using QLNhanSu.Models;
using static QLNhanSu.Models.QLDuan;

namespace QLNhanSu.Controllers
{
    internal class DuanController
    {
        private static QLNhanSuDataContext db = new QLNhanSuDataContext();

        public FunctionResult<List<tbl_DuAn>> GetAllDuAn()
        {
            FunctionResult<List<tbl_DuAn>> data = new FunctionResult<List<tbl_DuAn>>(); ;
            try
            {
                var projects = db.tbl_DuAns;
                if (projects.Any())
                {
                    //lay dc du lieu tu csdl(success)
                    data.ErrCode = EnumErrcode.Success;
                    data.ErrDesc = "Lay du lieu thanh cong";
                    data.Data = projects.ToList();
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

        // Thêm dự án
        public static void AddDuAn(string tenduan, string maduan, DateTime startDate, DateTime endDate, string trangthai, string mota)
        {

            try
            {
                tbl_DuAn duAn = new tbl_DuAn()
                {
                    ten = tenduan,
                    ma = maduan,
                    ngay_bat_dau = startDate,
                    ngay_ket_thuc = endDate,
                    trang_thai = trangthai,
                    mo_ta = mota
                };
                db.tbl_DuAns.InsertOnSubmit(duAn);
                db.SubmitChanges();
                MessageBox.Show("Thêm dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dự án: " + ex.Message);
            }
        }

        public void UpdateDuAn(int id, string tenDuAn, string maDuAn, DateTime startDate, DateTime endDate, string trangThai, string moTa)
        {
            try
            {
                var duAn = db.tbl_DuAns.FirstOrDefault(d => d.id == id);
                if (duAn != null)
                {
                    duAn.ma = maDuAn;
                    duAn.ten = tenDuAn;
                    duAn.ngay_bat_dau = startDate;
                    duAn.ngay_ket_thuc = endDate;
                    duAn.trang_thai = trangThai;
                    duAn.mo_ta = moTa;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thông tin dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dự án: " + ex.Message);

            }
        }

        public FunctionResult<bool> DeleteDuAn(int id)
        {
            var result = new FunctionResult<bool>();
            try
            {
                var duAn = db.tbl_DuAns.FirstOrDefault(d => d.id == id);
                if (duAn != null)
                {
                    db.tbl_DuAns.DeleteOnSubmit(duAn);
                    db.SubmitChanges();

                    result.ErrCode = EnumErrcode.Success;
                    result.ErrDesc = "Xóa dự án thành công!";
                    result.Data = true;
                }
                else
                {
                    result.ErrCode = EnumErrcode.Empty;
                    result.ErrDesc = "Không tìm thấy dự án để xóa!";
                }
            }
            catch (Exception ex)
            {
                result.ErrCode = EnumErrcode.Error;
                result.ErrDesc = "Lỗi khi xóa dự án: " + ex.Message;
            }
            return result;
        } 
    public bool CheckIfDuAnExists(string maduan, string tenduan)
        {
            var duAn = db.tbl_DuAns.FirstOrDefault(d => d.ma == maduan || d.ten == tenduan);
            return duAn != null;
        }

        public bool CheckIfDuAnExistsExcludeCurrent(string maduan, string tenduan, int id)
        {
            var duAn = db.tbl_DuAns.FirstOrDefault(d => (d.ma == maduan || d.ten == tenduan) && d.id != id);
            return duAn != null;
        }

    } }
