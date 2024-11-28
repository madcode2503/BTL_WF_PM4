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
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.quảnLýNhânSựToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChứcVụToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripQLNS = new System.Windows.Forms.MenuStrip();
            this.lblTenChucVu = new System.Windows.Forms.Label();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlCRUD.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.menuStripQLNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.txtID);
            this.pnlCRUD.Controls.Add(this.lbl_ID);
            this.pnlCRUD.Controls.Add(this.btnDelete);
            this.pnlCRUD.Controls.Add(this.btnEdit);
            this.pnlCRUD.Controls.Add(this.btnAdd);
            this.pnlCRUD.Controls.Add(this.txtLuongCoBan);
            this.pnlCRUD.Controls.Add(this.txtTenChucVu);
            this.pnlCRUD.Controls.Add(this.lblLuongCoBan);
            this.pnlCRUD.Controls.Add(this.lblTenChucVu);
            this.pnlCRUD.Controls.Add(this.lbl_Title);
            this.pnlCRUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCRUD.Location = new System.Drawing.Point(0, 24);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(278, 437);
            this.pnlCRUD.TabIndex = 7;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvChucVu);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(278, 24);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(506, 437);
            this.pnlData.TabIndex = 8;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(54, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(181, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Quản Lý Chức Vụ";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // quảnLýNhânSựToolStripMenuItem1
            // 
            this.quảnLýNhânSựToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýChứcVụToolStripMenuItem2});
            this.quảnLýNhânSựToolStripMenuItem1.Name = "quảnLýNhânSựToolStripMenuItem1";
            this.quảnLýNhânSựToolStripMenuItem1.Size = new System.Drawing.Size(110, 20);
            this.quảnLýNhânSựToolStripMenuItem1.Text = "Quản Lý Nhân Sự";
            this.quảnLýNhânSựToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýChứcVụToolStripMenuItem1_Click);
            // 
            // quảnLýChứcVụToolStripMenuItem2
            // 
            this.quảnLýChứcVụToolStripMenuItem2.Name = "quảnLýChứcVụToolStripMenuItem2";
            this.quảnLýChứcVụToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.quảnLýChứcVụToolStripMenuItem2.Text = "Quản Lý Chức Vụ";
            // 
            // menuStripQLNS
            // 
            this.menuStripQLNS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânSựToolStripMenuItem1});
            this.menuStripQLNS.Location = new System.Drawing.Point(0, 0);
            this.menuStripQLNS.Name = "menuStripQLNS";
            this.menuStripQLNS.Size = new System.Drawing.Size(784, 24);
            this.menuStripQLNS.TabIndex = 6;
            this.menuStripQLNS.Text = "menuStrip1";
            // 
            // lblTenChucVu
            // 
            this.lblTenChucVu.AutoSize = true;
            this.lblTenChucVu.Location = new System.Drawing.Point(19, 150);
            this.lblTenChucVu.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.lblTenChucVu.Name = "lblTenChucVu";
            this.lblTenChucVu.Size = new System.Drawing.Size(70, 13);
            this.lblTenChucVu.TabIndex = 1;
            this.lblTenChucVu.Text = "Tên Chức Vụ";
            this.lblTenChucVu.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(19, 195);
            this.lblLuongCoBan.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(75, 13);
            this.lblLuongCoBan.TabIndex = 2;
            this.lblLuongCoBan.Text = "Lương Cơ Bản";
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenChucVu.Location = new System.Drawing.Point(114, 147);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(154, 20);
            this.txtTenChucVu.TabIndex = 3;
            this.txtTenChucVu.TextChanged += new System.EventHandler(this.txtTenChucVu_TextChanged);
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuongCoBan.Location = new System.Drawing.Point(111, 188);
            this.txtLuongCoBan.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(154, 20);
            this.txtLuongCoBan.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(170, 277);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(170, 323);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Location = new System.Drawing.Point(0, 0);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.Size = new System.Drawing.Size(506, 437);
            this.dgvChucVu.TabIndex = 0;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(22, 105);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 8;
            this.lbl_ID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(114, 105);
            this.txtID.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 20);
            this.txtID.TabIndex = 9;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // Form_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.menuStripQLNS);
            this.MainMenuStrip = this.menuStripQLNS;
            this.Name = "Form_ChucVu";
            this.Text = "Form_ChucVu";
            this.pnlCRUD.ResumeLayout(false);
            this.pnlCRUD.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.menuStripQLNS.ResumeLayout(false);
            this.menuStripQLNS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânSựToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChứcVụToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStripQLNS;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.Label lblTenChucVu;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl_ID;
    }
}