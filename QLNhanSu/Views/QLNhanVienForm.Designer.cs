namespace QLNhanSu.Views
{
    partial class QLNhanVienForm
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
            this.tbl_DuLieu_QLNhanVien = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DuLieu_QLNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_DuLieu_QLNhanVien
            // 
            this.tbl_DuLieu_QLNhanVien.AllowUserToAddRows = false;
            this.tbl_DuLieu_QLNhanVien.AllowUserToDeleteRows = false;
            this.tbl_DuLieu_QLNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_DuLieu_QLNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_DuLieu_QLNhanVien.BackgroundColor = System.Drawing.Color.Honeydew;
            this.tbl_DuLieu_QLNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_DuLieu_QLNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_DuLieu_QLNhanVien.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbl_DuLieu_QLNhanVien.Location = new System.Drawing.Point(-2, 83);
            this.tbl_DuLieu_QLNhanVien.Name = "tbl_DuLieu_QLNhanVien";
            this.tbl_DuLieu_QLNhanVien.ReadOnly = true;
            this.tbl_DuLieu_QLNhanVien.RowHeadersWidth = 62;
            this.tbl_DuLieu_QLNhanVien.RowTemplate.Height = 28;
            this.tbl_DuLieu_QLNhanVien.Size = new System.Drawing.Size(1178, 413);
            this.tbl_DuLieu_QLNhanVien.TabIndex = 0;
            this.tbl_DuLieu_QLNhanVien.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbl_DuLieu_QLNhanVien_RowHeaderMouseClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(139, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(114, 38);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(259, 12);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(99, 38);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(381, 13);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(90, 37);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(571, 12);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(304, 37);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // QLNhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 497);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tbl_DuLieu_QLNhanVien);
            this.Name = "QLNhanVienForm";
            this.Text = "QLNhanVienForm";
            this.Load += new System.EventHandler(this.QLNhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DuLieu_QLNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbl_DuLieu_QLNhanVien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_Search;
    }
}