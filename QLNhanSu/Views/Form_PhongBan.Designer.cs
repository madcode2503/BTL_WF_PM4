namespace QLNhanSu.Views
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
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPhongBan
            // 
            this.DataGridViewPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPhongBan.Location = new System.Drawing.Point(552, 42);
            this.DataGridViewPhongBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewPhongBan.Name = "DataGridViewPhongBan";
            this.DataGridViewPhongBan.RowHeadersWidth = 51;
            this.DataGridViewPhongBan.Size = new System.Drawing.Size(471, 316);
            this.DataGridViewPhongBan.TabIndex = 0;
            this.DataGridViewPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPhongBan_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng ban";
            // 
            // txt_tenphongban
            // 
            this.txt_tenphongban.Location = new System.Drawing.Point(226, 79);
            this.txt_tenphongban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenphongban.Name = "txt_tenphongban";
            this.txt_tenphongban.Size = new System.Drawing.Size(236, 22);
            this.txt_tenphongban.TabIndex = 2;
            // 
            // txt_maphongban
            // 
            this.txt_maphongban.Location = new System.Drawing.Point(226, 169);
            this.txt_maphongban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_maphongban.Name = "txt_maphongban";
            this.txt_maphongban.Size = new System.Drawing.Size(236, 22);
            this.txt_maphongban.TabIndex = 2;
            // 
            // BtnXoa
            // 
            this.BtnXoa.Image = global::QLNhanSu.Properties.Resources.icons8_delete_16;
            this.BtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXoa.Location = new System.Drawing.Point(381, 270);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(125, 28);
            this.BtnXoa.TabIndex = 3;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Image = global::QLNhanSu.Properties.Resources.icons8_edit_16;
            this.BtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSua.Location = new System.Drawing.Point(203, 270);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(125, 28);
            this.BtnSua.TabIndex = 3;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Image = global::QLNhanSu.Properties.Resources.icons8_add_16;
            this.BtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThem.Location = new System.Drawing.Point(28, 270);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(125, 28);
            this.BtnThem.TabIndex = 3;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // Form_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 394);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.txt_maphongban);
            this.Controls.Add(this.txt_tenphongban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewPhongBan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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