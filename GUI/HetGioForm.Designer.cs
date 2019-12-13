namespace GUI
{
    partial class HetGioForm
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
            this.lbNoiDungThongBao = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSoCauDung = new System.Windows.Forms.Label();
            this.lbSoDiem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNoiDungThongBao
            // 
            this.lbNoiDungThongBao.AutoSize = true;
            this.lbNoiDungThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDungThongBao.Location = new System.Drawing.Point(38, 20);
            this.lbNoiDungThongBao.Name = "lbNoiDungThongBao";
            this.lbNoiDungThongBao.Size = new System.Drawing.Size(211, 26);
            this.lbNoiDungThongBao.TabIndex = 0;
            this.lbNoiDungThongBao.Text = "NoiDungThongBao";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(98, 119);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số câu đúng:";
            // 
            // lbSoCauDung
            // 
            this.lbSoCauDung.AutoSize = true;
            this.lbSoCauDung.Location = new System.Drawing.Point(95, 60);
            this.lbSoCauDung.Name = "lbSoCauDung";
            this.lbSoCauDung.Size = new System.Drawing.Size(65, 13);
            this.lbSoCauDung.TabIndex = 3;
            this.lbSoCauDung.Text = "SoCauDung";
            // 
            // lbSoDiem
            // 
            this.lbSoDiem.AutoSize = true;
            this.lbSoDiem.Location = new System.Drawing.Point(95, 82);
            this.lbSoDiem.Name = "lbSoDiem";
            this.lbSoDiem.Size = new System.Drawing.Size(44, 13);
            this.lbSoDiem.TabIndex = 5;
            this.lbSoDiem.Text = "SoDiem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điểm:";
            // 
            // HetGioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 154);
            this.Controls.Add(this.lbSoDiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSoCauDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lbNoiDungThongBao);
            this.Name = "HetGioForm";
            this.Text = "HetGioForm";
            this.Load += new System.EventHandler(this.HetGioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNoiDungThongBao;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSoCauDung;
        private System.Windows.Forms.Label lbSoDiem;
        private System.Windows.Forms.Label label5;
    }
}