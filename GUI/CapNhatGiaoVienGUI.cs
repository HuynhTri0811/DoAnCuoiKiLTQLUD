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
        public Label lblnamegv;
        GiaoVien giaovien;
        KhoiBUS_HT khoiBUS = new KhoiBUS_HT();
        GiaoVienBUS_HT giaoVienBUS_HT = new GiaoVienBUS_HT();
        public CapNhatGiaoVienGUI(GiaoVien giaoVien)
        {
            InitializeComponent();
            giaovien = giaoVienBUS_HT.FindOneGiaoVienOnMAGV(giaoVien.MaGiaVien);
            

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

        private void btnCapNhatName_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtHoTenGiaoVien.Text))
            {
                MessageBox.Show("Bạn đã để ô họ và tên trống . Xin mời nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool tempUpdateHoTen = giaoVienBUS_HT.UpdateTenGiaoVien(giaovien.MaGiaVien, txtHoTenGiaoVien.Text);
            if (tempUpdateHoTen == false)
            {
                MessageBox.Show("Không tìm thấy MaGV trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                lblnamegv.Text = txtHoTenGiaoVien.Text;
                MessageBox.Show("Update Thành Công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void CapNhatGiaoVienGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
