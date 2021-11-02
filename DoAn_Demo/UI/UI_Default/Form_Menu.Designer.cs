
namespace DoAn_Demo
{
    partial class Form_Menu
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
            this.ToolStripMenuItemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQLHS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTTGV = new System.Windows.Forms.ToolStripMenuItem();
            this.QLLHMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQLTTGV = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTK = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHSG = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHSK = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHSTB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHSLB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHSTH = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tltipTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHome,
            this.chứcNăngToolStripMenuItem,
            this.tltipTaiKhoan,
            this.ToolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemHome
            // 
            this.ToolStripMenuItemHome.Name = "ToolStripMenuItemHome";
            this.ToolStripMenuItemHome.Size = new System.Drawing.Size(64, 24);
            this.ToolStripMenuItemHome.Text = "Home";
            this.ToolStripMenuItemHome.Click += new System.EventHandler(this.ToolStripMenuItemHome_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemQLHS,
            this.ToolStripMenuItemTTGV,
            this.QLLHMenu,
            this.ToolStripMenuItemQLTTGV,
            this.ToolStripMenuItemTK,
            this.ToolStripMenuItemLogout});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // ToolStripMenuItemQLHS
            // 
            this.ToolStripMenuItemQLHS.Name = "ToolStripMenuItemQLHS";
            this.ToolStripMenuItemQLHS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ToolStripMenuItemQLHS.Size = new System.Drawing.Size(309, 26);
            this.ToolStripMenuItemQLHS.Text = "Quản Lý Học Sinh";
            this.ToolStripMenuItemQLHS.Click += new System.EventHandler(this.ToolStripMenuItemQLHS_Click);
            // 
            // ToolStripMenuItemTTGV
            // 
            this.ToolStripMenuItemTTGV.Name = "ToolStripMenuItemTTGV";
            this.ToolStripMenuItemTTGV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.ToolStripMenuItemTTGV.Size = new System.Drawing.Size(309, 26);
            this.ToolStripMenuItemTTGV.Text = "Xem Thông Tin Giao Viên";
            this.ToolStripMenuItemTTGV.Click += new System.EventHandler(this.ToolStripMenuItemTTGV_Click);
            // 
            // QLLHMenu
            // 
            this.QLLHMenu.Name = "QLLHMenu";
            this.QLLHMenu.Size = new System.Drawing.Size(309, 26);
            this.QLLHMenu.Text = "Quản lý lớp học";
            this.QLLHMenu.Click += new System.EventHandler(this.QLLHMenu_Click);
            // 
            // ToolStripMenuItemQLTTGV
            // 
            this.ToolStripMenuItemQLTTGV.Name = "ToolStripMenuItemQLTTGV";
            this.ToolStripMenuItemQLTTGV.Size = new System.Drawing.Size(309, 26);
            this.ToolStripMenuItemQLTTGV.Text = "Quản lý thông tin giảng viên";
            this.ToolStripMenuItemQLTTGV.Click += new System.EventHandler(this.quảnLýThôngTinGiảngViênToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemTK
            // 
            this.ToolStripMenuItemTK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHSG,
            this.ToolStripMenuItemHSK,
            this.ToolStripMenuItemHSTB,
            this.ToolStripMenuItemHSLB,
            this.ToolStripMenuItemHSTH});
            this.ToolStripMenuItemTK.Name = "ToolStripMenuItemTK";
            this.ToolStripMenuItemTK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ToolStripMenuItemTK.Size = new System.Drawing.Size(309, 26);
            this.ToolStripMenuItemTK.Text = "Thống Kê Trong Năm";
            // 
            // ToolStripMenuItemHSG
            // 
            this.ToolStripMenuItemHSG.Name = "ToolStripMenuItemHSG";
            this.ToolStripMenuItemHSG.Size = new System.Drawing.Size(225, 26);
            this.ToolStripMenuItemHSG.Text = "Học Sinh Gioi";
            this.ToolStripMenuItemHSG.Click += new System.EventHandler(this.ToolStripMenuItemHSG_Click);
            // 
            // ToolStripMenuItemHSK
            // 
            this.ToolStripMenuItemHSK.Name = "ToolStripMenuItemHSK";
            this.ToolStripMenuItemHSK.Size = new System.Drawing.Size(225, 26);
            this.ToolStripMenuItemHSK.Text = "Học Sinh Khá";
            this.ToolStripMenuItemHSK.Click += new System.EventHandler(this.ToolStripMenuItemHSK_Click);
            // 
            // ToolStripMenuItemHSTB
            // 
            this.ToolStripMenuItemHSTB.Name = "ToolStripMenuItemHSTB";
            this.ToolStripMenuItemHSTB.Size = new System.Drawing.Size(225, 26);
            this.ToolStripMenuItemHSTB.Text = "Học Sinh Trung Bình";
            this.ToolStripMenuItemHSTB.Click += new System.EventHandler(this.ToolStripMenuItemHSTB_Click);
            // 
            // ToolStripMenuItemHSLB
            // 
            this.ToolStripMenuItemHSLB.Name = "ToolStripMenuItemHSLB";
            this.ToolStripMenuItemHSLB.Size = new System.Drawing.Size(225, 26);
            this.ToolStripMenuItemHSLB.Text = "Học Sinh Lưu Ban";
            this.ToolStripMenuItemHSLB.Click += new System.EventHandler(this.ToolStripMenuItemHSLB_Click);
            // 
            // ToolStripMenuItemHSTH
            // 
            this.ToolStripMenuItemHSTH.Name = "ToolStripMenuItemHSTH";
            this.ToolStripMenuItemHSTH.Size = new System.Drawing.Size(225, 26);
            this.ToolStripMenuItemHSTH.Text = "Học Sinh Thôi Học";
            this.ToolStripMenuItemHSTH.Click += new System.EventHandler(this.ToolStripMenuItemHSTH_Click);
            // 
            // ToolStripMenuItemLogout
            // 
            this.ToolStripMenuItemLogout.Name = "ToolStripMenuItemLogout";
            this.ToolStripMenuItemLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ToolStripMenuItemLogout.Size = new System.Drawing.Size(309, 26);
            this.ToolStripMenuItemLogout.Text = "Đăng Xuất";
            this.ToolStripMenuItemLogout.Click += new System.EventHandler(this.ToolStripMenuItemLogout_Click);
            // 
            // tltipTaiKhoan
            // 
            this.tltipTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem});
            this.tltipTaiKhoan.Name = "tltipTaiKhoan";
            this.tltipTaiKhoan.Size = new System.Drawing.Size(87, 24);
            this.tltipTaiKhoan.Text = "Tài Khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(55, 24);
            this.ToolStripMenuItemHelp.Text = "Help";
            this.ToolStripMenuItemHelp.Click += new System.EventHandler(this.ToolStripMenuItemHelp_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.Location = new System.Drawing.Point(5, 32);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1522, 649);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Menu";
            this.Text = "Quản Lý Học Sinh Tiểu Học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Menu_FormClosed_1);
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form_Menu_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQLHS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTTGV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTK;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLogout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHSG;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHome;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHSK;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHSTB;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHSLB;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHSTH;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQLTTGV;
        private System.Windows.Forms.ToolStripMenuItem QLLHMenu;
        private System.Windows.Forms.ToolStripMenuItem tltipTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}