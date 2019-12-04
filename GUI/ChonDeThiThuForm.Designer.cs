namespace GUI
{
    partial class ChonDeThiThuForm
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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenHocSinh = new System.Windows.Forms.Label();
            this.cbbChonMucDo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbChonDeThi = new System.Windows.Forms.ComboBox();
            this.btnThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(254, 7);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 0;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin chào:";
            // 
            // lbTenHocSinh
            // 
            this.lbTenHocSinh.AutoSize = true;
            this.lbTenHocSinh.Location = new System.Drawing.Point(81, 17);
            this.lbTenHocSinh.Name = "lbTenHocSinh";
            this.lbTenHocSinh.Size = new System.Drawing.Size(67, 13);
            this.lbTenHocSinh.TabIndex = 2;
            this.lbTenHocSinh.Text = "TenHocSinh";
            // 
            // cbbChonMucDo
            // 
            this.cbbChonMucDo.FormattingEnabled = true;
            this.cbbChonMucDo.Location = new System.Drawing.Point(103, 56);
            this.cbbChonMucDo.Name = "cbbChonMucDo";
            this.cbbChonMucDo.Size = new System.Drawing.Size(121, 21);
            this.cbbChonMucDo.TabIndex = 3;
            this.cbbChonMucDo.SelectedIndexChanged += new System.EventHandler(this.cbbChonMucDo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn mức độ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn đề thi:";
            // 
            // cbbChonDeThi
            // 
            this.cbbChonDeThi.FormattingEnabled = true;
            this.cbbChonDeThi.Location = new System.Drawing.Point(103, 92);
            this.cbbChonDeThi.Name = "cbbChonDeThi";
            this.cbbChonDeThi.Size = new System.Drawing.Size(121, 21);
            this.cbbChonDeThi.TabIndex = 5;
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(149, 127);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(75, 23);
            this.btnThi.TabIndex = 7;
            this.btnThi.Text = "Thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // ChonDeThiThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 170);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbChonDeThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbChonMucDo);
            this.Controls.Add(this.lbTenHocSinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuayLai);
            this.Name = "ChonDeThiThuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonDeThiThuForm";
            this.Load += new System.EventHandler(this.ChonDeThiThuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenHocSinh;
        private System.Windows.Forms.ComboBox cbbChonMucDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbChonDeThi;
        private System.Windows.Forms.Button btnThi;
    }
}