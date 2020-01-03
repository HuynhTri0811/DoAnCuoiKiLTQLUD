namespace GUI
{
    partial class HocSinhGUI
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
            this.lbXinChao = new System.Windows.Forms.Label();
            this.lbTenHocSinh = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.tctrHocSinh = new System.Windows.Forms.TabControl();
            this.tpThongTinCaNhan = new System.Windows.Forms.TabPage();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaHocSinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpLichSuThi = new System.Windows.Forms.TabPage();
            this.tpThi = new System.Windows.Forms.TabPage();
            this.btnThi = new System.Windows.Forms.Button();
            this.btnThiThu = new System.Windows.Forms.Button();
            this.tctrHocSinh.SuspendLayout();
            this.tpThongTinCaNhan.SuspendLayout();
            this.tpThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbXinChao
            // 
            this.lbXinChao.AutoSize = true;
            this.lbXinChao.Location = new System.Drawing.Point(12, 9);
            this.lbXinChao.Name = "lbXinChao";
            this.lbXinChao.Size = new System.Drawing.Size(52, 13);
            this.lbXinChao.TabIndex = 0;
            this.lbXinChao.Text = "Xin chào:";
            // 
            // lbTenHocSinh
            // 
            this.lbTenHocSinh.AutoSize = true;
            this.lbTenHocSinh.Location = new System.Drawing.Point(70, 9);
            this.lbTenHocSinh.Name = "lbTenHocSinh";
            this.lbTenHocSinh.Size = new System.Drawing.Size(67, 13);
            this.lbTenHocSinh.TabIndex = 1;
            this.lbTenHocSinh.Text = "TenHocSinh";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(513, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // tctrHocSinh
            // 
            this.tctrHocSinh.Controls.Add(this.tpThongTinCaNhan);
            this.tctrHocSinh.Controls.Add(this.tpLichSuThi);
            this.tctrHocSinh.Controls.Add(this.tpThi);
            this.tctrHocSinh.Location = new System.Drawing.Point(15, 41);
            this.tctrHocSinh.Name = "tctrHocSinh";
            this.tctrHocSinh.SelectedIndex = 0;
            this.tctrHocSinh.Size = new System.Drawing.Size(573, 266);
            this.tctrHocSinh.TabIndex = 4;
            // 
            // tpThongTinCaNhan
            // 
            this.tpThongTinCaNhan.Controls.Add(this.btnSuaThongTin);
            this.tpThongTinCaNhan.Controls.Add(this.lbMaLop);
            this.tpThongTinCaNhan.Controls.Add(this.label8);
            this.tpThongTinCaNhan.Controls.Add(this.lbDiaChi);
            this.tpThongTinCaNhan.Controls.Add(this.label6);
            this.tpThongTinCaNhan.Controls.Add(this.lbNgaySinh);
            this.tpThongTinCaNhan.Controls.Add(this.label4);
            this.tpThongTinCaNhan.Controls.Add(this.lbMaHocSinh);
            this.tpThongTinCaNhan.Controls.Add(this.label1);
            this.tpThongTinCaNhan.Location = new System.Drawing.Point(4, 22);
            this.tpThongTinCaNhan.Name = "tpThongTinCaNhan";
            this.tpThongTinCaNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongTinCaNhan.Size = new System.Drawing.Size(565, 240);
            this.tpThongTinCaNhan.TabIndex = 0;
            this.tpThongTinCaNhan.Text = "Thông tin cá nhân";
            this.tpThongTinCaNhan.UseVisualStyleBackColor = true;
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Location = new System.Drawing.Point(10, 129);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(129, 23);
            this.btnSuaThongTin.TabIndex = 8;
            this.btnSuaThongTin.Text = "Sửa thông tin";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(76, 93);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(40, 13);
            this.lbMaLop.TabIndex = 7;
            this.lbMaLop.Text = "MaLop";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã lớp:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(76, 63);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(38, 13);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "DiaChi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa chỉ:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(76, 33);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(53, 13);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "NgaySinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh:";
            // 
            // lbMaHocSinh
            // 
            this.lbMaHocSinh.AutoSize = true;
            this.lbMaHocSinh.Location = new System.Drawing.Point(76, 7);
            this.lbMaHocSinh.Name = "lbMaHocSinh";
            this.lbMaHocSinh.Size = new System.Drawing.Size(63, 13);
            this.lbMaHocSinh.TabIndex = 1;
            this.lbMaHocSinh.Text = "MaHocSinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học sinh:";
            // 
            // tpLichSuThi
            // 
            this.tpLichSuThi.Location = new System.Drawing.Point(4, 22);
            this.tpLichSuThi.Name = "tpLichSuThi";
            this.tpLichSuThi.Padding = new System.Windows.Forms.Padding(3);
            this.tpLichSuThi.Size = new System.Drawing.Size(565, 240);
            this.tpLichSuThi.TabIndex = 1;
            this.tpLichSuThi.Text = "Lịch sử thi";
            this.tpLichSuThi.UseVisualStyleBackColor = true;
            // 
            // tpThi
            // 
            this.tpThi.Controls.Add(this.btnThi);
            this.tpThi.Controls.Add(this.btnThiThu);
            this.tpThi.Location = new System.Drawing.Point(4, 22);
            this.tpThi.Name = "tpThi";
            this.tpThi.Padding = new System.Windows.Forms.Padding(3);
            this.tpThi.Size = new System.Drawing.Size(565, 240);
            this.tpThi.TabIndex = 2;
            this.tpThi.Text = "Thi";
            this.tpThi.UseVisualStyleBackColor = true;
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(7, 45);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(75, 23);
            this.btnThi.TabIndex = 1;
            this.btnThi.Text = "Thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // btnThiThu
            // 
            this.btnThiThu.Location = new System.Drawing.Point(7, 7);
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.Size = new System.Drawing.Size(75, 23);
            this.btnThiThu.TabIndex = 0;
            this.btnThiThu.Text = "Thi thử";
            this.btnThiThu.UseVisualStyleBackColor = true;
            this.btnThiThu.Click += new System.EventHandler(this.btnThiThu_Click);
            // 
            // HocSinhGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 319);
            this.Controls.Add(this.tctrHocSinh);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lbTenHocSinh);
            this.Controls.Add(this.lbXinChao);
            this.Name = "HocSinhGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HocSinhGUI";
            this.Load += new System.EventHandler(this.HocSinhGUI_Load);
            this.tctrHocSinh.ResumeLayout(false);
            this.tpThongTinCaNhan.ResumeLayout(false);
            this.tpThongTinCaNhan.PerformLayout();
            this.tpThi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbXinChao;
        private System.Windows.Forms.Label lbTenHocSinh;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.TabControl tctrHocSinh;
        private System.Windows.Forms.TabPage tpThongTinCaNhan;
        private System.Windows.Forms.TabPage tpLichSuThi;
        private System.Windows.Forms.TabPage tpThi;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaHocSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Button btnThiThu;
    }
}