namespace GUI.Admin
{
    partial class Admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listDanhSachGiaoVien = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTenGiaoVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordGiaoVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailGiaoVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChiGiaoVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDTGiaoVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKhoi = new System.Windows.Forms.TextBox();
            this.btnUpdateGiaoVien = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 520);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(989, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý học sinh";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý giáo viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listDanhSachGiaoVien);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giáo viên";
            // 
            // listDanhSachGiaoVien
            // 
            this.listDanhSachGiaoVien.HideSelection = false;
            this.listDanhSachGiaoVien.Location = new System.Drawing.Point(3, 16);
            this.listDanhSachGiaoVien.Name = "listDanhSachGiaoVien";
            this.listDanhSachGiaoVien.Size = new System.Drawing.Size(375, 476);
            this.listDanhSachGiaoVien.TabIndex = 0;
            this.listDanhSachGiaoVien.UseCompatibleStateImageBehavior = false;
            this.listDanhSachGiaoVien.Click += new System.EventHandler(this.listDanhSachGiaoVien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateGiaoVien);
            this.groupBox2.Controls.Add(this.txtMaKhoi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSDTGiaoVien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDiaChiGiaoVien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEmailGiaoVien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPasswordGiaoVien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHoTenGiaoVien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMaGiaoVien);
            this.groupBox2.Location = new System.Drawing.Point(390, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 484);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Location = new System.Drawing.Point(86, 35);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.ReadOnly = true;
            this.txtMaGiaoVien.Size = new System.Drawing.Size(152, 20);
            this.txtMaGiaoVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã giáo viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // txtHoTenGiaoVien
            // 
            this.txtHoTenGiaoVien.Location = new System.Drawing.Point(86, 66);
            this.txtHoTenGiaoVien.Name = "txtHoTenGiaoVien";
            this.txtHoTenGiaoVien.Size = new System.Drawing.Size(152, 20);
            this.txtHoTenGiaoVien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            // 
            // txtPasswordGiaoVien
            // 
            this.txtPasswordGiaoVien.Location = new System.Drawing.Point(86, 97);
            this.txtPasswordGiaoVien.Name = "txtPasswordGiaoVien";
            this.txtPasswordGiaoVien.Size = new System.Drawing.Size(152, 20);
            this.txtPasswordGiaoVien.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email :";
            // 
            // txtEmailGiaoVien
            // 
            this.txtEmailGiaoVien.Location = new System.Drawing.Point(86, 123);
            this.txtEmailGiaoVien.Name = "txtEmailGiaoVien";
            this.txtEmailGiaoVien.Size = new System.Drawing.Size(152, 20);
            this.txtEmailGiaoVien.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ : ";
            // 
            // txtDiaChiGiaoVien
            // 
            this.txtDiaChiGiaoVien.Location = new System.Drawing.Point(86, 148);
            this.txtDiaChiGiaoVien.Name = "txtDiaChiGiaoVien";
            this.txtDiaChiGiaoVien.Size = new System.Drawing.Size(152, 20);
            this.txtDiaChiGiaoVien.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SDT :";
            // 
            // txtSDTGiaoVien
            // 
            this.txtSDTGiaoVien.Location = new System.Drawing.Point(86, 184);
            this.txtSDTGiaoVien.Name = "txtSDTGiaoVien";
            this.txtSDTGiaoVien.Size = new System.Drawing.Size(152, 20);
            this.txtSDTGiaoVien.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã Khối :";
            // 
            // txtMaKhoi
            // 
            this.txtMaKhoi.Location = new System.Drawing.Point(86, 213);
            this.txtMaKhoi.Name = "txtMaKhoi";
            this.txtMaKhoi.Size = new System.Drawing.Size(152, 20);
            this.txtMaKhoi.TabIndex = 13;
            // 
            // btnUpdateGiaoVien
            // 
            this.btnUpdateGiaoVien.Location = new System.Drawing.Point(86, 251);
            this.btnUpdateGiaoVien.Name = "btnUpdateGiaoVien";
            this.btnUpdateGiaoVien.Size = new System.Drawing.Size(152, 23);
            this.btnUpdateGiaoVien.TabIndex = 1;
            this.btnUpdateGiaoVien.Text = "Cập nhật ";
            this.btnUpdateGiaoVien.UseVisualStyleBackColor = true;
            this.btnUpdateGiaoVien.Click += new System.EventHandler(this.btnUpdateGiaoVien_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 532);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listDanhSachGiaoVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateGiaoVien;
        private System.Windows.Forms.TextBox txtMaKhoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDTGiaoVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChiGiaoVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailGiaoVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordGiaoVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTenGiaoVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
    }
}