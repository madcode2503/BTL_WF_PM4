﻿using QLNhanSu.Controllers;
using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Views
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_UserName.Clear();
            txt_Password.Clear();
        }
        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(txt_UserName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Lỗi");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi");
                return false;
            }
            return true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                string tenDangNhap = txt_UserName.Text.Trim();
                string matKhau = txt_Password.Text.Trim();

                DangNhap controller = new DangNhap();
                var result = controller.dangnhap(tenDangNhap, matKhau);

                if (result.ErrCode == EnumErrcode.Success)
                {
                    MessageBox.Show(result.ErrDesc, "Thông báo");
                    FormMain mainForm = new FormMain();
                    this.Hide(); 
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show(result.ErrDesc, "Thông báo");
                }
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}