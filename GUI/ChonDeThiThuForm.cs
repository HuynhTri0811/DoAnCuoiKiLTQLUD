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
    public partial class ChonDeThiThuForm : Form
    {
        HocSinh hocSinhLogin;
        HocSinhBUS hocSinhBUS = new HocSinhBUS();
        public ChonDeThiThuForm(HocSinh hocSinh)
        {
            InitializeComponent();
            hocSinhLogin = hocSinh;
        }

        private void ChonDeThiThuForm_Load(object sender, EventArgs e)
        {
            LoadFormChonDeThiThu();
        }

        private void LoadFormChonDeThiThu()
        {
            lbTenHocSinh.Text = hocSinhLogin.HoTen;
            List<DeVaCauHoiDTO> danhSachDeVaCauHoi = new List<DeVaCauHoiDTO>();
            try
            {
                danhSachDeVaCauHoi = hocSinhBUS.GetAllDeThi();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<string> danhSachDoKho = LayDanhSachDoKho(danhSachDeVaCauHoi);

            if (danhSachDeVaCauHoi != null)
            {
                cbbChonMucDo.DataSource = danhSachDoKho;
            }

            List<De> danhSachDe = new List<De>();

            danhSachDe = hocSinhBUS.LayDanhSachDe(cbbChonMucDo.Text);
            if (danhSachDe != null)
            {
                cbbChonDeThi.DataSource = danhSachDe;
                cbbChonDeThi.DisplayMember = "TenDe";
                cbbChonDeThi.ValueMember = "MaDe";
            }
            else
            {
                cbbChonDeThi.Text = "Chưa có đề thi";
            }
        }

        //kiểm tra độ khó có trong danh sách độ khó chưa
        private Boolean checkDoKho(List<string> dsDoKho, string strKiemTra)
        {
            if(dsDoKho == null)
            {
                return true;
            }
            foreach(string doKho in dsDoKho)
            {
                if(String.Compare(doKho, strKiemTra, true) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //lấy ra danh sách độ khó từ danh sách dề và câu hỏi
        private List<string> LayDanhSachDoKho(List<DeVaCauHoiDTO> list)
        {
            List<string> doKho = new List<string>();

            if(list == null)
            {
                doKho = null;
            }
            else
            {
                foreach(DeVaCauHoiDTO item in list)
                {
                    if(checkDoKho(doKho, item.DoKho) == true)
                    {
                        doKho.Add(item.DoKho);
                    }
                }
            }

            return doKho;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HocSinhGUI hocSinhGUI = new HocSinhGUI(hocSinhLogin);
            this.Hide();
            hocSinhGUI.ShowDialog();
            this.Close();
            Application.Exit();
        }

        private void cbbChonMucDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<De> danhSachDe = new List<De>();

            danhSachDe = hocSinhBUS.LayDanhSachDe(cbbChonMucDo.Text);
            if (danhSachDe != null)
            {
                cbbChonDeThi.DataSource = danhSachDe;
                cbbChonDeThi.DisplayMember = "TenDe";
                cbbChonDeThi.ValueMember = "MaDe";
            }
            else
            {
                cbbChonDeThi.Text = "Chưa có đề thi";
            }
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            string maDe = cbbChonDeThi.SelectedValue.ToString();
            int maKhoi = hocSinhBUS.LayMaKhoiTheoMaDe(maDe);
            CauHoiHocSinhForm chHocSinh = new CauHoiHocSinhForm(hocSinhLogin, maDe, maKhoi);
            this.Hide();
            chHocSinh.ShowDialog();
            this.Close();
            Application.Exit();
        }
    }
}
