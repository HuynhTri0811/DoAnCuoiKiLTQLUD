namespace GUI
{
    partial class RegisterForm
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
            this.cbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaHocSinh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbHienMatKhau
            // 
            this.cbHienMatKhau.AutoSize = true;
            this.cbHienMatKhau.Location = new System.Drawing.Point(142, 314);
            this.cbHienMatKhau.Name = "cbHienMatKhau";
            this.cbHienMatKhau.Size = new System.Drawing.Size(95, 17);
            this.cbHienMatKhau.TabIndex = 16;
            this.cbHienMatKhau.Text = "Hiện mât khẩu";
            this.cbHienMatKhau.UseVisualStyleBackColor = true;
            this.cbHienMatKhau.CheckedChanged += new System.EventHandler(this.cbHienMatKhau_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ và tên";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(143, 124);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(172, 20);
            this.tbHoTen.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thông tin đăng ký";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(72, 347);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa chỉ";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(143, 201);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(172, 20);
            this.tbDiaChi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mật khẩu";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(142, 240);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(172, 20);
            this.tbMatKhau.TabIndex = 21;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nhập lại mật khẩu";
            // 
            // tbNhapLaiMatKhau
            // 
            this.tbNhapLaiMatKhau.Location = new System.Drawing.Point(142, 277);
            this.tbNhapLaiMatKhau.Name = "tbNhapLaiMatKhau";
            this.tbNhapLaiMatKhau.Size = new System.Drawing.Size(172, 20);
            this.tbNhapLaiMatKhau.TabIndex = 23;
            this.tbNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(143, 162);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(171, 20);
            this.dtpNgaySinh.TabIndex = 25;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(186, 347);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mã học sinh";
            // 
            // tbMaHocSinh
            // 
            this.tbMaHocSinh.Enabled = false;
            this.tbMaHocSinh.Location = new System.Drawing.Point(143, 88);
            this.tbMaHocSinh.Name = "tbMaHocSinh";
            this.tbMaHocSinh.Size = new System.Drawing.Size(172, 20);
            this.tbMaHocSinh.TabIndex = 27;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMaHocSinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNhapLaiMatKhau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.cbHienMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHienMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNhapLaiMatKhau;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaHocSinh;
    }
}