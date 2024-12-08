using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static QLNhanSu.Models.QLDuan;

namespace QLNhanSu.Controllers
{
    internal class DuanController
    {
        private readonly string connectionString = @"Data Source=LAPTOP-5S7618AC\SQLEXPRESS;Initial Catalog=QLNhansu;Integrated Security=True;";

        // Lấy danh sách dự án
        public List<DuAn> GetAllDuAn()
        {
            List<DuAn> list = new List<DuAn>();
            string query = "SELECT * FROM tbl_DuAn";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new DuAn
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Ten = reader["ten"].ToString(),
                            Ma = reader["ma"].ToString(),
                            NgayBatDau = Convert.ToDateTime(reader["ngay_bat_dau"]),
                            NgayKetThuc = Convert.ToDateTime(reader["ngay_ket_thuc"]),
                            TrangThai = reader["trang_thai"].ToString(),
                            MoTa = reader["mo_ta"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
            return list;
        }

        // Thêm dự án
        public bool AddDuAn(DuAn duAn)
        {
            string query = "INSERT INTO tbl_DuAn (ten, ma, ngay_bat_dau, ngay_ket_thuc, trang_thai, mo_ta) " +
                           "VALUES (@ten, @ma, @ngayBatDau, @ngayKetThuc, @trangThai, @moTa)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ten", duAn.Ten ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ma", duAn.Ma ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ngayBatDau", duAn.NgayBatDau);
                    cmd.Parameters.AddWithValue("@ngayKetThuc", duAn.NgayKetThuc);
                    cmd.Parameters.AddWithValue("@trangThai", duAn.TrangThai ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@moTa", duAn.MoTa ?? (object)DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dự án: " + ex.Message);
                    return false;
                }
            }
        }


        // Xóa dự án
        public bool DeleteDuAn(int id)
        {
            string query = "DELETE FROM tbl_DuAn WHERE ID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dự án: " + ex.Message);
                    return false;
                }
            }
        }

        // Sửa dự án
        public bool UpdateDuAn(DuAn duAn)
        {
            string query = "UPDATE tbl_DuAn " +
                           "SET ten = @ten, ma = @ma, ngay_bat_dau = @ngayBatDau, " +
                           "ngay_ket_thuc = @ngayKetThuc, trang_thai = @trangThai, mo_ta = @moTa " +
                           "WHERE ID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Thêm các tham số
                    cmd.Parameters.AddWithValue("@ten", duAn.Ten ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ma", duAn.Ma ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ngayBatDau", duAn.NgayBatDau);
                    cmd.Parameters.AddWithValue("@ngayKetThuc", duAn.NgayKetThuc);
                    cmd.Parameters.AddWithValue("@trangThai", duAn.TrangThai ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@moTa", duAn.MoTa ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", duAn.ID);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dự án: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
