using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLNhanSu.Views.ComponentQLNhanVien
{
    internal static class CheckInvalid
    {
        // Phương thức Checkvalid nhận các đối tượng TextBox làm tham số
        public static bool Checkvalid(TextBox text_Email, TextBox txt_Ho, TextBox txt_Ten, TextBox txt_Sodienthoai, TextBox txt_Cccd)
        {
            // Kiểm tra trường email
            if (string.IsNullOrWhiteSpace(text_Email.Text))
            {
                MessageBox.Show("Email không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
                return false;
            }

            // Kiểm tra định dạng email
            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!emailRegex.IsMatch(text_Email.Text))
            {
                MessageBox.Show("Định dạng email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            // Kiểm tra trường họ
            if (string.IsNullOrWhiteSpace(txt_Ho.Text))
            {
                MessageBox.Show("Họ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra trường tên
            if (string.IsNullOrWhiteSpace(txt_Ten.Text))
            {
                MessageBox.Show("Tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra trường số điện thoại
            if (string.IsNullOrWhiteSpace(txt_Sodienthoai.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var phoneRegex = new Regex(@"^0\d{9}$");
            if (!phoneRegex.IsMatch(txt_Sodienthoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra trường CCCD
            if (string.IsNullOrWhiteSpace(txt_Cccd.Text))
            {
                MessageBox.Show("CCCD không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            var cccdRegex = new Regex(@"^\d{12}$");
            if (!cccdRegex.IsMatch(txt_Cccd.Text))
            {
                MessageBox.Show("Định dạng CCCD không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
