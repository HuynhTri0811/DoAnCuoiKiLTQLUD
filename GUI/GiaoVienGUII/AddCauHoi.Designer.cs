﻿namespace GUI
{
    partial class AddCauHoi
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
            this.txtNoiDungCauHoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCauDung = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbboxDoKho = new System.Windows.Forms.ComboBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.txtNoiDungCauD = new System.Windows.Forms.TextBox();
            this.txtNoiDungCauC = new System.Windows.Forms.TextBox();
            this.txtNoiDungCauB = new System.Windows.Forms.TextBox();
            this.txtNoiDungCauA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCauHoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNoiDungCauHoi
            // 
            this.txtNoiDungCauHoi.Location = new System.Drawing.Point(136, 27);
            this.txtNoiDungCauHoi.Multiline = true;
            this.txtNoiDungCauHoi.Name = "txtNoiDungCauHoi";
            this.txtNoiDungCauHoi.Size = new System.Drawing.Size(582, 55);
            this.txtNoiDungCauHoi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(254, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm câu hỏi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCauHoi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCauDung);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbboxDoKho);
            this.groupBox1.Controls.Add(this.cbKhoi);
            this.groupBox1.Controls.Add(this.txtNoiDungCauD);
            this.groupBox1.Controls.Add(this.txtNoiDungCauC);
            this.groupBox1.Controls.Add(this.txtNoiDungCauB);
            this.groupBox1.Controls.Add(this.txtNoiDungCauA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoiDungCauHoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 392);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết thêm câu hỏi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Câu đúng :";
            // 
            // cbCauDung
            // 
            this.cbCauDung.FormattingEnabled = true;
            this.cbCauDung.Location = new System.Drawing.Point(136, 248);
            this.cbCauDung.Name = "cbCauDung";
            this.cbCauDung.Size = new System.Drawing.Size(182, 21);
            this.cbCauDung.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Khối :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Độ khó :";
            // 
            // cbboxDoKho
            // 
            this.cbboxDoKho.FormattingEnabled = true;
            this.cbboxDoKho.Location = new System.Drawing.Point(136, 216);
            this.cbboxDoKho.Name = "cbboxDoKho";
            this.cbboxDoKho.Size = new System.Drawing.Size(182, 21);
            this.cbboxDoKho.TabIndex = 13;
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(528, 221);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(190, 21);
            this.cbKhoi.TabIndex = 12;
            // 
            // txtNoiDungCauD
            // 
            this.txtNoiDungCauD.Location = new System.Drawing.Point(136, 183);
            this.txtNoiDungCauD.Name = "txtNoiDungCauD";
            this.txtNoiDungCauD.Size = new System.Drawing.Size(582, 20);
            this.txtNoiDungCauD.TabIndex = 11;
            // 
            // txtNoiDungCauC
            // 
            this.txtNoiDungCauC.Location = new System.Drawing.Point(136, 151);
            this.txtNoiDungCauC.Name = "txtNoiDungCauC";
            this.txtNoiDungCauC.Size = new System.Drawing.Size(582, 20);
            this.txtNoiDungCauC.TabIndex = 10;
            // 
            // txtNoiDungCauB
            // 
            this.txtNoiDungCauB.Location = new System.Drawing.Point(136, 122);
            this.txtNoiDungCauB.Name = "txtNoiDungCauB";
            this.txtNoiDungCauB.Size = new System.Drawing.Size(582, 20);
            this.txtNoiDungCauB.TabIndex = 9;
            // 
            // txtNoiDungCauA
            // 
            this.txtNoiDungCauA.Location = new System.Drawing.Point(136, 93);
            this.txtNoiDungCauA.Name = "txtNoiDungCauA";
            this.txtNoiDungCauA.Size = new System.Drawing.Size(582, 20);
            this.txtNoiDungCauA.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Câu D:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Câu C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Câu B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Câu A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nội dung câu hỏi :";
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauHoi.ForeColor = System.Drawing.Color.Red;
            this.btnCauHoi.Location = new System.Drawing.Point(248, 299);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(277, 54);
            this.btnCauHoi.TabIndex = 18;
            this.btnCauHoi.Text = "Thêm câu hỏi";
            this.btnCauHoi.UseVisualStyleBackColor = true;
            this.btnCauHoi.Click += new System.EventHandler(this.btnCauHoi_Click);
            // 
            // AddCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddCauHoi";
            this.Text = "AddCauHoi";
            this.Load += new System.EventHandler(this.AddCauHoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoiDungCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCauDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbboxDoKho;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.TextBox txtNoiDungCauD;
        private System.Windows.Forms.TextBox txtNoiDungCauC;
        private System.Windows.Forms.TextBox txtNoiDungCauB;
        private System.Windows.Forms.TextBox txtNoiDungCauA;
        private System.Windows.Forms.Button btnCauHoi;
    }
}