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
        int maKhoiHS;
        HocSinhBUS hocSinhBUS = new HocSinhBUS();
        List<DeVaCauHoiDTO> dsCauHoi = new List<DeVaCauHoiDTO>();
        List<DeVaCauHoiThiDTO> dsCauHoiThi = new List<DeVaCauHoiThiDTO>();
        int next = 0;
        string[] dapAn = new string[15];
        int phut = 7;
        int giay = 30;
        string loai;

        //để dừng timer bên form kết quả
        public delegate void SendMassage();
        public CauHoiHocSinhForm(HocSinh hocSinh, string maDe, int maKhoi, string loaiThi)
        {
            InitializeComponent();
            hocSinhLogin = hocSinh;
            maDeDuocChon = maDe;
            maKhoiHS = maKhoi;
            loai = loaiThi;
        }

        private void CauHoiHocSinhForm_Load(object sender, EventArgs e)
        {
            lbTenHocSinh.Text = hocSinhLogin.HoTen;
            setDA();
            LoadFormCauHoiHS();
            timer1.Start();
        }

        public void setDA()
        {
            for(int i = 0; i < 15; i++)
            {
                dapAn[i] = "";
            }
        }

        private void LoadFormCauHoiHS()
        {
            if(loai == "ThiThu")
            {
                dsCauHoi = hocSinhBUS.LayDeTheoMaDe(maDeDuocChon);
                string cauSo = "Câu số " + dsCauHoi[next].MaCauHoi.ToString() + ":";
                lbCauSo.Text = cauSo;
                lbNoiDung.Text = dsCauHoi[next].NoiDung;
                if (next == 0)
                {
                    btnCauTruoc.Enabled = false;
                }
                else
                {
                    btnCauTruoc.Enabled = true;
                }

                if (next >= 14)
                {
                    btnCauSau.Enabled = false;
                }
                else
                {
                    btnCauSau.Enabled = true;
                }

                if (dapAn[next] != "")
                {
                    if (dapAn[next] == "A")
                    {
                        rdbtnCauA.Checked = true;
                    }
                    else if (dapAn[next] == "B")
                    {
                        rdbtnCauB.Checked = true;
                    }
                    else if (dapAn[next] == "C")
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
            
            if(loai == "Thi")
            {
                dsCauHoiThi = hocSinhBUS.FindDeVaCauHoiTrongKyThi(hocSinhLogin.MaHocSinh);
                string cauSo = "Câu số " + dsCauHoiThi[next].MaCauHoi.ToString() + ":";
                lbCauSo.Text = cauSo;
                lbNoiDung.Text = dsCauHoiThi[next].NoiDung;
                if (next == 0)
                {
                    btnCauTruoc.Enabled = false;
                }
                else
                {
                    btnCauTruoc.Enabled = true;
                }

                if (next >= 14)
                {
                    btnCauSau.Enabled = false;
                }
                else
                {
                    btnCauSau.Enabled = true;
                }

                if (dapAn[next] != "")
                {
                    if (dapAn[next] == "A")
                    {
                        rdbtnCauA.Checked = true;
                    }
                    else if (dapAn[next] == "B")
                    {
                        rdbtnCauB.Checked = true;
                    }
                    else if (dapAn[next] == "C")
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

                rdbtnCauA.Text = "A. " + dsCauHoiThi[next].CauA;
                rdbtnCauB.Text = "B. " + dsCauHoiThi[next].CauB;
                rdbtnCauC.Text = "C. " + dsCauHoiThi[next].CauC;
                rdbtnCauD.Text = "D. " + dsCauHoiThi[next].CauD;
            }            
            
        }

        public void ChonDapAn()
        {
            RadioButton rdbtn = null;
            foreach(RadioButton item in pnCauHoi.Controls)
            {
                if (item.Checked)
                {
                    rdbtn = item;
                    break;
                }
            }
            if(rdbtn != null)
            {
                if(rdbtn.Name.ToString().Substring(8) == "A")
                {
                    dapAn[next] = "A";
                }
                if (rdbtn.Name.ToString().Substring(8) == "B")
                {
                    dapAn[next] = "B";
                }
                if (rdbtn.Name.ToString().Substring(8) == "C")
                {
                    dapAn[next] = "C";
                }
                if (rdbtn.Name.ToString().Substring(8) == "D")
                {
                    dapAn[next] = "D";
                }
            }
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            ChonDapAn();
            next -= 1;
            LoadFormCauHoiHS();
        }

        private void btnCauSau_Click(object sender, EventArgs e)
        {
            ChonDapAn();
            next += 1;
            LoadFormCauHoiHS();
        }

        public double TinhDiem()
        {
            double diem = 0;
            if(loai == "ThiThu")
            {
                for (int i = 0; i < 15; i++)
                {
                    if (dapAn[i] == dsCauHoi[i].CauDung.Substring(0, 1))
                    {
                        diem += (1 / 1.5);
                    }
                }
            }

            if(loai == "Thi")
            {
                for (int i = 0; i < 15; i++)
                {
                    if (dapAn[i] == dsCauHoiThi[i].CauDung.Substring(0, 1))
                    {
                        diem += (1 / 1.5);
                    }
                }
            }
            
            return diem;
        }

        public int SoCauDung()
        {
            int caudung = 0;
            if(loai == "ThiThu")
            {
                for (int i = 0; i < 15; i++)
                {
                    if (dapAn[i] == dsCauHoi[i].CauDung.Substring(0, 1))
                    {
                        caudung++;
                    }
                }
            }

            if(loai == "Thi")
            {
                for (int i = 0; i < 15; i++)
                {
                    if (dapAn[i] == dsCauHoiThi[i].CauDung.Substring(0, 1))
                    {
                        caudung++;
                    }
                }
            }
           
            return caudung;
        }

        public void stopTimer()
        {
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            giay -= 1;
            if(giay < 0)
            {
                phut -= 1;
                giay = 59;
            }

            lbTimerPhut.Text = phut.ToString();
            lbTimerGiay.Text = giay.ToString();

            if(phut < 0)
            {
                if(loai == "ThiThu")
                {
                    ChonDapAn();
                    double soDiem = TinhDiem();
                    int soCauDung = SoCauDung();
                    hocSinhBUS.AddKetQuaThiThu(hocSinhLogin.MaHocSinh, maDeDuocChon, maKhoiHS, soDiem);
                    HetGioForm hetGio = new HetGioForm(hocSinhLogin, stopTimer, soDiem, soCauDung, phut, giay, loai);
                    this.Hide();
                    hetGio.ShowDialog();
                    this.Close();
                    Application.Exit();
                }
                
                if(loai == "Thi")
                {
                    ChonDapAn();
                    double soDiem = TinhDiem();
                    int soCauDung = SoCauDung();
                    string maDeVaKhoiTrongKyThi = dsCauHoiThi[0].MaDeVaKhoiTrongKyThi;
                    hocSinhBUS.AddKetQuaThi(hocSinhLogin.MaHocSinh, maDeVaKhoiTrongKyThi, soDiem);
                    HetGioForm hetGio = new HetGioForm(hocSinhLogin, stopTimer, soDiem, soCauDung, phut, giay, loai);
                    this.Hide();
                    hetGio.ShowDialog();
                    this.Close();
                    Application.Exit();
                }
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn nộp bài thi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                ChonDapAn();
                double soDiem = TinhDiem();
                double soCauDung = SoCauDung();
                if(loai == "ThiThu")
                {
                    hocSinhBUS.AddKetQuaThiThu(hocSinhLogin.MaHocSinh, maDeDuocChon, maKhoiHS, soDiem);
                }
                if(loai == "Thi")
                {
                    string maDeVaKhoiTrongKyThi = dsCauHoiThi[0].MaDeVaKhoiTrongKyThi;
                    hocSinhBUS.AddKetQuaThi(hocSinhLogin.MaHocSinh, maDeVaKhoiTrongKyThi, soDiem);
                }                
                HetGioForm hetGio = new HetGioForm(hocSinhLogin, stopTimer, soDiem, soCauDung, phut, giay, loai);
                this.Hide();
                hetGio.ShowDialog();
                this.Close();
                Application.Exit();
            }
            else
            {
                return;
            }           
        }

        private void btnBoBai_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn bỏ bài thi? Bài thi này sẽ không được ghi vào trong lịch sử thi!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(kq == DialogResult.Yes)
            {
                HocSinhGUI hocSinh = new HocSinhGUI(hocSinhLogin);
                this.Hide();
                hocSinh.ShowDialog();
                this.Close();
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
