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
    public partial class SuaThongTinHocSinhForm : Form
    {
        HocSinh hocSinhLogin;
        public SuaThongTinHocSinhForm(HocSinh hocSinh)
        {
            InitializeComponent();
            hocSinhLogin = hocSinh;
        }

        private void SuaThongTinHocSinhForm_Load(object sender, EventArgs e)
        {
            tbHoTen.Text = hocSinhLogin.HoTen;
            dtpNgaySinh.Value = Convert.ToDateTime(hocSinhLogin.NgaySinh);
            tbDiaChi.Text = hocSinhLogin.DiaChi;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HocSinhBUS hocSinhBUS = new HocSinhBUS();
            hocSinhLogin.HoTen = tbHoTen.Text;
            hocSinhLogin.NgaySinh = dtpNgaySinh.Value;
            hocSinhLogin.DiaChi = tbDiaChi.Text;

            try
            {
                hocSinhBUS.UpdateHocSinh(hocSinhLogin.MaHocSinh, hocSinhLogin.HoTen, Convert.ToDateTime(hocSinhLogin.NgaySinh), hocSinhLogin.DiaChi);
                btnHuy_Click(sender, e);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            HocSinhGUI hocSinhGUI = new HocSinhGUI(hocSinhLogin);
            this.Hide();
            hocSinhGUI.ShowDialog();
            this.Close();
            Application.Exit();
        }
    }
}
