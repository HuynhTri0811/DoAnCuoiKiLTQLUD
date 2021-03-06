﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO.HT;
using BUS.HS;
using System.Configuration;

namespace GUI
{
    public partial class LoginForm : Form
    {

        BUS.HT.GiaoVienBUS_HT giaoVienBUS_HT = new BUS.HT.GiaoVienBUS_HT();
        public LoginForm()
        {
       


            InitializeComponent();
        }

        

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked)
            {
                tbMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            RegisterForm rgs = new RegisterForm();
            rgs.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }
        public delegate void send(); 
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DTO.HT. GiaoVien temp = giaoVienBUS_HT.findGiaoVien(tbEmail.Text, tbMatKhau.Text);

            if (temp != null)
            {                
                GiaoVienGUI giaoVien = new GiaoVienGUI(temp);
                this.Hide();
                giaoVien.ShowDialog();
                this.Close();
                Application.Exit();
            }
            else
            {
                //học sinh
                HocSinhBUS hocSinhBUS = new HocSinhBUS();
                try
                {
                    HocSinh hocSinh = hocSinhBUS.FindOneHocSinh(tbEmail.Text, tbMatKhau.Text);

                    if (hocSinh != null)
                    {
                        HocSinhGUI hocSinhGUI = new HocSinhGUI(hocSinh);
                        this.Hide();
                        hocSinhGUI.ShowDialog();
                        this.Close();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã nhập không chính xác Email hoặc mật khẩu . Xin mời nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tbEmail.Focus();
        }
    }
}
