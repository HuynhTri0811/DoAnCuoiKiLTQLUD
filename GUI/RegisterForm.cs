using BUS.HS;
using DTO.HT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        string[] mang = { "", "", "", "", "" };
        public void LoadForm()
        {
            HocSinhBUS hocSinhBUS = new HocSinhBUS();
            //lấy mã cuối cùng
            string lastMaHS = hocSinhBUS.LastMaHocSinh();

            DateTime now = DateTime.Now;

            //tạo mã mới
            if (lastMaHS != null)
            {
                //lấy ra số trong mã cuối cùng
                int num = int.Parse(lastMaHS.Substring(6)) + 1;
                tbMaHocSinh.Text = "HS" + now.Year.ToString() + num.ToString("0000");
            }
            else
            {

                tbMaHocSinh.Text = "HS" + now.Year.ToString() + "0001";
            }
            if(tbHoTen.Text != "")
            {

            }
            tbHoTen.Text = mang[0];
            if(mang[1] == "")
            {
                dtpNgaySinh.Value = now;
            }
            else
            {
                dtpNgaySinh.Value = Convert.ToDateTime(mang[1]);
            }            
            tbDiaChi.Text = mang[2];
            tbMatKhau.Text = mang[3];
            tbNhapLaiMatKhau.Text = mang[4];
            
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked)
            {
                tbMatKhau.UseSystemPasswordChar = false;
                tbNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar = true;
                tbNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //kiểm tra có ô nào chưa điền
            if(tbHoTen.Text == "" || tbDiaChi.Text == "" || tbMatKhau.Text == "" || tbNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mang[0] = tbHoTen.Text;
                mang[1] = dtpNgaySinh.Text.ToString();
                mang[2] = tbDiaChi.Text;
                mang[3] = tbMatKhau.Text;
                mang[4] = tbNhapLaiMatKhau.Text;
                LoadForm();
                return;
            }

            //kiểm tra ngày sinh
            DateTime now = Convert.ToDateTime(DateTime.Now).Date;
            DateTime NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text).Date;

            if(NgaySinh.AddYears(16) > now)
            {
                MessageBox.Show("Bạn nhỏ hơn 16 tuổi, không thể đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mang[0] = tbHoTen.Text;
                mang[1] = "";
                mang[2] = tbDiaChi.Text;
                mang[3] = tbMatKhau.Text;
                mang[4] = tbNhapLaiMatKhau.Text;
                LoadForm();
                return;
            }


            //kiểm tra mật khẩu
            if (tbMatKhau.Text != tbNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mang[0] = tbHoTen.Text;
                mang[1] = dtpNgaySinh.Text.ToString();
                mang[2] = tbDiaChi.Text;
                mang[3] = "";
                mang[4] = "";
                LoadForm();
                return;
            }

            HocSinhBUS hocSinh = new HocSinhBUS();

            try
            {
                Boolean check = hocSinh.AddHocSinh(tbMaHocSinh.Text, tbHoTen.Text, dtpNgaySinh.Value, tbDiaChi.Text, tbMatKhau.Text);
                if(check == true)
                {
                    MessageBox.Show("Tên đăng nhập: " + tbMaHocSinh.Text + "\nMật khẩu: " + tbMatKhau.Text, "Tài khoản đăng nhập của bạn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        
    }
}
