using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhanSu.Controllers;
using QLNhanSu.Models;

namespace QLNhanSu.Views.ComponentQLNhanVien
{
    public partial class FormUpdate : Form
    {
        private tbl_NhanVien nhanVien;

        public FormUpdate(tbl_NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            txt_Ho.Text = nhanVien.ho;
            txt_Ten.Text = nhanVien.ten;
            txt_Sodienthoai.Text = nhanVien.so_dien_thoai;
            txt_Cccd.Text = nhanVien.cccd;
            text_Email.Text = nhanVien.email;
            cb_Diachi.Text = nhanVien.dia_chi;
            date_Ngaysinh.Value = nhanVien.ngay_sinh.Value;
            cb_Gioitinh.Text = nhanVien.gioi_tinh == true ? "Nam" : "Nữ";
            cb_Gioitinh.Items.Add("Nam");
            cb_Gioitinh.Items.Add("Nữ");
            cb_Tenchucvu.DataSource = QLNhanVien.GetTenChucVu();
            cb_Tenchucvu.SelectedItem = nhanVien.ten_chuc_vu;
            cb_Tenphong.DataSource = QLNhanVien.GetTenPhong();

            cb_Tenphong.SelectedItem = nhanVien.ten_phong_ban;
            string[] tinhThanh = new string[]
           {
                "Hà Nội", "Hồ Chí Minh", "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn",
                "Bến Tre", "Bình Dương", "Bình Định", "Bình Phước", "Bình Thuận", "Cà Mau",
                "Cao Bằng", "Cần Thơ", "Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai",
                "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Tĩnh", "Hải Dương", "Hải Phòng",
                "Hậu Giang", "Hòa Bình", "Hồ Chí Minh", "Hưng Yên", "Khánh Hòa", "Kiên Giang",
                "Kon Tum", "Lai Châu", "Lào Cai", "Lạng Sơn", "Lâm Đồng", "Long An", "Nam Định",
                "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam",
                "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình",
                "Thái Nguyên", "Thanh Hóa", "Thừa Thiên - Huế", "Tiền Giang", "TP. Hồ Chí Minh",
                "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái"
           };
            cb_Diachi.Items.AddRange(tinhThanh);
            cb_Diachi.SelectedIndex = 0;
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            if (CheckInvalid.Checkvalid(text_Email, txt_Ho, txt_Ten, txt_Sodienthoai, txt_Cccd))
            {
                bool gioiTinh = cb_Gioitinh.SelectedItem != null && cb_Gioitinh.SelectedItem.ToString() == "Nam";
                string tenPhong = cb_Tenphong.SelectedItem.ToString();
                string tenChucVu = cb_Tenchucvu.SelectedItem.ToString();
                string diaChi = cb_Diachi.SelectedItem.ToString(); // Địa chỉ (tỉnh thành)
                string email = text_Email.Text;
                string ho = txt_Ho.Text;
                string ten = txt_Ten.Text;
                string cccd = txt_Cccd.Text;
                string sodienthoai = txt_Sodienthoai.Text;
                DateTime ngaysinh = date_Ngaysinh.Value;
                QLNhanVien.UpdateNhanVien(nhanVien.id, ho, ten, ngaysinh, gioiTinh, email, sodienthoai, cccd, tenPhong, diaChi, tenChucVu);
            }
        }
    }
}
