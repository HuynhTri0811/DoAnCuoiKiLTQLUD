namespace GUI.GiaoVienGUII
{
    partial class AddThemDeThiGUI
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
            this.comboKhoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listCauHoiDuaTrenKhoi = new System.Windows.Forms.ListView();
            this.btnAddDeThi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboKhoi
            // 
            this.comboKhoi.FormattingEnabled = true;
            this.comboKhoi.Location = new System.Drawing.Point(355, 12);
            this.comboKhoi.Name = "comboKhoi";
            this.comboKhoi.Size = new System.Drawing.Size(121, 21);
            this.comboKhoi.TabIndex = 0;
            this.comboKhoi.SelectedIndexChanged += new System.EventHandler(this.comboKhoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khối :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listCauHoiDuaTrenKhoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 436);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách câu hỏi trong khối ";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // listCauHoiDuaTrenKhoi
            // 
            this.listCauHoiDuaTrenKhoi.CheckBoxes = true;
            this.listCauHoiDuaTrenKhoi.HideSelection = false;
            this.listCauHoiDuaTrenKhoi.Location = new System.Drawing.Point(6, 19);
            this.listCauHoiDuaTrenKhoi.Name = "listCauHoiDuaTrenKhoi";
            this.listCauHoiDuaTrenKhoi.Size = new System.Drawing.Size(452, 411);
            this.listCauHoiDuaTrenKhoi.TabIndex = 0;
            this.listCauHoiDuaTrenKhoi.UseCompatibleStateImageBehavior = false;
            this.listCauHoiDuaTrenKhoi.View = System.Windows.Forms.View.List;
            // 
            // btnAddDeThi
            // 
            this.btnAddDeThi.Location = new System.Drawing.Point(198, 481);
            this.btnAddDeThi.Name = "btnAddDeThi";
            this.btnAddDeThi.Size = new System.Drawing.Size(75, 35);
            this.btnAddDeThi.TabIndex = 1;
            this.btnAddDeThi.Text = "Thêm đề thi";
            this.btnAddDeThi.UseVisualStyleBackColor = true;
            this.btnAddDeThi.Click += new System.EventHandler(this.btnAddDeThi_Click);
            // 
            // AddThemDeThiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 528);
            this.Controls.Add(this.btnAddDeThi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboKhoi);
            this.Name = "AddThemDeThiGUI";
            this.Text = "Thêm đề thi";
            this.Load += new System.EventHandler(this.AddThemDeThiGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboKhoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listCauHoiDuaTrenKhoi;
        private System.Windows.Forms.Button btnAddDeThi;
    }
}