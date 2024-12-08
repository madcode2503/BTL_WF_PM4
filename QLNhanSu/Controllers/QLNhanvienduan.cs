using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QLNhanSu.Models;

namespace QLNhanSu.Controllers
{
    internal class QLNhanvienduan
    {
        private readonly string connectionString = "Data Source=LAPTOP-5S7618AC\\SQLEXPRESS;Trusted_Connection=True;";

        // Lấy tất cả dữ liệu
        public List<Nhanvienduan> GetAll()
        {
            var list = new List<Nhanvienduan>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_ThamGiaDuAn";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Nhanvienduan
                    {
                       
                        MaDuAn = Convert.ToInt32(reader["ma_du_an"]),
                        MaNhanVien = Convert.ToInt32(reader["ma_nhan_vien"]),
                        VaiTro = reader["vai_tro"].ToString(),
                        NgayThamGia = Convert.ToDateTime(reader["ngay_tham_gia"]),
                        NgayKetThuc = reader["ngay_roi_khoi"] == DBNull.Value
        ? (DateTime?)null
        : Convert.ToDateTime(reader["ngay_roi_khoi"])
                    });

                }
            }
            return list;
        }

        // Thêm mới
        public bool Add(Nhanvienduan nv)
        {
            string query = "INSERT INTO tbl_ThamGiaDuAn (MaDuAn, MaNhanVien, VaiTro, NgayThamGia, NgayKetThuc) " +
                           "VALUES (@MaDuAn, @MaNhanVien, @VaiTro, @NgayThamGia, @NgayKetThuc)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDuAn", nv.MaDuAn);
                cmd.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
                cmd.Parameters.AddWithValue("@VaiTro", nv.VaiTro);
                cmd.Parameters.AddWithValue("@NgayThamGia", nv.NgayThamGia);
                cmd.Parameters.AddWithValue("@NgayKetThuc", nv.NgayKetThuc);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        // Cập nhật
        public void Update(Nhanvienduan nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tbl_ThamGiaDuAn SET ma_du_an = @MaDuAn, ma_nhan_vien = @MaNhanVien, vai_tro = @VaiTro, ngay_tham_gia = @NgayThamGia, ngay_roi_khoi = @NgayKetThuc WHERE id = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
        
                cmd.Parameters.AddWithValue("@MaDuAn", nv.MaDuAn);
                cmd.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
                cmd.Parameters.AddWithValue("@VaiTro", nv.VaiTro);
                cmd.Parameters.AddWithValue("@NgayThamGia", nv.NgayThamGia);
                cmd.Parameters.AddWithValue("@NgayKetThuc", nv.NgayKetThuc ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        // Xóa
        public bool Delete(int maDuAn, int maNhanVien)
        {
            string query = "DELETE FROM tbl_ThamGiaDuAn WHERE MaDuAn = @MaDuAn AND MaNhanVien = @MaNhanVien";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
