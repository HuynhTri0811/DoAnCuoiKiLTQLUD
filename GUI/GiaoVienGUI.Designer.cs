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
            this.tabThongKeCauHoi = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioCauD = new System.Windows.Forms.RadioButton();
            this.radioCauC = new System.Windows.Forms.RadioButton();
            this.radioCauB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioCauA = new System.Windows.Forms.RadioButton();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyetCauHoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCauHoi = new System.Windows.Forms.Button();
            this.listCauHoi = new System.Windows.Forms.ListView();
            this.UpdateDapAn = new System.Windows.Forms.Button();
            this.comboxDoKho = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxKhoi = new System.Windows.Forms.ComboBox();
            this.tabQuanLyKiThiAll.SuspendLayout();
            this.tabThongKeCauHoi.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // tabThongKeCauHoi
            // 
            this.tabThongKeCauHoi.Controls.Add(this.groupBox3);
            this.tabThongKeCauHoi.Controls.Add(this.groupBox2);
            this.tabThongKeCauHoi.Location = new System.Drawing.Point(4, 22);
            this.tabThongKeCauHoi.Name = "tabThongKeCauHoi";
            this.tabThongKeCauHoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongKeCauHoi.Size = new System.Drawing.Size(975, 491);
            this.tabThongKeCauHoi.TabIndex = 2;
            this.tabThongKeCauHoi.Text = "Thống kê câu hỏi ";
            this.tabThongKeCauHoi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxKhoi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboxDoKho);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtCauHoi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(957, 233);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết câu hỏi";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UpdateDapAn);
            this.groupBox4.Controls.Add(this.radioCauD);
            this.groupBox4.Controls.Add(this.radioCauC);
            this.groupBox4.Controls.Add(this.radioCauB);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.radioCauA);
            this.groupBox4.Location = new System.Drawing.Point(77, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 117);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Câu trả lời";
            // 
            // radioCauD
            // 
            this.radioCauD.AutoSize = true;
            this.radioCauD.Enabled = false;
            this.radioCauD.Location = new System.Drawing.Point(32, 94);
            this.radioCauD.Name = "radioCauD";
            this.radioCauD.Size = new System.Drawing.Size(46, 17);
            this.radioCauD.TabIndex = 10;
            this.radioCauD.TabStop = true;
            this.radioCauD.Text = "Text";
            this.radioCauD.UseVisualStyleBackColor = true;
            // 
            // radioCauC
            // 
            this.radioCauC.AutoSize = true;
            this.radioCauC.Enabled = false;
            this.radioCauC.Location = new System.Drawing.Point(32, 71);
            this.radioCauC.Name = "radioCauC";
            this.radioCauC.Size = new System.Drawing.Size(46, 17);
            this.radioCauC.TabIndex = 9;
            this.radioCauC.TabStop = true;
            this.radioCauC.Text = "Text";
            this.radioCauC.UseVisualStyleBackColor = true;
            this.radioCauC.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioCauB
            // 
            this.radioCauB.AutoSize = true;
            this.radioCauB.Enabled = false;
            this.radioCauB.Location = new System.Drawing.Point(32, 46);
            this.radioCauB.Name = "radioCauB";
            this.radioCauB.Size = new System.Drawing.Size(46, 17);
            this.radioCauB.TabIndex = 8;
            this.radioCauB.TabStop = true;
            this.radioCauB.Text = "Text";
            this.radioCauB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "D.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "C.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "B.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "A .";
            // 
            // radioCauA
            // 
            this.radioCauA.AutoSize = true;
            this.radioCauA.Enabled = false;
            this.radioCauA.Location = new System.Drawing.Point(32, 25);
            this.radioCauA.Name = "radioCauA";
            this.radioCauA.Size = new System.Drawing.Size(46, 17);
            this.radioCauA.TabIndex = 2;
            this.radioCauA.TabStop = true;
            this.radioCauA.Text = "Text";
            this.radioCauA.UseVisualStyleBackColor = true;
            this.radioCauA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Location = new System.Drawing.Point(77, 20);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(409, 73);
            this.txtCauHoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Câu hỏi :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listCauHoi);
            this.groupBox2.Controls.Add(this.btnDuyetCauHoi);
            this.groupBox2.Location = new System.Drawing.Point(6, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(963, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách câu hỏi";
            // 
            // btnDuyetCauHoi
            // 
            this.btnDuyetCauHoi.Location = new System.Drawing.Point(824, 26);
            this.btnDuyetCauHoi.Name = "btnDuyetCauHoi";
            this.btnDuyetCauHoi.Size = new System.Drawing.Size(133, 29);
            this.btnDuyetCauHoi.TabIndex = 1;
            this.btnDuyetCauHoi.Text = "Duyệt câu hỏi thêm vào";
            this.btnDuyetCauHoi.UseVisualStyleBackColor = true;
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
            // listCauHoi
            // 
            this.listCauHoi.HideSelection = false;
            this.listCauHoi.Location = new System.Drawing.Point(6, 26);
            this.listCauHoi.Name = "listCauHoi";
            this.listCauHoi.Size = new System.Drawing.Size(716, 211);
            this.listCauHoi.TabIndex = 2;
            this.listCauHoi.UseCompatibleStateImageBehavior = false;
            this.listCauHoi.SelectedIndexChanged += new System.EventHandler(this.listCauHoi_SelectedIndexChanged);
            this.listCauHoi.Click += new System.EventHandler(this.listCauHoi_Click);
            // 
            // UpdateDapAn
            // 
            this.UpdateDapAn.Location = new System.Drawing.Point(224, 50);
            this.UpdateDapAn.Name = "UpdateDapAn";
            this.UpdateDapAn.Size = new System.Drawing.Size(161, 23);
            this.UpdateDapAn.TabIndex = 11;
            this.UpdateDapAn.Text = "Chỉnh sửa đáp án";
            this.UpdateDapAn.UseVisualStyleBackColor = true;
            // 
            // comboxDoKho
            // 
            this.comboxDoKho.FormattingEnabled = true;
            this.comboxDoKho.Location = new System.Drawing.Point(616, 20);
            this.comboxDoKho.Name = "comboxDoKho";
            this.comboxDoKho.Size = new System.Drawing.Size(121, 21);
            this.comboxDoKho.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Độ khó :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Khối :";
            // 
            // comboBoxKhoi
            // 
            this.comboBoxKhoi.FormattingEnabled = true;
            this.comboBoxKhoi.Location = new System.Drawing.Point(618, 56);
            this.comboBoxKhoi.Name = "comboBoxKhoi";
            this.comboBoxKhoi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKhoi.TabIndex = 6;
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
            this.tabThongKeCauHoi.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddCauHoi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioCauA;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioCauD;
        private System.Windows.Forms.RadioButton radioCauC;
        private System.Windows.Forms.RadioButton radioCauB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listCauHoi;
        private System.Windows.Forms.Button UpdateDapAn;
        private System.Windows.Forms.ComboBox comboBoxKhoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboxDoKho;
    }
}