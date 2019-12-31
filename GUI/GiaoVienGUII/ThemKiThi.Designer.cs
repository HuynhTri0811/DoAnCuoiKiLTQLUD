namespace GUI.GiaoVienGUII
{
    partial class ThemKiThi
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
            this.comboBoxThemKiThiKT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeThi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemKiThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxThemKiThiKT
            // 
            this.comboBoxThemKiThiKT.FormattingEnabled = true;
            this.comboBoxThemKiThiKT.Location = new System.Drawing.Point(81, 45);
            this.comboBoxThemKiThiKT.Name = "comboBoxThemKiThiKT";
            this.comboBoxThemKiThiKT.Size = new System.Drawing.Size(209, 21);
            this.comboBoxThemKiThiKT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiểm tra :";
            // 
            // dateTimeThi
            // 
            this.dateTimeThi.Location = new System.Drawing.Point(81, 96);
            this.dateTimeThi.Name = "dateTimeThi";
            this.dateTimeThi.Size = new System.Drawing.Size(209, 20);
            this.dateTimeThi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời gian :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnThemKiThi
            // 
            this.btnThemKiThi.Location = new System.Drawing.Point(81, 132);
            this.btnThemKiThi.Name = "btnThemKiThi";
            this.btnThemKiThi.Size = new System.Drawing.Size(209, 23);
            this.btnThemKiThi.TabIndex = 6;
            this.btnThemKiThi.Text = "Thêm kì thi";
            this.btnThemKiThi.UseVisualStyleBackColor = true;
            this.btnThemKiThi.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThemKiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 178);
            this.Controls.Add(this.btnThemKiThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxThemKiThiKT);
            this.Name = "ThemKiThi";
            this.Text = "Thêm kì thi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxThemKiThiKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemKiThi;
    }
}