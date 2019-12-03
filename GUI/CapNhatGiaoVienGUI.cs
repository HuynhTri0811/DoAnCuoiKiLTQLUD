using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.HT;
using BUS.HT;

namespace GUI
{
    public partial class CapNhatGiaoVienGUI : Form
    {

        GiaoVien giaovien;
        KhoiBUS_HT khoiBUS = new KhoiBUS_HT();
        public CapNhatGiaoVienGUI(GiaoVien giaoVien)
        {
            InitializeComponent();
            giaovien = giaoVien;
            
        }

        

        private void CapNhatGiaoVienGUI_Load(object sender, EventArgs e)
        {
            txtMaGiaoVien.Text = giaovien.MaGiaVien;
            txtEmailGiaoVien.Text = giaovien.Email;
            txtDiaChiGiaoVien.Text = giaovien.DiaChi;
            txtHoTenGiaoVien.Text = giaovien.HoTen;
            txtPasswordGiaoVien.PasswordChar = '*';
            txtPasswordGiaoVien.Text = giaovien.Password;
            txtSDTGiaoVien.Text = giaovien.SDT;
            cbMaKhoi.Text = khoiBUS.getNameKhoi(giaovien.MaKhoi.GetValueOrDefault());

            foreach( var khoi in khoiBUS.GetKhoiAll())
            {
                cbMaKhoi.Items.Add(khoi.TenKhoi);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
