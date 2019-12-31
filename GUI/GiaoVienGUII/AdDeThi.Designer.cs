namespace GUI.GiaoVienGUII
{
    partial class AdDeThi
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
            this.txtTenDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDeThi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDoKho = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTenDe
            // 
            this.txtTenDe.Location = new System.Drawing.Point(75, 12);
            this.txtTenDe.Name = "txtTenDe";
            this.txtTenDe.Size = new System.Drawing.Size(125, 20);
            this.txtTenDe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đề :";
            // 
            // btnAddDeThi
            // 
            this.btnAddDeThi.Location = new System.Drawing.Point(75, 71);
            this.btnAddDeThi.Name = "btnAddDeThi";
            this.btnAddDeThi.Size = new System.Drawing.Size(125, 23);
            this.btnAddDeThi.TabIndex = 2;
            this.btnAddDeThi.Text = "Thêm đề ";
            this.btnAddDeThi.UseVisualStyleBackColor = true;
            this.btnAddDeThi.Click += new System.EventHandler(this.btnAddDeThi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Độ khó :";
            // 
            // comboBoxDoKho
            // 
            this.comboBoxDoKho.FormattingEnabled = true;
            this.comboBoxDoKho.Location = new System.Drawing.Point(75, 38);
            this.comboBoxDoKho.Name = "comboBoxDoKho";
            this.comboBoxDoKho.Size = new System.Drawing.Size(125, 21);
            this.comboBoxDoKho.TabIndex = 4;
            // 
            // AdDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 109);
            this.Controls.Add(this.comboBoxDoKho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddDeThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDe);
            this.Name = "AdDeThi";
            this.Text = "Thêm đề thi";
            this.Load += new System.EventHandler(this.AdDeThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDeThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDoKho;
    }
}