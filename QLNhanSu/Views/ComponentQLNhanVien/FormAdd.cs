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

namespace QLNhanSu.Views.ComponentQLNhanVien
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();

            // Cố định dữ liệu cho ComboBox
            cb_Gioitinh.Items.Add("Nam");
            cb_Gioitinh.Items.Add("Nữ");
            cb_Gioitinh.SelectedIndex = 0;  // Mặc định chọn Nam
            var tenPhongList =QLNhanVien.GetTenPhong();
            if (tenPhongList != null && tenPhongList.Any())
            {
                cb_Tenphong.DataSource = tenPhongList;
            }

            // Lấy dữ liệu tên chức vụ
            var tenChucVuList = QLNhanVien.GetTenChucVu();
            if (tenChucVuList != null && tenChucVuList.Any())
            {
                cb_Tenchucvu.DataSource = tenChucVuList;
            }
        

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
            cb_Diachi.SelectedIndex = 0;  // Mặc định chọn Hà Nội
        }

        private void txt_Them_Click(object sender, EventArgs e)
        {

           if(CheckInvalid.Checkvalid(text_Email, txt_Ho, txt_Ten, txt_Sodienthoai, txt_Cccd))
            {
                bool gioiTinh = cb_Gioitinh.SelectedItem.ToString() == "Nam"; // true nếu Nam, false nếu Nữ
                string tenPhong = cb_Tenphong.SelectedItem.ToString();
                string tenChucVu = cb_Tenchucvu.SelectedItem.ToString();
                string diaChi = cb_Diachi.SelectedItem.ToString(); // Địa chỉ (tỉnh thành)
                string email = text_Email.Text;
                string ho = txt_Ho.Text;
                string ten = txt_Ten.Text;
                string cccd = txt_Cccd.Text;
                string sodienthoai = txt_Sodienthoai.Text;
                DateTime ngaysinh = date_Ngaysinh.Value;
                QLNhanVien.AddNhanVien(ho, ten, ngaysinh, gioiTinh, email, sodienthoai, cccd, tenPhong, diaChi, tenChucVu);
            }
           

        }

        // Các sự kiện khác của form
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_Gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Maphong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Machucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
