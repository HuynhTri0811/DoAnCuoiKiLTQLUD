
using BUS.HS;
using DTO;
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
    public partial class HocSinhGUI : Form
    {
        HocSinh hocSinhLogin;
        HocSinhBUS hocSinhBUS = new HocSinhBUS();
        public HocSinhGUI(HocSinh hocSinh)
        {
            InitializeComponent();
            hocSinhLogin = hocSinh;
        }

        private void HocSinhGUI_Load(object sender, EventArgs e)
        {
            LoadFormHocSinhGUI();             
        }

        public void LoadFormHocSinhGUI()
        {
            lbTenHocSinh.Text = hocSinhLogin.HoTen;
            lbMaHocSinh.Text = hocSinhLogin.MaHocSinh;
            lbNgaySinh.Text = String.Format("{0:dd/MM/yyyy}", hocSinhLogin.NgaySinh).ToString();
            lbDiaChi.Text = hocSinhLogin.DiaChi;
            if (hocSinhLogin.MaLop == null)
            {
                lbMaLop.Text = "Chưa đăng ký lớp học nào!";
            }
            else
            {
                lbMaLop.Text = hocSinhLogin.MaLop;
            }
            dgvThiThu.DataSource = hocSinhBUS.GetAllLichSuThiThu(hocSinhLogin.MaHocSinh);
            dgvThiThu.Columns[3].DefaultCellStyle.Format = "N2";
            dgvKetQuaThi.DataSource = hocSinhBUS.GetAllLichSuKetQuaThi(hocSinhLogin.MaHocSinh);
            dgvKetQuaThi.Columns[3].DefaultCellStyle.Format = "N2";
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
            Application.Exit();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            SuaThongTinHocSinhForm suaThongTinHS = new SuaThongTinHocSinhForm(hocSinhLogin);
            suaThongTinHS.Show();
        }

        private void btnThiThu_Click(object sender, EventArgs e)
        {
            ChonDeThiThuForm chonDeThiThu = new ChonDeThiThuForm(hocSinhLogin);
            this.Hide();
            chonDeThiThu.ShowDialog();
            this.Close();
            Application.Exit();
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            List<DeVaCauHoiThiDTO> dsCauHoiThi = new List<DeVaCauHoiThiDTO>();
            dsCauHoiThi = hocSinhBUS.FindDeVaCauHoiTrongKyThi(hocSinhLogin.MaHocSinh);
            if(dsCauHoiThi == null)
            {
                MessageBox.Show("Không có kỳ thi nào cho bạn ngày hôm nay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CauHoiHocSinhForm chHocSinh = new CauHoiHocSinhForm(hocSinhLogin, "", 0, "Thi");
                this.Hide();
                chHocSinh.ShowDialog();
                this.Close();
                Application.Exit();
            }            
        }
    }
}
