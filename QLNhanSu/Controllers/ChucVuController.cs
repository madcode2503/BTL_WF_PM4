using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Controllers
{
    internal class ChucVuController
    {
        QLNhanSuDataContext db = new QLNhanSuDataContext();

        public FunctionResult<List<tbl_ChucVu>> GetAllChucVu()
        {
            var result = new FunctionResult<List<tbl_ChucVu>>();

            try
            {
                var chucVus = db.tbl_ChucVus.ToList();

                if (chucVus.Any())
                {
                    result.ErrCode = EnumErrcode.Success;
                    result.ErrDesc = "Lấy dữ liệu thành công.";
                    result.Data = chucVus;
                }
                else
                {
                    result.ErrCode = EnumErrcode.Empty;
                    result.ErrDesc = "Không có dữ liệu chức vụ.";
                    result.Data = null;
                }
            }
            catch (Exception ex)
            {
                result.ErrCode = EnumErrcode.Error;
                result.ErrDesc = "Lỗi khi lấy dữ liệu: " + ex.Message;
                result.Data = null;
            }

            return result;
        }

        // Thêm chức vụ mới
        public FunctionResult<bool> AddChucVu(tbl_ChucVu newChucVu)
        {
            var result = new FunctionResult<bool>();

            try
            {
                var existingChucVu = db.tbl_ChucVus.SingleOrDefault(c => c.ten == newChucVu.ten);
                if (existingChucVu != null)
                {
                    result.ErrCode = EnumErrcode.Error;
                    result.ErrDesc = "Tên chức vụ đã tồn tại.";
                    result.Data = false;
                }
                else
                {
                    db.tbl_ChucVus.InsertOnSubmit(newChucVu);
                    db.SubmitChanges();
                    result.ErrCode = EnumErrcode.Success;
                    result.ErrDesc = "Thêm chức vụ thành công.";
                    result.Data = true;
                }
            }
            catch (Exception ex)
            {
                result.ErrCode = EnumErrcode.Error;
                result.ErrDesc = "Lỗi khi thêm chức vụ: " + ex.Message;
                result.Data = false;
            }

            return result;
        }

        // Sửa chức vụ
        public FunctionResult<bool> EditChucVu(tbl_ChucVu updatedChucVu)
        {
            var result = new FunctionResult<bool>();

            try
            {
                var chucVu = db.tbl_ChucVus.SingleOrDefault(c => c.id == updatedChucVu.id);
                if (chucVu != null)
                {
                    chucVu.ten = updatedChucVu.ten;
                    chucVu.luong_co_ban = updatedChucVu.luong_co_ban;
                    db.SubmitChanges();
                    result.ErrCode = EnumErrcode.Success;
                    result.ErrDesc = "Sửa chức vụ thành công.";
                    result.Data = true;
                }
                else
                {
                    result.ErrCode = EnumErrcode.Error;
                    result.ErrDesc = "Chức vụ không tồn tại.";
                    result.Data = false;
                }
            }
            catch (Exception ex)
            {
                result.ErrCode = EnumErrcode.Error;
                result.ErrDesc = "Lỗi khi sửa chức vụ: " + ex.Message;
                result.Data = false;
            }

            return result;
        }

        // Xóa chức vụ
        public FunctionResult<bool> DeleteChucVu(int id)
        {
            var result = new FunctionResult<bool>();

            try
            {
                var chucVu = db.tbl_ChucVus.SingleOrDefault(c => c.id == id);
                if (chucVu != null)
                {
                    db.tbl_ChucVus.DeleteOnSubmit(chucVu);
                    db.SubmitChanges();
                    result.ErrCode = EnumErrcode.Success;
                    result.ErrDesc = "Xóa chức vụ thành công.";
                    result.Data = true;
                }
                else
                {
                    result.ErrCode = EnumErrcode.Error;
                    result.ErrDesc = "Chức vụ không tồn tại.";
                    result.Data = false;
                }
            }
            catch (Exception ex)
            {
                result.ErrCode = EnumErrcode.Error;
                result.ErrDesc = "Lỗi khi xóa chức vụ: " + ex.Message;
                result.Data = false;
            }

            return result;
        }
    }
}
