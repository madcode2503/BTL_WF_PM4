using System.Windows.Forms;
using System;
using QLNhanSu.Controllers;
using System.Drawing;

namespace QLNhanSu.Views
{
    partial class frm_QLDuan
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txt_TenDuan;
        private TextBox txt_MaDuan;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpNgayKetThuc;
        private ComboBox comboBoxStatus;
        private RichTextBox txt_Mota;
        private Button btn_Them;
        private Button btn_Xoa;
        private Button btn_Sua;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txt_TenDuan = new System.Windows.Forms.TextBox();
            this.txt_MaDuan = new System.Windows.Forms.TextBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.txt_Mota = new System.Windows.Forms.RichTextBox();
            this.tbl_duan_gridview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_duan_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenDuan
            // 
            this.txt_TenDuan.Location = new System.Drawing.Point(114, 23);
            this.txt_TenDuan.Name = "txt_TenDuan";
            this.txt_TenDuan.Size = new System.Drawing.Size(164, 26);
            this.txt_TenDuan.TabIndex = 0;
            // 
            // txt_MaDuan
            // 
            this.txt_MaDuan.Location = new System.Drawing.Point(114, 63);
            this.txt_MaDuan.Name = "txt_MaDuan";
            this.txt_MaDuan.Size = new System.Drawing.Size(164, 26);
            this.txt_MaDuan.TabIndex = 1;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(114, 109);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(164, 26);
            this.dtpNgayBatDau.TabIndex = 2;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(114, 153);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(164, 26);
            this.dtpNgayKetThuc.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Kết thúc"});
            this.comboBoxStatus.Location = new System.Drawing.Point(114, 185);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(164, 28);
            this.comboBoxStatus.TabIndex = 4;
            // 
            // txt_Mota
            // 
            this.txt_Mota.Location = new System.Drawing.Point(114, 227);
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(164, 72);
            this.txt_Mota.TabIndex = 5;
            this.txt_Mota.Text = "";
            // 
            // tbl_duan_gridview
            // 
            this.tbl_duan_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_duan_gridview.Location = new System.Drawing.Point(311, 12);
            this.tbl_duan_gridview.Name = "tbl_duan_gridview";
            this.tbl_duan_gridview.RowHeadersWidth = 51;
            this.tbl_duan_gridview.Size = new System.Drawing.Size(936, 370);
            this.tbl_duan_gridview.TabIndex = 9;
            this.tbl_duan_gridview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbl_duan_gridview_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Dự án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày Bắt Đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày Kết Thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Trạng Thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mô Tả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên Dự án";
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::QLNhanSu.Properties.Resources.icons8_add_16;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(12, 323);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(90, 23);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::QLNhanSu.Properties.Resources.icons8_delete_16;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(213, 323);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(92, 23);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::QLNhanSu.Properties.Resources.icons8_edit_16;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(114, 323);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 23);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // frm_QLDuan
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 406);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenDuan);
            this.Controls.Add(this.txt_MaDuan);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.txt_Mota);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.tbl_duan_gridview);
            this.Name = "frm_QLDuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dự Án";
            this.Load += new System.EventHandler(this.frm_QLDuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_duan_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tbl_duan_gridview;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;

        
        public Size ClientSize { get; private set; }
    }
}
