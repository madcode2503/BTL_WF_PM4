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

        public FunctionResult<List<ChucVu>> GetAllChucVu()
        {
            var result = new FunctionResult<List<ChucVu>>();

            try
            {
                var chucVus = db.ChucVus.ToList();

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

        public FunctionResult<bool> AddChucVu(ChucVu newChucVu)
        {
            var result = new FunctionResult<bool>();

            try
            {
                var existingChucVu = db.ChucVus.SingleOrDefault(c => c.TenChucVu == newChucVu.TenChucVu);
                if (existingChucVu != null)
                {
                    result.ErrCode = EnumErrcode.Error;
                    result.ErrDesc = "Tên chức vụ đã tồn tại.";
                    result.Data = false;
                }
                else
                {
                    db.ChucVus.InsertOnSubmit(newChucVu);
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

        public FunctionResult<bool> EditChucVu(ChucVu updatedChucVu)
        {
            var result = new FunctionResult<bool>();

            try
            {
                var chucVu = db.ChucVus.SingleOrDefault(c => c.ID == updatedChucVu.ID);
                if (chucVu != null)
                {
                    chucVu.TenChucVu = updatedChucVu.TenChucVu;
                    chucVu.LuongCoBan = updatedChucVu.LuongCoBan;
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

        public FunctionResult<bool> DeleteChucVu(int id)
        {
            var result = new FunctionResult<bool>();

            try
            {
                var chucVu = db.ChucVus.SingleOrDefault(c => c.ID == id);
                if (chucVu != null)
                {
                    db.ChucVus.DeleteOnSubmit(chucVu);
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
