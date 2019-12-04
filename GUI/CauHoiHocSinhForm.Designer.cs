namespace GUI
{
    partial class CauHoiHocSinhForm
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
            this.pnCauHoi = new System.Windows.Forms.Panel();
            this.rdbtnCauD = new System.Windows.Forms.RadioButton();
            this.rdbtnCauC = new System.Windows.Forms.RadioButton();
            this.rdbtnCauB = new System.Windows.Forms.RadioButton();
            this.rdbtnCauA = new System.Windows.Forms.RadioButton();
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.lbCauSo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenHocSinh = new System.Windows.Forms.Label();
            this.btnBoBai = new System.Windows.Forms.Button();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnCauSau = new System.Windows.Forms.Button();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.pnCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCauHoi
            // 
            this.pnCauHoi.Controls.Add(this.rdbtnCauD);
            this.pnCauHoi.Controls.Add(this.rdbtnCauC);
            this.pnCauHoi.Controls.Add(this.rdbtnCauB);
            this.pnCauHoi.Controls.Add(this.rdbtnCauA);
            this.pnCauHoi.Controls.Add(this.lbNoiDung);
            this.pnCauHoi.Controls.Add(this.lbCauSo);
            this.pnCauHoi.Location = new System.Drawing.Point(12, 72);
            this.pnCauHoi.Name = "pnCauHoi";
            this.pnCauHoi.Size = new System.Drawing.Size(657, 299);
            this.pnCauHoi.TabIndex = 0;
            // 
            // rdbtnCauD
            // 
            this.rdbtnCauD.AutoSize = true;
            this.rdbtnCauD.Location = new System.Drawing.Point(358, 166);
            this.rdbtnCauD.Name = "rdbtnCauD";
            this.rdbtnCauD.Size = new System.Drawing.Size(52, 17);
            this.rdbtnCauD.TabIndex = 5;
            this.rdbtnCauD.TabStop = true;
            this.rdbtnCauD.Text = "CauD";
            this.rdbtnCauD.UseVisualStyleBackColor = true;
            this.rdbtnCauD.CheckedChanged += new System.EventHandler(this.rdbtnCauD_CheckedChanged);
            // 
            // rdbtnCauC
            // 
            this.rdbtnCauC.AutoSize = true;
            this.rdbtnCauC.Location = new System.Drawing.Point(25, 166);
            this.rdbtnCauC.Name = "rdbtnCauC";
            this.rdbtnCauC.Size = new System.Drawing.Size(51, 17);
            this.rdbtnCauC.TabIndex = 4;
            this.rdbtnCauC.TabStop = true;
            this.rdbtnCauC.Text = "CauC";
            this.rdbtnCauC.UseVisualStyleBackColor = true;
            this.rdbtnCauC.CheckedChanged += new System.EventHandler(this.rdbtnCauC_CheckedChanged);
            // 
            // rdbtnCauB
            // 
            this.rdbtnCauB.AutoSize = true;
            this.rdbtnCauB.Location = new System.Drawing.Point(358, 75);
            this.rdbtnCauB.Name = "rdbtnCauB";
            this.rdbtnCauB.Size = new System.Drawing.Size(51, 17);
            this.rdbtnCauB.TabIndex = 3;
            this.rdbtnCauB.TabStop = true;
            this.rdbtnCauB.Text = "CauB";
            this.rdbtnCauB.UseVisualStyleBackColor = true;
            this.rdbtnCauB.CheckedChanged += new System.EventHandler(this.rdbtnCauB_CheckedChanged);
            // 
            // rdbtnCauA
            // 
            this.rdbtnCauA.AutoSize = true;
            this.rdbtnCauA.Location = new System.Drawing.Point(25, 75);
            this.rdbtnCauA.Name = "rdbtnCauA";
            this.rdbtnCauA.Size = new System.Drawing.Size(51, 17);
            this.rdbtnCauA.TabIndex = 2;
            this.rdbtnCauA.TabStop = true;
            this.rdbtnCauA.Text = "CauA";
            this.rdbtnCauA.UseVisualStyleBackColor = true;
            this.rdbtnCauA.CheckedChanged += new System.EventHandler(this.rdbtnCauA_CheckedChanged);
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.Location = new System.Drawing.Point(77, 19);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(49, 13);
            this.lbNoiDung.TabIndex = 1;
            this.lbNoiDung.Text = "NoiDung";
            // 
            // lbCauSo
            // 
            this.lbCauSo.AutoSize = true;
            this.lbCauSo.Location = new System.Drawing.Point(22, 19);
            this.lbCauSo.Name = "lbCauSo";
            this.lbCauSo.Size = new System.Drawing.Size(39, 13);
            this.lbCauSo.TabIndex = 0;
            this.lbCauSo.Text = "CauSo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Học sinh:";
            // 
            // lbTenHocSinh
            // 
            this.lbTenHocSinh.AutoSize = true;
            this.lbTenHocSinh.Location = new System.Drawing.Point(71, 13);
            this.lbTenHocSinh.Name = "lbTenHocSinh";
            this.lbTenHocSinh.Size = new System.Drawing.Size(67, 13);
            this.lbTenHocSinh.TabIndex = 2;
            this.lbTenHocSinh.Text = "TenHocSinh";
            // 
            // btnBoBai
            // 
            this.btnBoBai.Location = new System.Drawing.Point(567, 8);
            this.btnBoBai.Name = "btnBoBai";
            this.btnBoBai.Size = new System.Drawing.Size(75, 23);
            this.btnBoBai.TabIndex = 3;
            this.btnBoBai.Text = "Bỏ bài";
            this.btnBoBai.UseVisualStyleBackColor = true;
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.Location = new System.Drawing.Point(37, 377);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnCauTruoc.TabIndex = 4;
            this.btnCauTruoc.Text = "Câu trước";
            this.btnCauTruoc.UseVisualStyleBackColor = true;
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
            // 
            // btnCauSau
            // 
            this.btnCauSau.Location = new System.Drawing.Point(118, 377);
            this.btnCauSau.Name = "btnCauSau";
            this.btnCauSau.Size = new System.Drawing.Size(75, 23);
            this.btnCauSau.TabIndex = 5;
            this.btnCauSau.Text = "Câu sau";
            this.btnCauSau.UseVisualStyleBackColor = true;
            this.btnCauSau.Click += new System.EventHandler(this.btnCauSau_Click);
            // 
            // btnNopBai
            // 
            this.btnNopBai.Location = new System.Drawing.Point(567, 377);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(75, 23);
            this.btnNopBai.TabIndex = 6;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = true;
            // 
            // CauHoiHocSinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 435);
            this.Controls.Add(this.btnNopBai);
            this.Controls.Add(this.btnCauSau);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.btnBoBai);
            this.Controls.Add(this.lbTenHocSinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnCauHoi);
            this.Name = "CauHoiHocSinhForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CauHoiHocSinhForm";
            this.Load += new System.EventHandler(this.CauHoiHocSinhForm_Load);
            this.pnCauHoi.ResumeLayout(false);
            this.pnCauHoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCauHoi;
        private System.Windows.Forms.Label lbNoiDung;
        private System.Windows.Forms.Label lbCauSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTenHocSinh;
        private System.Windows.Forms.Button btnBoBai;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnCauSau;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.RadioButton rdbtnCauD;
        private System.Windows.Forms.RadioButton rdbtnCauC;
        private System.Windows.Forms.RadioButton rdbtnCauB;
        private System.Windows.Forms.RadioButton rdbtnCauA;
    }
}