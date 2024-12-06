namespace QLNhanSu.Views
{
    partial class Form_ChucVu
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
            this.splitContainerChucVu = new System.Windows.Forms.SplitContainer();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.lbl_LuongCoBan = new System.Windows.Forms.Label();
            this.lbl_TenChucVu = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChucVu)).BeginInit();
            this.splitContainerChucVu.Panel1.SuspendLayout();
            this.splitContainerChucVu.Panel2.SuspendLayout();
            this.splitContainerChucVu.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerChucVu
            // 
            this.splitContainerChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerChucVu.Location = new System.Drawing.Point(0, 0);
            this.splitContainerChucVu.Name = "splitContainerChucVu";
            // 
            // splitContainerChucVu.Panel1
            // 
            this.splitContainerChucVu.Panel1.Controls.Add(this.pnlCRUD);
            // 
            // splitContainerChucVu.Panel2
            // 
            this.splitContainerChucVu.Panel2.Controls.Add(this.pnlData);
            this.splitContainerChucVu.Size = new System.Drawing.Size(800, 450);
            this.splitContainerChucVu.SplitterDistance = 266;
            this.splitContainerChucVu.TabIndex = 0;
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.btnDelete);
            this.pnlCRUD.Controls.Add(this.btnEdit);
            this.pnlCRUD.Controls.Add(this.btnAdd);
            this.pnlCRUD.Controls.Add(this.txtLuongCoBan);
            this.pnlCRUD.Controls.Add(this.txtTenChucVu);
            this.pnlCRUD.Controls.Add(this.lbl_LuongCoBan);
            this.pnlCRUD.Controls.Add(this.lbl_TenChucVu);
            this.pnlCRUD.Controls.Add(this.lbl_Title);
            this.pnlCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCRUD.Location = new System.Drawing.Point(0, 0);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(266, 450);
            this.pnlCRUD.TabIndex = 0;
            this.pnlCRUD.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCRUD_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(178, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(178, 355);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(178, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuongCoBan.Location = new System.Drawing.Point(139, 167);
            this.txtLuongCoBan.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(100, 20);
            this.txtLuongCoBan.TabIndex = 4;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenChucVu.Location = new System.Drawing.Point(139, 117);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(100, 20);
            this.txtTenChucVu.TabIndex = 3;
            // 
            // lbl_LuongCoBan
            // 
            this.lbl_LuongCoBan.AutoSize = true;
            this.lbl_LuongCoBan.Location = new System.Drawing.Point(36, 167);
            this.lbl_LuongCoBan.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lbl_LuongCoBan.Name = "lbl_LuongCoBan";
            this.lbl_LuongCoBan.Size = new System.Drawing.Size(75, 13);
            this.lbl_LuongCoBan.TabIndex = 2;
            this.lbl_LuongCoBan.Text = "Lương Cơ Bản";
            // 
            // lbl_TenChucVu
            // 
            this.lbl_TenChucVu.AutoSize = true;
            this.lbl_TenChucVu.Location = new System.Drawing.Point(33, 117);
            this.lbl_TenChucVu.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.lbl_TenChucVu.Name = "lbl_TenChucVu";
            this.lbl_TenChucVu.Size = new System.Drawing.Size(70, 13);
            this.lbl_TenChucVu.TabIndex = 1;
            this.lbl_TenChucVu.Text = "Tên Chức Vụ";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(46, 35);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(175, 24);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Quản Lý Chức Vụ";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvChucVu);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(530, 450);
            this.pnlData.TabIndex = 0;
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucVu.Location = new System.Drawing.Point(0, 0);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.Size = new System.Drawing.Size(530, 450);
            this.dgvChucVu.TabIndex = 0;
            // 
            // Form_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerChucVu);
            this.Name = "Form_ChucVu";
            this.Text = "Form_ChucVu";
            this.splitContainerChucVu.Panel1.ResumeLayout(false);
            this.splitContainerChucVu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChucVu)).EndInit();
            this.splitContainerChucVu.ResumeLayout(false);
            this.pnlCRUD.ResumeLayout(false);
            this.pnlCRUD.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerChucVu;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.Label lbl_LuongCoBan;
        private System.Windows.Forms.Label lbl_TenChucVu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtTenChucVu;
    }
}