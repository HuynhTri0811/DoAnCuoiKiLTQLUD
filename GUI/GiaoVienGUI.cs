using System;
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
using DTO;

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
            this.LoadListView();


        }

        private void LoadListView()
        {
            listCauHoi.View = View.Details;

            listCauHoi.Columns.Add("Mã câu hỏi");
            listCauHoi.Columns.Add("Nội dung câu hỏi");
            listCauHoi.Columns.Add("Độ khó");
            listCauHoi.Columns.Add("Khối");
            listCauHoi.Columns[0].Width = 100;
            listCauHoi.Columns[1].Width = 400;
            listCauHoi.Columns[2].Width = 80;
            listCauHoi.Columns[3].Width = 80;

            foreach(CauHoiGiaoVien giaovien in cauHoiBUS_HT.getAllCauHoi())
            {
                ListViewItem item = new ListViewItem();
                item.Text = giaovien.MaCauHoi.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = giaovien.NoiDung });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = giaovien.DoKhoTen });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = giaovien.TenKhoi });
                listCauHoi.Items.Add(item);
            }

        }

        private void GiaoVienGUI_Load(object sender, EventArgs e)
        {
            lbNameGiaoVien.Text = newGiaoVien.HoTen;
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

        private void listCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listCauHoi_Click(object sender, EventArgs e)
        {
            int tempMaCauHoi;
            ListView lsv = sender as ListView;
            ListViewItem item;
            if (lsv.SelectedItems.Count > 0)
            {
                item = lsv.SelectedItems[0];
                if(!Int32.TryParse(item.Text,out tempMaCauHoi))
                {
                    MessageBox.Show("Lối . ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tempMaCauHoi = Int16.Parse(item.Text);
                CauHoiGiaoVien giaovien = new CauHoiGiaoVien();
                giaovien = cauHoiBUS_HT.getOneCauHoiONMaCauHoi(tempMaCauHoi);

                txtCauHoi.Text = giaovien.NoiDung;
                radioCauA.Text = giaovien.CauA;
                radioCauB.Text = giaovien.CauB;
                radioCauC.Text = giaovien.CauC;
                radioCauD.Text = giaovien.CauD;
                comboBoxKhoi.Text = giaovien.TenKhoi;
                comboxDoKho.Text = giaovien.DoKhoTen;
                if(giaovien.CauDung == "A   ")
                {
                    radioCauA.Checked = true;
                }
                if (giaovien.CauDung == "B    ")
                {
                    radioCauB.Checked = true;
                }
                if (giaovien.CauDung == "C    ")
                {
                    radioCauC.Checked = true;
                }
                if (giaovien.CauDung == "D    ")
                {
                    radioCauD.Checked = true;
                }
            }
        }
    }
}
