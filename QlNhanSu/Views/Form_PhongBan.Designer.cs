﻿namespace QlNhanSu.Views
{
    partial class Form_PhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridViewPhongBan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenphongban = new System.Windows.Forms.TextBox();
            this.txt_maphongban = new System.Windows.Forms.TextBox();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPhongBan
            // 
            this.DataGridViewPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPhongBan.Location = new System.Drawing.Point(333, 44);
            this.DataGridViewPhongBan.Name = "DataGridViewPhongBan";
            this.DataGridViewPhongBan.Size = new System.Drawing.Size(434, 273);
            this.DataGridViewPhongBan.TabIndex = 0;
            this.DataGridViewPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPhongBan_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng ban";
            // 
            // txt_tenphongban
            // 
            this.txt_tenphongban.Location = new System.Drawing.Point(157, 77);
            this.txt_tenphongban.Name = "txt_tenphongban";
            this.txt_tenphongban.Size = new System.Drawing.Size(100, 20);
            this.txt_tenphongban.TabIndex = 2;
            // 
            // txt_maphongban
            // 
            this.txt_maphongban.Location = new System.Drawing.Point(157, 140);
            this.txt_maphongban.Name = "txt_maphongban";
            this.txt_maphongban.Size = new System.Drawing.Size(100, 20);
            this.txt_maphongban.TabIndex = 2;
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(230, 181);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(88, 35);
            this.BtnThem.TabIndex = 3;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(230, 232);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(88, 38);
            this.BtnSua.TabIndex = 3;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(230, 286);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(88, 41);
            this.BtnXoa.TabIndex = 3;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // Form_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.txt_maphongban);
            this.Controls.Add(this.txt_tenphongban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewPhongBan);
            this.Name = "Form_PhongBan";
            this.Text = "Form_PhongBan";
            this.Load += new System.EventHandler(this.Form_PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenphongban;
        private System.Windows.Forms.TextBox txt_maphongban;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
    }
}