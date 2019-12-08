﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.HT;
using DTO.HT;

namespace GUI
{
    public partial class GiaoVienGUI : Form
    {
        GiaoVien newGiaoVien;
     
        GiaoVienBUS_HT giaoVienBUS_HT = new GiaoVienBUS_HT();
        CauHoiBUS_HT cauHoiBUS_HT = new CauHoiBUS_HT();
        public GiaoVienGUI(GiaoVien GiaoViens)
        {
            InitializeComponent();
            this.Refresh();
            newGiaoVien = giaoVienBUS_HT.FindOneGiaoVienOnMAGV(GiaoViens.MaGiaVien);
            
        }

        private void GiaoVienGUI_Load(object sender, EventArgs e)
        {
            lbNameGiaoVien.Text = newGiaoVien.HoTen;
            dataGirdViewDanhSachCauHoi.DataSource = cauHoiBUS_HT.getAllCauHoi();
        }

        private void btnUpdateGiaoVien_Click(object sender, EventArgs e)
        {
            CapNhatGiaoVienGUI capNhatGiaoVien = new CapNhatGiaoVienGUI(newGiaoVien);
            capNhatGiaoVien.lblnamegv = lbNameGiaoVien;
            capNhatGiaoVien.ShowDialog();
            newGiaoVien = giaoVienBUS_HT.FindOneGiaoVienOnMAGV(this.newGiaoVien.MaGiaVien);
            lbNameGiaoVien.Text = newGiaoVien.HoTen;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
