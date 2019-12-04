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
    public partial class CauHoiHocSinhForm : Form
    {
        HocSinh hocSinhLogin;
        string maDeDuocChon;
        HocSinhBUS hocSinhBUS = new HocSinhBUS();
        List<DeVaCauHoiDTO> dsCauHoi = new List<DeVaCauHoiDTO>();
        int next = 0;
        public CauHoiHocSinhForm(HocSinh hocSinh, string maDe)
        {
            InitializeComponent();
            hocSinhLogin = hocSinh;
            maDeDuocChon = maDe;
        }

        private void CauHoiHocSinhForm_Load(object sender, EventArgs e)
        {
            lbTenHocSinh.Text = hocSinhLogin.HoTen;
            LoadFormCauHoiHS();
        }

        private void LoadFormCauHoiHS()
        {            
            dsCauHoi = hocSinhBUS.LayDeTheoMaDe(maDeDuocChon);
            string cauSo = "Câu số " + dsCauHoi[next].MaCauHoi.ToString() + ":";
            lbCauSo.Text = cauSo;
            lbNoiDung.Text = dsCauHoi[next].NoiDung;
            if(next == 0)
            {
                btnCauTruoc.Enabled = false;
            }
            else
            {
                btnCauTruoc.Enabled = true;
            }

            if(next == 15)
            {
                btnCauSau.Enabled = false;
            }
            else
            {
                btnCauSau.Enabled = true;
            }

            if(dsCauHoi[next].CauChon != "")
            {
                if(dsCauHoi[next].CauChon == "A")
                {
                    rdbtnCauA.Checked = true;
                }
                else if (dsCauHoi[next].CauChon == "B")
                    {
                        rdbtnCauB.Checked = true;
                    }
                    else if (dsCauHoi[next].CauChon == "C")
                        {
                            rdbtnCauC.Checked = true;
                        }
                        else
                        {
                            rdbtnCauD.Checked = true;
                        }
            }
            else
            {
                rdbtnCauA.Checked = false;
                rdbtnCauB.Checked = false;
                rdbtnCauC.Checked = false;
                rdbtnCauD.Checked = false;
            }

            rdbtnCauA.Text = dsCauHoi[next].CauA;
            rdbtnCauB.Text = dsCauHoi[next].CauB;
            rdbtnCauC.Text = dsCauHoi[next].CauC;
            rdbtnCauD.Text = dsCauHoi[next].CauD;
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            next -= 1;
            LoadFormCauHoiHS();
        }

        private void btnCauSau_Click(object sender, EventArgs e)
        {
            next += 1;
            LoadFormCauHoiHS();
        }

        private void rdbtnCauA_CheckedChanged(object sender, EventArgs e)
        {
            dsCauHoi[next].CauChon = "A";
        }

        private void rdbtnCauB_CheckedChanged(object sender, EventArgs e)
        {
            dsCauHoi[next].CauChon = "B";
        }

        private void rdbtnCauC_CheckedChanged(object sender, EventArgs e)
        {
            dsCauHoi[next].CauChon = "C";
        }

        private void rdbtnCauD_CheckedChanged(object sender, EventArgs e)
        {
            dsCauHoi[next].CauChon = "D";
        }
    }
}
