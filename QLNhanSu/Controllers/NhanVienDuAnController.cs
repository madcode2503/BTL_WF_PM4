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
                // Kiểm tra dữ liệu đầu vào
                if (newRecord == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Dữ liệu không hợp lệ.",
                        Data = false
                    };
                }

                if (newRecord.ma_du_an <= 0)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Mã dự án không được để trống hoặc âm.",
                        Data = false
                    };
                }

                if (newRecord.ma_nhan_vien <= 0)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Mã nhân viên không được để trống hoặc âm.",
                        Data = false
                    };
                }

                // Kiểm tra dự án
                var duAn = db.tbl_DuAns.SingleOrDefault(t => t.id == newRecord.ma_du_an);
                if (duAn == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Dự án không tồn tại.",
                        Data = false
                    };
                }

                if (duAn.ngay_ket_thuc != null && duAn.ngay_ket_thuc <= DateTime.Now)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Dự án đã kết thúc và không thể thêm nhân viên.",
                        Data = false
                    };
                }

                // Kiểm tra trùng lặp bản ghi
                var existingRecord = db.tbl_ThamGiaDuAns
                    .SingleOrDefault(t => t.ma_du_an == newRecord.ma_du_an && t.ma_nhan_vien == newRecord.ma_nhan_vien);

                if (existingRecord != null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Nhân viên đã tham gia dự án này. Không thể thêm trùng lặp.",
                        Data = false
                    };
                }

                // Thêm thông tin tham gia dự án
                db.tbl_ThamGiaDuAns.InsertOnSubmit(newRecord);
                db.SubmitChanges();

                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Success,
                    ErrDesc = "Thêm thông tin nhân viên vào dự án thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
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
                // Kiểm tra đầu vào
                if (updatedRecord == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Dữ liệu không hợp lệ.",
                        Data = false
                    };
                }

                // Tìm bản ghi cần cập nhật
                var record = db.tbl_ThamGiaDuAns
                    .SingleOrDefault(t => t.ma_du_an == updatedRecord.ma_du_an && t.ma_nhan_vien == updatedRecord.ma_nhan_vien);

                if (record == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Thông tin nhân viên dự án không tồn tại.",
                        Data = false
                    };
                }

                // Kiểm tra ngày rời khỏi (nếu có) phải sau ngày tham gia
                if (updatedRecord.ngay_roi_khoi != null && updatedRecord.ngay_roi_khoi < updatedRecord.ngay_tham_gia)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Ngày rời khỏi không thể trước ngày tham gia.",
                        Data = false
                    };
                }

                // Cập nhật thông tin
                record.vai_tro = updatedRecord.vai_tro;
                record.ngay_tham_gia = updatedRecord.ngay_tham_gia;
                record.ngay_roi_khoi = updatedRecord.ngay_roi_khoi;

                // Lưu thay đổi
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
                // Xử lý ngoại lệ và trả về lỗi
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
