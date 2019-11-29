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
            this.btnUpdateGiaoVien.Location = new System.Drawing.Point(1014, 47);
            this.btnUpdateGiaoVien.Name = "btnUpdateGiaoVien";
            this.btnUpdateGiaoVien.Size = new System.Drawing.Size(168, 23);
            this.btnUpdateGiaoVien.TabIndex = 2;
            this.btnUpdateGiaoVien.Text = "Cật nhật thông tin";
            this.btnUpdateGiaoVien.UseVisualStyleBackColor = true;
            this.btnUpdateGiaoVien.Click += new System.EventHandler(this.btnUpdateGiaoVien_Click);
            // 
            // GiaoVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 527);
            this.Controls.Add(this.btnUpdateGiaoVien);
            this.Controls.Add(this.lbNameGiaoVien);
            this.Controls.Add(this.label1);
            this.Name = "GiaoVienGUI";
            this.Text = "GiaoVien";
            this.Load += new System.EventHandler(this.GiaoVienGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNameGiaoVien;
        private System.Windows.Forms.Button btnUpdateGiaoVien;
    }
}