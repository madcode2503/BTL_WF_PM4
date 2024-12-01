using QlNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QlNhanSu.Controllers
{
    internal class PhongBanController
    {
        private readonly QLNhanSuDataContext db = new QLNhanSuDataContext();

        public FunctionResult<List<PhongBan>> GetAllPhongBan()
        {
            try
            {
                var phongBans = db.PhongBans.ToList();
                return new FunctionResult<List<PhongBan>>
                {
                    ErrCode = phongBans.Any() ? EnumErrCode.Success : EnumErrCode.Empty,
                    ErrDesc = phongBans.Any() ? "Lấy danh sách phòng ban thành công." : "Không có dữ liệu phòng ban.",
                    Data = phongBans.Any() ? phongBans : null
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<List<PhongBan>>
                {
                    ErrCode = EnumErrCode.Error,
                    ErrDesc = $"Lỗi khi lấy dữ liệu: {ex.Message}",
                    Data = null
                };
            }
        }

        public FunctionResult<bool> AddPhongBan(PhongBan newPhongBan)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(newPhongBan.MaPhongBan) || string.IsNullOrWhiteSpace(newPhongBan.TenPhongBan))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrCode.Error,
                        ErrDesc = "Mã và tên phòng ban không được để trống.",
                        Data = false
                    };
                }

                if (db.PhongBans.Any(pb => pb.MaPhongBan == newPhongBan.MaPhongBan))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrCode.Error,
                        ErrDesc = "Mã phòng ban đã tồn tại.",
                        Data = false
                    };
                }
                if (db.PhongBans.Any(pb => pb.TenPhongBan == newPhongBan.TenPhongBan))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrCode.Error,
                        ErrDesc = "Tên phòng ban đã tồn tại.",
                        Data = false
                    };
                }

                db.PhongBans.InsertOnSubmit(newPhongBan);
                db.SubmitChanges();


                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrCode.Success,
                    ErrDesc = "Thêm phòng ban thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrCode.Error,
                    ErrDesc = $"Lỗi khi thêm phòng ban: {ex.Message}",
                    Data = false
                };
            }
        }

        public FunctionResult<bool> EditPhongBan(PhongBan updatedPhongBan)
        {
            try
            {
                var phongBan = db.PhongBans.SingleOrDefault(pb => pb.Id == updatedPhongBan.Id);

                if (phongBan == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrCode.Error,
                        ErrDesc = "Phòng ban không tồn tại.",
                        Data = false
                    };
                }

                // Kiểm tra xem mã phòng ban mới có bị trùng với mã phòng ban khác không (ngoại trừ chính nó)
                if (db.PhongBans.Any(pb => pb.MaPhongBan == updatedPhongBan.MaPhongBan && pb.Id != updatedPhongBan.Id))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrCode.Error,
                        ErrDesc = "Mã phòng ban đã tồn tại.",
                        Data = false
                    };
                }

                // Kiểm tra xem tên phòng ban mới có bị trùng với tên phòng ban khác không (ngoại trừ chính nó)
                if (db.PhongBans.Any(pb => pb.TenPhongBan == updatedPhongBan.TenPhongBan && pb.Id != updatedPhongBan.Id))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrCode.Error,
                        ErrDesc = "Tên phòng ban đã tồn tại.",
                        Data = false
                    };
                }

                // Cập nhật thông tin phòng ban
                phongBan.TenPhongBan = updatedPhongBan.TenPhongBan;
                phongBan.MaPhongBan = updatedPhongBan.MaPhongBan;
                db.SubmitChanges();

                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrCode.Success,
                    ErrDesc = "Sửa phòng ban thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrCode.Error,
                    ErrDesc = $"Lỗi khi sửa phòng ban: {ex.Message}",
                    Data = false
                };
            }
        }

        public FunctionResult<bool> DeletePhongBan(int id)
        {
            try
            {
                var phongBan = db.PhongBans.SingleOrDefault(pb => pb.Id == id);

                if (phongBan == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrCode.Error,
                        ErrDesc = "Phòng ban không tồn tại.",
                        Data = false
                    };
                }

                db.PhongBans.DeleteOnSubmit(phongBan);
                db.SubmitChanges();

                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrCode.Success,
                    ErrDesc = "Xóa phòng ban thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrCode.Error,
                    ErrDesc = $"Lỗi khi xóa phòng ban: {ex.Message}",
                    Data = false
                };
            }
        }
    }
}
