namespace GUI.GiaoVienGUII
{
    partial class DanhSachDeTrongKiThi
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
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewDanhSachDeTheoMaKhoi = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKiThi = new System.Windows.Forms.TextBox();
            this.btnLoadDanhSachCauHoi = new System.Windows.Forms.Button();
            this.listViewDanhSachHocSinh = new System.Windows.Forms.ListView();
            this.btnAddHocSInh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(174, 61);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(178, 21);
            this.cbKhoi.TabIndex = 0;
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khối :";
            // 
            // listViewDanhSachDeTheoMaKhoi
            // 
            this.listViewDanhSachDeTheoMaKhoi.HideSelection = false;
            this.listViewDanhSachDeTheoMaKhoi.Location = new System.Drawing.Point(12, 133);
            this.listViewDanhSachDeTheoMaKhoi.Name = "listViewDanhSachDeTheoMaKhoi";
            this.listViewDanhSachDeTheoMaKhoi.Size = new System.Drawing.Size(340, 228);
            this.listViewDanhSachDeTheoMaKhoi.TabIndex = 2;
            this.listViewDanhSachDeTheoMaKhoi.UseCompatibleStateImageBehavior = false;
            this.listViewDanhSachDeTheoMaKhoi.SelectedIndexChanged += new System.EventHandler(this.listViewDanhSachDeTheoMaKhoi_SelectedIndexChanged);
            this.listViewDanhSachDeTheoMaKhoi.Click += new System.EventHandler(this.listViewDanhSachDeTheoMaKhoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MaKiThi :";
            // 
            // txtMaKiThi
            // 
            this.txtMaKiThi.Enabled = false;
            this.txtMaKiThi.Location = new System.Drawing.Point(175, 32);
            this.txtMaKiThi.Name = "txtMaKiThi";
            this.txtMaKiThi.Size = new System.Drawing.Size(177, 20);
            this.txtMaKiThi.TabIndex = 4;
            // 
            // btnLoadDanhSachCauHoi
            // 
            this.btnLoadDanhSachCauHoi.Enabled = false;
            this.btnLoadDanhSachCauHoi.Location = new System.Drawing.Point(367, 182);
            this.btnLoadDanhSachCauHoi.Name = "btnLoadDanhSachCauHoi";
            this.btnLoadDanhSachCauHoi.Size = new System.Drawing.Size(84, 23);
            this.btnLoadDanhSachCauHoi.TabIndex = 6;
            this.btnLoadDanhSachCauHoi.Text = "Chọn";
            this.btnLoadDanhSachCauHoi.UseVisualStyleBackColor = true;
            // 
            // listViewDanhSachHocSinh
            // 
            this.listViewDanhSachHocSinh.CheckBoxes = true;
            this.listViewDanhSachHocSinh.HideSelection = false;
            this.listViewDanhSachHocSinh.Location = new System.Drawing.Point(457, 133);
            this.listViewDanhSachHocSinh.Name = "listViewDanhSachHocSinh";
            this.listViewDanhSachHocSinh.Size = new System.Drawing.Size(333, 344);
            this.listViewDanhSachHocSinh.TabIndex = 7;
            this.listViewDanhSachHocSinh.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddHocSInh
            // 
            this.btnAddHocSInh.Location = new System.Drawing.Point(353, 494);
            this.btnAddHocSInh.Name = "btnAddHocSInh";
            this.btnAddHocSInh.Size = new System.Drawing.Size(98, 23);
            this.btnAddHocSInh.TabIndex = 8;
            this.btnAddHocSInh.Text = "Thêm vào kì thi";
            this.btnAddHocSInh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh sách mã đề";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Danh sách học sinh";
            // 
            // DanhSachDeTrongKiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddHocSInh);
            this.Controls.Add(this.listViewDanhSachHocSinh);
            this.Controls.Add(this.btnLoadDanhSachCauHoi);
            this.Controls.Add(this.txtMaKiThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewDanhSachDeTheoMaKhoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKhoi);
            this.Name = "DanhSachDeTrongKiThi";
            this.Text = "Danh Sach Đề Thi Trong Kì Thi";
            this.Load += new System.EventHandler(this.DanhSachDeTrongKiThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewDanhSachDeTheoMaKhoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKiThi;
        private System.Windows.Forms.Button btnLoadDanhSachCauHoi;
        private System.Windows.Forms.ListView listViewDanhSachHocSinh;
        private System.Windows.Forms.Button btnAddHocSInh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}