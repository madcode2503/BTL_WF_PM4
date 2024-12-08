using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLNhanSu.Controllers
{
    internal class NhanVienDuAnController
    {
        private readonly QLNhanSuDataContext db = new QLNhanSuDataContext();

        public FunctionResult<List<tbl_ThamGiaDuAn>> GetAll()
        {
            try
            {
                var thamGiaDuAnList = db.tbl_ThamGiaDuAns.ToList();
                return new FunctionResult<List<tbl_ThamGiaDuAn>>
                {
                    ErrCode = thamGiaDuAnList.Any() ? EnumErrcode.Success : EnumErrcode.Empty,
                    ErrDesc = thamGiaDuAnList.Any() ? "Lấy danh sách nhân viên dự án thành công." : "Không có dữ liệu nhân viên dự án.",
                    Data = thamGiaDuAnList
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<List<tbl_ThamGiaDuAn>>
                {
                    ErrCode = EnumErrcode.Error,
                    ErrDesc = $"Lỗi khi lấy dữ liệu: {ex.Message}",
                    Data = null
                };
            }
        }

        public FunctionResult<bool> Add(tbl_ThamGiaDuAn newRecord)
        {
            try
            {
                if (newRecord.ma_du_an <= 0 || newRecord.ma_nhan_vien <= 0)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Mã dự án và mã nhân viên không được để trống hoặc âm.",
                        Data = false
                    };
                }

                db.tbl_ThamGiaDuAns.InsertOnSubmit(newRecord);
                db.SubmitChanges();

                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Success,
                    ErrDesc = "Thêm thông tin nhân viên dự án thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Error,
                    ErrDesc = $"Lỗi khi thêm thông tin: {ex.Message}",
                    Data = false
                };
            }
        }

        public FunctionResult<bool> Edit(tbl_ThamGiaDuAn updatedRecord)
        {
            try
            {
                var record = db.tbl_ThamGiaDuAns.SingleOrDefault(t => t.ma_du_an == updatedRecord.ma_du_an && t.ma_nhan_vien == updatedRecord.ma_nhan_vien);

                if (record == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Thông tin nhân viên dự án không tồn tại.",
                        Data = false
                    };
                }

                // Cập nhật thông tin
                record.ma_nhan_vien = updatedRecord.ma_du_an;
                record.ma_nhan_vien = updatedRecord.ma_nhan_vien;
                record.vai_tro = updatedRecord.vai_tro;
                record.ngay_tham_gia = updatedRecord.ngay_tham_gia;
                record.ngay_roi_khoi = updatedRecord.ngay_roi_khoi;

                db.SubmitChanges();

                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Success,
                    ErrDesc = "Cập nhật thông tin thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Error,
                    ErrDesc = $"Lỗi khi cập nhật thông tin: {ex.Message}",
                    Data = false
                };
            }
        }

        public FunctionResult<bool> Delete(int maDuAn, int maNhanVien)
        {
            try
            {
                var record = db.tbl_ThamGiaDuAns.SingleOrDefault(t => t.ma_du_an == maDuAn && t.ma_nhan_vien == maNhanVien);

                if (record == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Thông tin nhân viên dự án không tồn tại.",
                        Data = false
                    };
                }

                db.tbl_ThamGiaDuAns.DeleteOnSubmit(record);
                db.SubmitChanges();

                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Success,
                    ErrDesc = "Xóa thông tin thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Error,
                    ErrDesc = $"Lỗi khi xóa thông tin: {ex.Message}",
                    Data = false
                };
            }
        }
    }
}
