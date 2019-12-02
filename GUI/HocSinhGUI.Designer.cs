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
            this.lbNameUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tctrHocSinh = new System.Windows.Forms.TabControl();
            this.tpThongTinCaNhan = new System.Windows.Forms.TabPage();
            this.tpLichSuThi = new System.Windows.Forms.TabPage();
            this.tpThi = new System.Windows.Forms.TabPage();
            this.tctrHocSinh.SuspendLayout();
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
            // lbNameUser
            // 
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Location = new System.Drawing.Point(70, 9);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(60, 13);
            this.lbNameUser.TabIndex = 1;
            this.lbNameUser.Text = "Name User";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tpThongTinCaNhan.Location = new System.Drawing.Point(4, 22);
            this.tpThongTinCaNhan.Name = "tpThongTinCaNhan";
            this.tpThongTinCaNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongTinCaNhan.Size = new System.Drawing.Size(565, 240);
            this.tpThongTinCaNhan.TabIndex = 0;
            this.tpThongTinCaNhan.Text = "Thông tin cá nhân";
            this.tpThongTinCaNhan.UseVisualStyleBackColor = true;
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
            this.tpThi.Location = new System.Drawing.Point(4, 22);
            this.tpThi.Name = "tpThi";
            this.tpThi.Padding = new System.Windows.Forms.Padding(3);
            this.tpThi.Size = new System.Drawing.Size(565, 240);
            this.tpThi.TabIndex = 2;
            this.tpThi.Text = "Thi";
            this.tpThi.UseVisualStyleBackColor = true;
            // 
            // HocSinhGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 319);
            this.Controls.Add(this.tctrHocSinh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNameUser);
            this.Controls.Add(this.lbXinChao);
            this.Name = "HocSinhGUI";
            this.Text = "HocSinhGUI";
            this.tctrHocSinh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbXinChao;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tctrHocSinh;
        private System.Windows.Forms.TabPage tpThongTinCaNhan;
        private System.Windows.Forms.TabPage tpLichSuThi;
        private System.Windows.Forms.TabPage tpThi;
    }
}