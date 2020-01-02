namespace GUI.GiaoVienGUII
{
    partial class DanhSachDeTrongKiThi
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
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewDanhSachDeTheoMaKhoi = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKiThi = new System.Windows.Forms.TextBox();
            this.danhsachCauHoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(174, 61);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(178, 21);
            this.cbKhoi.TabIndex = 0;
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khối :";
            // 
            // listViewDanhSachDeTheoMaKhoi
            // 
            this.listViewDanhSachDeTheoMaKhoi.HideSelection = false;
            this.listViewDanhSachDeTheoMaKhoi.Location = new System.Drawing.Point(12, 93);
            this.listViewDanhSachDeTheoMaKhoi.Name = "listViewDanhSachDeTheoMaKhoi";
            this.listViewDanhSachDeTheoMaKhoi.Size = new System.Drawing.Size(340, 237);
            this.listViewDanhSachDeTheoMaKhoi.TabIndex = 2;
            this.listViewDanhSachDeTheoMaKhoi.UseCompatibleStateImageBehavior = false;
            this.listViewDanhSachDeTheoMaKhoi.SelectedIndexChanged += new System.EventHandler(this.listViewDanhSachDeTheoMaKhoi_SelectedIndexChanged);
            this.listViewDanhSachDeTheoMaKhoi.Click += new System.EventHandler(this.listViewDanhSachDeTheoMaKhoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MaKiThi :";
            // 
            // txtMaKiThi
            // 
            this.txtMaKiThi.Enabled = false;
            this.txtMaKiThi.Location = new System.Drawing.Point(175, 32);
            this.txtMaKiThi.Name = "txtMaKiThi";
            this.txtMaKiThi.Size = new System.Drawing.Size(177, 20);
            this.txtMaKiThi.TabIndex = 4;
            // 
            // danhsachCauHoi
            // 
            this.danhsachCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachCauHoi.Enabled = false;
            this.danhsachCauHoi.Location = new System.Drawing.Point(406, 93);
            this.danhsachCauHoi.Name = "danhsachCauHoi";
            this.danhsachCauHoi.Size = new System.Drawing.Size(772, 237);
            this.danhsachCauHoi.TabIndex = 5;
            // 
            // DanhSachDeTrongKiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 415);
            this.Controls.Add(this.danhsachCauHoi);
            this.Controls.Add(this.txtMaKiThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewDanhSachDeTheoMaKhoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKhoi);
            this.Name = "DanhSachDeTrongKiThi";
            this.Text = "Danh Sach Đề Thi Trong Kì Thi";
            this.Load += new System.EventHandler(this.DanhSachDeTrongKiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewDanhSachDeTheoMaKhoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKiThi;
        private System.Windows.Forms.DataGridView danhsachCauHoi;
    }
}