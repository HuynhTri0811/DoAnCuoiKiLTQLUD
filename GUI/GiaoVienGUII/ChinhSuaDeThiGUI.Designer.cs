namespace GUI.GiaoVienGUII
{
    partial class ChinhSuaDeThiGUI
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
            this.txtKhoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listCauHoi = new System.Windows.Forms.ListView();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtKhoi
            // 
            this.txtKhoi.Enabled = false;
            this.txtKhoi.Location = new System.Drawing.Point(481, 58);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(100, 20);
            this.txtKhoi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khối :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chỉnh sửa câu hỏi trong đề thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh sách câu hỏi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listCauHoi
            // 
            this.listCauHoi.HideSelection = false;
            this.listCauHoi.Location = new System.Drawing.Point(12, 115);
            this.listCauHoi.Name = "listCauHoi";
            this.listCauHoi.Size = new System.Drawing.Size(569, 399);
            this.listCauHoi.TabIndex = 4;
            this.listCauHoi.UseCompatibleStateImageBehavior = false;
            this.listCauHoi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listCauHoi_MouseClick);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(231, 520);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(101, 33);
            this.btnChinhSua.TabIndex = 5;
            this.btnChinhSua.Text = "Thay đổi câu hỏi";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã đề :";
            // 
            // txtMaDe
            // 
            this.txtMaDe.Enabled = false;
            this.txtMaDe.Location = new System.Drawing.Point(481, 85);
            this.txtMaDe.Name = "txtMaDe";
            this.txtMaDe.Size = new System.Drawing.Size(100, 20);
            this.txtMaDe.TabIndex = 7;
            // 
            // ChinhSuaDeThiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 565);
            this.Controls.Add(this.txtMaDe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.listCauHoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKhoi);
            this.Name = "ChinhSuaDeThiGUI";
            this.Text = "ChinhSuaDeThiGUI";
            this.Load += new System.EventHandler(this.ChinhSuaDeThiGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKhoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listCauHoi;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDe;
    }
}