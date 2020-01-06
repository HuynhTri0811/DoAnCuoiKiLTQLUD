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
        HocSinhBUS hocSinhBUS = new HocSinhBUS();
        HocSinhGUI.reLoadForm reLoad;
        public SuaThongTinHocSinhForm(HocSinh hocSinh, HocSinhGUI.reLoadForm reLoadForm)
        {
            InitializeComponent();
            hocSinhLogin = hocSinh;
            reLoad = reLoadForm;
        }

        private void SuaThongTinHocSinhForm_Load(object sender, EventArgs e)
        {
            tbHoTen.Text = hocSinhLogin.HoTen;
            dtpNgaySinh.Value = Convert.ToDateTime(hocSinhLogin.NgaySinh);
            tbDiaChi.Text = hocSinhLogin.DiaChi;
            List<Lop> dsLop = new List<Lop>();
            dsLop = hocSinhBUS.LayDanhSachLop();
            if(dsLop != null)
            {
                cbbLop.DataSource = dsLop;
                cbbLop.DisplayMember = "TenLop";
                cbbLop.ValueMember = "MaLop";
                cbbLop.Text = hocSinhLogin.MaLop;
            }
            else
            {
                cbbLop.Text = "Chưa có lớp nào phù hợp!";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HocSinhBUS hocSinhBUS = new HocSinhBUS();
            hocSinhLogin.HoTen = tbHoTen.Text;
            hocSinhLogin.NgaySinh = dtpNgaySinh.Value;
            hocSinhLogin.DiaChi = tbDiaChi.Text;
            hocSinhLogin.MaLop = cbbLop.SelectedValue.ToString();

            try
            {
                hocSinhBUS.UpdateHocSinh(hocSinhLogin.MaHocSinh, hocSinhLogin.HoTen, Convert.ToDateTime(hocSinhLogin.NgaySinh), hocSinhLogin.DiaChi, hocSinhLogin.MaLop);
                this.reLoad();
                btnHuy_Click(sender, e);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
