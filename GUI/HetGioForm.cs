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
    public partial class HetGioForm : Form
    {
        HocSinh hocSinhLogin;
        CauHoiHocSinhForm.SendMassage functionSend;
        double soDiemHS;
        double soCauDungHS;
        int phutHS;
        public HetGioForm(HocSinh hocSinh, CauHoiHocSinhForm.SendMassage send, double soDiem, double soCauDung, int phut)
        {
            InitializeComponent();
            hocSinhLogin = hocSinh;
            functionSend = send;
            soDiemHS = soDiem;
            soCauDungHS = soCauDung;
            phutHS = phut;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HocSinhGUI hsGUI = new HocSinhGUI(hocSinhLogin);
            this.Hide();
            hsGUI.ShowDialog();
            this.Close();
            Application.Exit();
        }

        private void HetGioForm_Load(object sender, EventArgs e)
        {
            this.functionSend();
            if(phutHS < 0)
            {
                lbNoiDungThongBao.Text = "Đã hết thời gian!";
            }
            else
            {
                lbNoiDungThongBao.Text = "Kết quả bài thi";
            }
            lbSoCauDung.Text = soCauDungHS.ToString() + "/15";
            lbSoDiem.Text = soDiemHS.ToString("0.00") + " đ";
        }
    }
}
