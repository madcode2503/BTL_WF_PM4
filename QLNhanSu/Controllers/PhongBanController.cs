using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Controllers
{
    internal class PhongBanController
    {
        private readonly QLNhanSuDataContext db = new QLNhanSuDataContext();

        public FunctionResult<List<tbl_PhongBan>> GetAllPhongBan()
        {
            try
            {
                var phongBans = db.tbl_PhongBans.ToList();
                return new FunctionResult<List<tbl_PhongBan>>
                {
                    ErrCode = phongBans.Any() ? EnumErrcode.Success : EnumErrcode.Empty,
                    ErrDesc = phongBans.Any() ? "Lấy danh sách phòng ban thành công." : "Không có dữ liệu phòng ban.",
                    Data = phongBans.Any() ? phongBans : null
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<List<tbl_PhongBan>>
                {
                    ErrCode = EnumErrcode.Error,
                    ErrDesc = $"Lỗi khi lấy dữ liệu: {ex.Message}",
                    Data = null
                };
            }
        }

        public FunctionResult<bool> AddPhongBan(tbl_PhongBan newPhongBan)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(newPhongBan.ma) || string.IsNullOrWhiteSpace(newPhongBan.ten))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Mã và tên phòng ban không được để trống.",
                        Data = false
                    };
                }

                if (db.tbl_PhongBans.Any(pb => pb.ma == newPhongBan.ma))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Mã phòng ban đã tồn tại.",
                        Data = false
                    };
                }
                if (db.tbl_PhongBans.Any(pb => pb.ten == newPhongBan.ten))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Tên phòng ban đã tồn tại.",
                        Data = false
                    };
                }

                db.tbl_PhongBans.InsertOnSubmit(newPhongBan);
                db.SubmitChanges();


                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Success,
                    ErrDesc = "Thêm phòng ban thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Error,
                    ErrDesc = $"Lỗi khi thêm phòng ban: {ex.Message}",
                    Data = false
                };
            }
        }

        public FunctionResult<bool> EditPhongBan(tbl_PhongBan updatedPhongBan)
        {
            try
            {
                var phongBan = db.tbl_PhongBans.SingleOrDefault(pb => pb.id == updatedPhongBan.id);

                if (phongBan == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Phòng ban không tồn tại.",
                        Data = false
                    };
                }

                // Kiểm tra xem mã phòng ban mới có bị trùng với mã phòng ban khác không (ngoại trừ chính nó)
                if (db.tbl_PhongBans.Any(pb => pb.ma == updatedPhongBan.ma && pb.id != updatedPhongBan.id))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Mã phòng ban đã tồn tại.",
                        Data = false
                    };
                }

                // Kiểm tra xem tên phòng ban mới có bị trùng với tên phòng ban khác không (ngoại trừ chính nó)
                if (db.tbl_PhongBans.Any(pb => pb.ten == updatedPhongBan.ten && pb.id != updatedPhongBan.id))
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Tên phòng ban đã tồn tại.",
                        Data = false
                    };
                }

                // Cập nhật thông tin phòng ban
                phongBan.ten = updatedPhongBan.ten;
                phongBan.ma = updatedPhongBan.ma;
                db.SubmitChanges();

                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Success,
                    ErrDesc = "Sửa phòng ban thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Error,
                    ErrDesc = $"Lỗi khi sửa phòng ban: {ex.Message}",
                    Data = false
                };
            }
        }

        public FunctionResult<bool> DeletePhongBan(int id)
        {
            try
            {
                var phongBan = db.tbl_PhongBans.SingleOrDefault(pb => pb.id == id);

                if (phongBan == null)
                {
                    return new FunctionResult<bool>
                    {
                        ErrCode = EnumErrcode.Error,
                        ErrDesc = "Phòng ban không tồn tại.",
                        Data = false
                    };
                }

                db.tbl_PhongBans.DeleteOnSubmit(phongBan);
                db.SubmitChanges();

                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Success,
                    ErrDesc = "Xóa phòng ban thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrcode.Error,
                    ErrDesc = $"Lỗi khi xóa phòng ban: {ex.Message}",
                    Data = false
                };
            }
        }
    }
}
