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
            this.btnDuyetCauHoi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaCauHoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateCauHoi = new System.Windows.Forms.Button();
            this.comboBoxKhoi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboxDoKho = new System.Windows.Forms.ComboBox();
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
            this.listCauHoi = new System.Windows.Forms.ListView();
            this.btnAddCauHoi = new System.Windows.Forms.Button();
            this.ThongKeKiThi = new System.Windows.Forms.TabPage();
            this.btnAddTDeThi = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUpdateDanhSachCauHoiONDeThi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLoadDanhSachCauHoiONDeThi = new System.Windows.Forms.Button();
            this.comboDeThiONQuyenLyDeThi = new System.Windows.Forms.ComboBox();
            this.comboKhoiONQuyenLyDeThi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listViewCauHoiOnMaDeAndKhoi = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemKiThi = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tabQuanLyKiThiAll.SuspendLayout();
            this.tabQuanLyKiThi.SuspendLayout();
            this.tabThongKeCauHoi.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ThongKeKiThi.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.lbNameGiaoVien.Size = new System.Drawing.Size(154, 23);
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
            this.tabQuanLyKiThiAll.Controls.Add(this.ThongKeKiThi);
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
            this.tabThongKeHocSinh.Click += new System.EventHandler(this.tabThongKeHocSinh_Click);
            // 
            // tabQuanLyKiThi
            // 
            this.tabQuanLyKiThi.Controls.Add(this.groupBox7);
            this.tabQuanLyKiThi.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyKiThi.Name = "tabQuanLyKiThi";
            this.tabQuanLyKiThi.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyKiThi.Size = new System.Drawing.Size(975, 491);
            this.tabQuanLyKiThi.TabIndex = 1;
            this.tabQuanLyKiThi.Text = "Quản Lý kì thi";
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
            // btnDuyetCauHoi
            // 
            this.btnDuyetCauHoi.Location = new System.Drawing.Point(18, 137);
            this.btnDuyetCauHoi.Name = "btnDuyetCauHoi";
            this.btnDuyetCauHoi.Size = new System.Drawing.Size(168, 27);
            this.btnDuyetCauHoi.TabIndex = 1;
            this.btnDuyetCauHoi.Text = "Duyệt câu hỏi thêm vào";
            this.btnDuyetCauHoi.UseVisualStyleBackColor = true;
            this.btnDuyetCauHoi.Click += new System.EventHandler(this.btnDuyetCauHoi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaCauHoi);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnUpdateCauHoi);
            this.groupBox3.Controls.Add(this.comboBoxKhoi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboxDoKho);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtCauHoi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(951, 233);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết câu hỏi";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Enabled = false;
            this.txtMaCauHoi.Location = new System.Drawing.Point(804, 110);
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.Size = new System.Drawing.Size(128, 20);
            this.txtMaCauHoi.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(711, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mã câu hỏi :";
            // 
            // btnUpdateCauHoi
            // 
            this.btnUpdateCauHoi.Location = new System.Drawing.Point(771, 170);
            this.btnUpdateCauHoi.Name = "btnUpdateCauHoi";
            this.btnUpdateCauHoi.Size = new System.Drawing.Size(161, 41);
            this.btnUpdateCauHoi.TabIndex = 11;
            this.btnUpdateCauHoi.Text = "Chỉnh sủa câu hỏi";
            this.btnUpdateCauHoi.UseVisualStyleBackColor = true;
            this.btnUpdateCauHoi.Click += new System.EventHandler(this.UpdateCauHoi_Click);
            // 
            // comboBoxKhoi
            // 
            this.comboBoxKhoi.Enabled = false;
            this.comboBoxKhoi.FormattingEnabled = true;
            this.comboBoxKhoi.Location = new System.Drawing.Point(804, 73);
            this.comboBoxKhoi.Name = "comboBoxKhoi";
            this.comboBoxKhoi.Size = new System.Drawing.Size(128, 21);
            this.comboBoxKhoi.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Khối :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(729, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Độ khó :";
            // 
            // comboxDoKho
            // 
            this.comboxDoKho.Enabled = false;
            this.comboxDoKho.FormattingEnabled = true;
            this.comboxDoKho.Location = new System.Drawing.Point(804, 34);
            this.comboxDoKho.Name = "comboxDoKho";
            this.comboxDoKho.Size = new System.Drawing.Size(128, 21);
            this.comboxDoKho.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioCauD);
            this.groupBox4.Controls.Add(this.radioCauC);
            this.groupBox4.Controls.Add(this.radioCauB);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.radioCauA);
            this.groupBox4.Location = new System.Drawing.Point(77, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(612, 117);
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
            this.txtCauHoi.Enabled = false;
            this.txtCauHoi.Location = new System.Drawing.Point(77, 31);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(612, 73);
            this.txtCauHoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Câu hỏi :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listCauHoi);
            this.groupBox2.Location = new System.Drawing.Point(6, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(963, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách câu hỏi";
            // 
            // listCauHoi
            // 
            this.listCauHoi.HideSelection = false;
            this.listCauHoi.Location = new System.Drawing.Point(6, 26);
            this.listCauHoi.Name = "listCauHoi";
            this.listCauHoi.Size = new System.Drawing.Size(951, 211);
            this.listCauHoi.TabIndex = 2;
            this.listCauHoi.UseCompatibleStateImageBehavior = false;
            this.listCauHoi.SelectedIndexChanged += new System.EventHandler(this.listCauHoi_SelectedIndexChanged);
            this.listCauHoi.Click += new System.EventHandler(this.listCauHoi_Click);
            // 
            // btnAddCauHoi
            // 
            this.btnAddCauHoi.Location = new System.Drawing.Point(18, 105);
            this.btnAddCauHoi.Name = "btnAddCauHoi";
            this.btnAddCauHoi.Size = new System.Drawing.Size(168, 24);
            this.btnAddCauHoi.TabIndex = 0;
            this.btnAddCauHoi.Text = "Thêm câu hỏi";
            this.btnAddCauHoi.UseVisualStyleBackColor = true;
            this.btnAddCauHoi.Click += new System.EventHandler(this.btnAddCauHoi_Click);
            // 
            // ThongKeKiThi
            // 
            this.ThongKeKiThi.Controls.Add(this.btnAddTDeThi);
            this.ThongKeKiThi.Controls.Add(this.groupBox6);
            this.ThongKeKiThi.Controls.Add(this.groupBox5);
            this.ThongKeKiThi.Location = new System.Drawing.Point(4, 22);
            this.ThongKeKiThi.Name = "ThongKeKiThi";
            this.ThongKeKiThi.Padding = new System.Windows.Forms.Padding(3);
            this.ThongKeKiThi.Size = new System.Drawing.Size(975, 491);
            this.ThongKeKiThi.TabIndex = 3;
            this.ThongKeKiThi.Text = "Quản lý đề thi";
            this.ThongKeKiThi.UseVisualStyleBackColor = true;
            // 
            // btnAddTDeThi
            // 
            this.btnAddTDeThi.Location = new System.Drawing.Point(762, 232);
            this.btnAddTDeThi.Name = "btnAddTDeThi";
            this.btnAddTDeThi.Size = new System.Drawing.Size(186, 37);
            this.btnAddTDeThi.TabIndex = 7;
            this.btnAddTDeThi.Text = "Thêm đề thi";
            this.btnAddTDeThi.UseVisualStyleBackColor = true;
            this.btnAddTDeThi.Click += new System.EventHandler(this.btnAddTDeThi_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnUpdateDanhSachCauHoiONDeThi);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.btnLoadDanhSachCauHoiONDeThi);
            this.groupBox6.Controls.Add(this.comboDeThiONQuyenLyDeThi);
            this.groupBox6.Controls.Add(this.comboKhoiONQuyenLyDeThi);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(702, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(267, 220);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác trên đề thi";
            // 
            // btnUpdateDanhSachCauHoiONDeThi
            // 
            this.btnUpdateDanhSachCauHoiONDeThi.Location = new System.Drawing.Point(148, 110);
            this.btnUpdateDanhSachCauHoiONDeThi.Name = "btnUpdateDanhSachCauHoiONDeThi";
            this.btnUpdateDanhSachCauHoiONDeThi.Size = new System.Drawing.Size(98, 74);
            this.btnUpdateDanhSachCauHoiONDeThi.TabIndex = 6;
            this.btnUpdateDanhSachCauHoiONDeThi.Text = "chỉnh sửa câu hỏi trong đề";
            this.btnUpdateDanhSachCauHoiONDeThi.UseVisualStyleBackColor = true;
            this.btnUpdateDanhSachCauHoiONDeThi.Click += new System.EventHandler(this.btnUpdateDanhSachCauHoiONDeThi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Đề thi :";
            // 
            // btnLoadDanhSachCauHoiONDeThi
            // 
            this.btnLoadDanhSachCauHoiONDeThi.Location = new System.Drawing.Point(60, 110);
            this.btnLoadDanhSachCauHoiONDeThi.Name = "btnLoadDanhSachCauHoiONDeThi";
            this.btnLoadDanhSachCauHoiONDeThi.Size = new System.Drawing.Size(82, 74);
            this.btnLoadDanhSachCauHoiONDeThi.TabIndex = 5;
            this.btnLoadDanhSachCauHoiONDeThi.Text = "danh sách câu hỏi trong đề";
            this.btnLoadDanhSachCauHoiONDeThi.UseVisualStyleBackColor = true;
            this.btnLoadDanhSachCauHoiONDeThi.Click += new System.EventHandler(this.btnLoadDanhSachCauHoiONDeThi_Click);
            // 
            // comboDeThiONQuyenLyDeThi
            // 
            this.comboDeThiONQuyenLyDeThi.FormattingEnabled = true;
            this.comboDeThiONQuyenLyDeThi.Location = new System.Drawing.Point(62, 23);
            this.comboDeThiONQuyenLyDeThi.Name = "comboDeThiONQuyenLyDeThi";
            this.comboDeThiONQuyenLyDeThi.Size = new System.Drawing.Size(184, 21);
            this.comboDeThiONQuyenLyDeThi.TabIndex = 0;
            this.comboDeThiONQuyenLyDeThi.SelectedIndexChanged += new System.EventHandler(this.comboDeThiONQuyenLyDeThi_SelectedIndexChanged);
            // 
            // comboKhoiONQuyenLyDeThi
            // 
            this.comboKhoiONQuyenLyDeThi.FormattingEnabled = true;
            this.comboKhoiONQuyenLyDeThi.Location = new System.Drawing.Point(62, 56);
            this.comboKhoiONQuyenLyDeThi.Name = "comboKhoiONQuyenLyDeThi";
            this.comboKhoiONQuyenLyDeThi.Size = new System.Drawing.Size(184, 21);
            this.comboKhoiONQuyenLyDeThi.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Khối :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.listViewCauHoiOnMaDeAndKhoi);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(690, 479);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết đề thi";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(152, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 35);
            this.label12.TabIndex = 3;
            this.label12.Text = "Danh sách câu hỏi trong đề thi";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewCauHoiOnMaDeAndKhoi
            // 
            this.listViewCauHoiOnMaDeAndKhoi.HideSelection = false;
            this.listViewCauHoiOnMaDeAndKhoi.Location = new System.Drawing.Point(6, 54);
            this.listViewCauHoiOnMaDeAndKhoi.Name = "listViewCauHoiOnMaDeAndKhoi";
            this.listViewCauHoiOnMaDeAndKhoi.Size = new System.Drawing.Size(678, 405);
            this.listViewCauHoiOnMaDeAndKhoi.TabIndex = 4;
            this.listViewCauHoiOnMaDeAndKhoi.UseCompatibleStateImageBehavior = false;
            this.listViewCauHoiOnMaDeAndKhoi.SelectedIndexChanged += new System.EventHandler(this.listViewCauHoiOnMaDeAndKhoi_SelectedIndexChanged);
            this.listViewCauHoiOnMaDeAndKhoi.Click += new System.EventHandler(this.listViewCauHoiOnMaDeAndKhoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDuyetCauHoi);
            this.groupBox1.Controls.Add(this.btnUpdateGiaoVien);
            this.groupBox1.Controls.Add(this.btnThemKiThi);
            this.groupBox1.Controls.Add(this.btnAddCauHoi);
            this.groupBox1.Location = new System.Drawing.Point(1001, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác của giáo viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnThemKiThi
            // 
            this.btnThemKiThi.Location = new System.Drawing.Point(18, 70);
            this.btnThemKiThi.Name = "btnThemKiThi";
            this.btnThemKiThi.Size = new System.Drawing.Size(168, 23);
            this.btnThemKiThi.TabIndex = 0;
            this.btnThemKiThi.Text = "Thêm kì thi";
            this.btnThemKiThi.UseVisualStyleBackColor = true;
            this.btnThemKiThi.Click += new System.EventHandler(this.btnThemKiThi_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(391, 479);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh sách kì thi";
            this.groupBox7.UseCompatibleTextRendering = true;
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
            this.tabQuanLyKiThi.ResumeLayout(false);
            this.tabThongKeCauHoi.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ThongKeKiThi.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnUpdateCauHoi;
        private System.Windows.Forms.ComboBox comboBoxKhoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboxDoKho;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage ThongKeKiThi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUpdateDanhSachCauHoiONDeThi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoadDanhSachCauHoiONDeThi;
        private System.Windows.Forms.ComboBox comboDeThiONQuyenLyDeThi;
        private System.Windows.Forms.ComboBox comboKhoiONQuyenLyDeThi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listViewCauHoiOnMaDeAndKhoi;
        private System.Windows.Forms.Button btnAddTDeThi;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnThemKiThi;
    }
}