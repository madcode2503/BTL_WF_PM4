using System;

namespace QLNhanSu.Views
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qLNhanSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItemHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLLuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLPhongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLDựÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PanelNhanVien = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.qLNhanVienDuAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLNhanSuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1069, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qLNhanSuToolStripMenuItem
            // 
            this.qLNhanSuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItemHereToolStripMenuItem,
            this.qLNhanVienToolStripMenuItem,
            this.qLLuongToolStripMenuItem,
            this.qLPhongBanToolStripMenuItem,
            this.qLDựÁnToolStripMenuItem,
            this.qLNhanVienDuAnToolStripMenuItem});
            this.qLNhanSuToolStripMenuItem.Name = "qLNhanSuToolStripMenuItem";
            this.qLNhanSuToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.qLNhanSuToolStripMenuItem.Text = "QLNhanSu";
            // 
            // addMenuItemHereToolStripMenuItem
            // 
            this.addMenuItemHereToolStripMenuItem.Name = "addMenuItemHereToolStripMenuItem";
            this.addMenuItemHereToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.addMenuItemHereToolStripMenuItem.Text = "Add Menu item here";
            // 
            // qLNhanVienToolStripMenuItem
            // 
            this.qLNhanVienToolStripMenuItem.Name = "qLNhanVienToolStripMenuItem";
            this.qLNhanVienToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.qLNhanVienToolStripMenuItem.Text = "QLNhanVien";
            this.qLNhanVienToolStripMenuItem.Click += new System.EventHandler(this.qLNhanVienToolStripMenuItem_Click);
            // 
            // qLLuongToolStripMenuItem
            // 
            this.qLLuongToolStripMenuItem.Name = "qLLuongToolStripMenuItem";
            this.qLLuongToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.qLLuongToolStripMenuItem.Text = "QL Lương";
            this.qLLuongToolStripMenuItem.Click += new System.EventHandler(this.qLLươngToolStripMenuItem_Click);
            // 
            // qLPhongBanToolStripMenuItem
            // 
            this.qLPhongBanToolStripMenuItem.Name = "qLPhongBanToolStripMenuItem";
            this.qLPhongBanToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.qLPhongBanToolStripMenuItem.Text = "QL Phòng ban";
            this.qLPhongBanToolStripMenuItem.Click += new System.EventHandler(this.qLPhòngBanToolStripMenuItem_Click);
            // 
            // qLDựÁnToolStripMenuItem
            // 
            this.qLDựÁnToolStripMenuItem.Name = "qLDựÁnToolStripMenuItem";
            this.qLDựÁnToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.qLDựÁnToolStripMenuItem.Text = "QL Dự Án";
            this.qLDựÁnToolStripMenuItem.Click += new System.EventHandler(this.qLDựÁnToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PanelNhanVien
            // 
            this.PanelNhanVien.Location = new System.Drawing.Point(0, 29);
            this.PanelNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelNhanVien.Name = "PanelNhanVien";
            this.PanelNhanVien.Size = new System.Drawing.Size(1069, 442);
            this.PanelNhanVien.TabIndex = 1;
            this.PanelNhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qLNhanVienDuAnToolStripMenuItem
            // 
            this.qLNhanVienDuAnToolStripMenuItem.Name = "qLNhanVienDuAnToolStripMenuItem";
            this.qLNhanVienDuAnToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.qLNhanVienDuAnToolStripMenuItem.Text = "QL NhanVienDuAn";
            this.qLNhanVienDuAnToolStripMenuItem.Click += new System.EventHandler(this.qLNhanVienDuAnToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PanelNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void qLDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLDuan frmDuAn = new frm_QLDuan();
            frmDuAn.Show();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qLNhanSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuItemHereToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qLNhanVienToolStripMenuItem;
        private System.Windows.Forms.Panel PanelNhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem qLLuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLPhongBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLDựÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLNhanVienDuAnToolStripMenuItem;
    }
}