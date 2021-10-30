namespace KhachSan_GIU
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKeDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mndulieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsaolu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnkhoiphuc = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpdateTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPhong
            // 
            this.flpPhong.Location = new System.Drawing.Point(49, 198);
            this.flpPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(1133, 398);
            this.flpPhong.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1231, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1296, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLoaiPhong,
            this.mnPhong,
            this.mnKhachHang,
            this.mnNhanVien,
            this.mnHoaDon,
            this.mnThongKeDoanhThu,
            this.mnTaiKhoan,
            this.mndulieu});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnLoaiPhong
            // 
            this.mnLoaiPhong.Name = "mnLoaiPhong";
            this.mnLoaiPhong.Size = new System.Drawing.Size(315, 26);
            this.mnLoaiPhong.Text = "Loại phòng";
            this.mnLoaiPhong.Click += new System.EventHandler(this.mnLoaiPhong_Click);
            // 
            // mnPhong
            // 
            this.mnPhong.Name = "mnPhong";
            this.mnPhong.Size = new System.Drawing.Size(315, 26);
            this.mnPhong.Text = "Phòng";
            this.mnPhong.Click += new System.EventHandler(this.mnPhong_Click);
            // 
            // mnKhachHang
            // 
            this.mnKhachHang.Name = "mnKhachHang";
            this.mnKhachHang.Size = new System.Drawing.Size(315, 26);
            this.mnKhachHang.Text = "Khách hàng";
            this.mnKhachHang.Click += new System.EventHandler(this.mnKhachHang_Click);
            // 
            // mnNhanVien
            // 
            this.mnNhanVien.Name = "mnNhanVien";
            this.mnNhanVien.Size = new System.Drawing.Size(315, 26);
            this.mnNhanVien.Text = "Nhân viên";
            this.mnNhanVien.Click += new System.EventHandler(this.mnNhanVien_Click);
            // 
            // mnHoaDon
            // 
            this.mnHoaDon.Name = "mnHoaDon";
            this.mnHoaDon.Size = new System.Drawing.Size(315, 26);
            this.mnHoaDon.Text = "Hóa đơn";
            this.mnHoaDon.Click += new System.EventHandler(this.mnHoaDon_Click);
            // 
            // mnThongKeDoanhThu
            // 
            this.mnThongKeDoanhThu.Name = "mnThongKeDoanhThu";
            this.mnThongKeDoanhThu.Size = new System.Drawing.Size(315, 26);
            this.mnThongKeDoanhThu.Text = "Thống kê doanh thu hàng tháng";
            this.mnThongKeDoanhThu.Click += new System.EventHandler(this.mnThongKeDoanhThu_Click);
            // 
            // mnTaiKhoan
            // 
            this.mnTaiKhoan.Name = "mnTaiKhoan";
            this.mnTaiKhoan.Size = new System.Drawing.Size(315, 26);
            this.mnTaiKhoan.Text = "Tài khoản";
            this.mnTaiKhoan.Click += new System.EventHandler(this.mnTaiKhoan_Click);
            // 
            // mndulieu
            // 
            this.mndulieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsaolu,
            this.mnkhoiphuc});
            this.mndulieu.Name = "mndulieu";
            this.mndulieu.Size = new System.Drawing.Size(315, 26);
            this.mndulieu.Text = "Dữ liệu";
            // 
            // mnsaolu
            // 
            this.mnsaolu.Name = "mnsaolu";
            this.mnsaolu.Size = new System.Drawing.Size(158, 26);
            this.mnsaolu.Text = "Sao lưu";
            this.mnsaolu.Click += new System.EventHandler(this.mnsaolu_Click);
            // 
            // mnkhoiphuc
            // 
            this.mnkhoiphuc.Name = "mnkhoiphuc";
            this.mnkhoiphuc.Size = new System.Drawing.Size(158, 26);
            this.mnkhoiphuc.Text = "Khôi phục";
            this.mnkhoiphuc.Click += new System.EventHandler(this.mnkhoiphuc_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUpdateTaiKhoan,
            this.mnLogOut});
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(166, 25);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // mnUpdateTaiKhoan
            // 
            this.mnUpdateTaiKhoan.Name = "mnUpdateTaiKhoan";
            this.mnUpdateTaiKhoan.Size = new System.Drawing.Size(180, 26);
            this.mnUpdateTaiKhoan.Text = "Đổi mật khẩu";
            this.mnUpdateTaiKhoan.Click += new System.EventHandler(this.mnUpdateTaiKhoan_Click);
            // 
            // mnLogOut
            // 
            this.mnLogOut.Name = "mnLogOut";
            this.mnLogOut.Size = new System.Drawing.Size(180, 26);
            this.mnLogOut.Text = "Đăng xuất";
            this.mnLogOut.Click += new System.EventHandler(this.mnLogOut_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 156);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(333, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH SẠN QUỐC HẢI";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flpPhong);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChinh";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem mnPhong;
        private System.Windows.Forms.ToolStripMenuItem mnKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnThongKeDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnUpdateTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnLogOut;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mndulieu;
        private System.Windows.Forms.ToolStripMenuItem mnsaolu;
        private System.Windows.Forms.ToolStripMenuItem mnkhoiphuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}