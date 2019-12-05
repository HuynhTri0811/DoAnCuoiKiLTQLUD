namespace GUI
{
    partial class GiaoVienGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNameGiaoVien = new System.Windows.Forms.Label();
            this.btnUpdateGiaoVien = new System.Windows.Forms.Button();
            this.tabQuanLyKiThiAll = new System.Windows.Forms.TabControl();
            this.tabThongKeHocSinh = new System.Windows.Forms.TabPage();
            this.tabQuanLyKiThi = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCauHoi = new System.Windows.Forms.Button();
            this.tabThongKeCauHoi = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyetCauHoi = new System.Windows.Forms.Button();
            this.tabQuanLyKiThiAll.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabThongKeCauHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1016, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào :";
            // 
            // lbNameGiaoVien
            // 
            this.lbNameGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameGiaoVien.Location = new System.Drawing.Point(1082, 21);
            this.lbNameGiaoVien.Name = "lbNameGiaoVien";
            this.lbNameGiaoVien.Size = new System.Drawing.Size(100, 23);
            this.lbNameGiaoVien.TabIndex = 1;
            this.lbNameGiaoVien.Text = "None";
            // 
            // btnUpdateGiaoVien
            // 
            this.btnUpdateGiaoVien.Location = new System.Drawing.Point(18, 31);
            this.btnUpdateGiaoVien.Name = "btnUpdateGiaoVien";
            this.btnUpdateGiaoVien.Size = new System.Drawing.Size(168, 23);
            this.btnUpdateGiaoVien.TabIndex = 2;
            this.btnUpdateGiaoVien.Text = "Cật nhật thông tin";
            this.btnUpdateGiaoVien.UseVisualStyleBackColor = true;
            this.btnUpdateGiaoVien.Click += new System.EventHandler(this.btnUpdateGiaoVien_Click);
            // 
            // tabQuanLyKiThiAll
            // 
            this.tabQuanLyKiThiAll.Controls.Add(this.tabThongKeHocSinh);
            this.tabQuanLyKiThiAll.Controls.Add(this.tabQuanLyKiThi);
            this.tabQuanLyKiThiAll.Controls.Add(this.tabThongKeCauHoi);
            this.tabQuanLyKiThiAll.Location = new System.Drawing.Point(12, 12);
            this.tabQuanLyKiThiAll.Name = "tabQuanLyKiThiAll";
            this.tabQuanLyKiThiAll.SelectedIndex = 0;
            this.tabQuanLyKiThiAll.Size = new System.Drawing.Size(983, 517);
            this.tabQuanLyKiThiAll.TabIndex = 3;
            // 
            // tabThongKeHocSinh
            // 
            this.tabThongKeHocSinh.Location = new System.Drawing.Point(4, 22);
            this.tabThongKeHocSinh.Name = "tabThongKeHocSinh";
            this.tabThongKeHocSinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongKeHocSinh.Size = new System.Drawing.Size(975, 491);
            this.tabThongKeHocSinh.TabIndex = 0;
            this.tabThongKeHocSinh.Text = "Thống kê của học sinh";
            this.tabThongKeHocSinh.UseVisualStyleBackColor = true;
            // 
            // tabQuanLyKiThi
            // 
            this.tabQuanLyKiThi.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyKiThi.Name = "tabQuanLyKiThi";
            this.tabQuanLyKiThi.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyKiThi.Size = new System.Drawing.Size(975, 491);
            this.tabQuanLyKiThi.TabIndex = 1;
            this.tabQuanLyKiThi.Text = "Quản Lý kì THi";
            this.tabQuanLyKiThi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCauHoi);
            this.groupBox1.Controls.Add(this.btnUpdateGiaoVien);
            this.groupBox1.Location = new System.Drawing.Point(1001, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác của giáo viên";
            // 
            // btnAddCauHoi
            // 
            this.btnAddCauHoi.Location = new System.Drawing.Point(18, 72);
            this.btnAddCauHoi.Name = "btnAddCauHoi";
            this.btnAddCauHoi.Size = new System.Drawing.Size(168, 23);
            this.btnAddCauHoi.TabIndex = 0;
            this.btnAddCauHoi.Text = "Thêm câu hỏi";
            this.btnAddCauHoi.UseVisualStyleBackColor = true;
            // 
            // tabThongKeCauHoi
            // 
            this.tabThongKeCauHoi.Controls.Add(this.groupBox2);
            this.tabThongKeCauHoi.Location = new System.Drawing.Point(4, 22);
            this.tabThongKeCauHoi.Name = "tabThongKeCauHoi";
            this.tabThongKeCauHoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongKeCauHoi.Size = new System.Drawing.Size(975, 491);
            this.tabThongKeCauHoi.TabIndex = 2;
            this.tabThongKeCauHoi.Text = "Thống kê câu hỏi ";
            this.tabThongKeCauHoi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyetCauHoi);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(6, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(963, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các câu hỏi của học sinh đóng góp";
            // 
            // btnDuyetCauHoi
            // 
            this.btnDuyetCauHoi.Location = new System.Drawing.Point(824, 30);
            this.btnDuyetCauHoi.Name = "btnDuyetCauHoi";
            this.btnDuyetCauHoi.Size = new System.Drawing.Size(133, 29);
            this.btnDuyetCauHoi.TabIndex = 1;
            this.btnDuyetCauHoi.Text = "Duyệt câu hỏi thêm vào";
            this.btnDuyetCauHoi.UseVisualStyleBackColor = true;
            // 
            // GiaoVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabQuanLyKiThiAll);
            this.Controls.Add(this.lbNameGiaoVien);
            this.Controls.Add(this.label1);
            this.Name = "GiaoVienGUI";
            this.Text = "GiaoVien";
            this.Load += new System.EventHandler(this.GiaoVienGUI_Load);
            this.tabQuanLyKiThiAll.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabThongKeCauHoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNameGiaoVien;
        private System.Windows.Forms.Button btnUpdateGiaoVien;
        private System.Windows.Forms.TabControl tabQuanLyKiThiAll;
        private System.Windows.Forms.TabPage tabThongKeHocSinh;
        private System.Windows.Forms.TabPage tabQuanLyKiThi;
        private System.Windows.Forms.TabPage tabThongKeCauHoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuyetCauHoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddCauHoi;
    }
}