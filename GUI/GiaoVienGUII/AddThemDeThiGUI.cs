using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.GiaoVien;
using GUI.GiaoVienGUII;
using DTO.HT;
using BUS.HT;

namespace GUI.GiaoVienGUII
{
    public partial class AddThemDeThiGUI : Form
    {
        // KhoiTao
        KhoiBUS_HT khoiBUS_HT = new KhoiBUS_HT();
        CauHoiBUS_HT cauHoiBUS_HT = new CauHoiBUS_HT();
        List<Khoi> khois= new List<Khoi>();
        List<CauHoi> cauHois = new List<CauHoi>();
        int MaKhoi;
        List<CauHoi> cauHoisThemVaoDe = new List<CauHoi>();

        //

        public AddThemDeThiGUI()
        {
            int MaKhoi = 0;
            this.khois = khoiBUS_HT.GetKhoiAll();
            InitializeComponent();
            this.LoadComboBoxKhoi();
        }

        private void AddThemDeThiGUI_Load(object sender, EventArgs e)
        {

        }

        private void LoadListViewCauHoiTrenKhoi(int MaKhoi)
        {
            listCauHoiDuaTrenKhoi.Clear();
            listCauHoiDuaTrenKhoi.View = View.Details;
            listCauHoiDuaTrenKhoi.Columns.Add("Mã");
            listCauHoiDuaTrenKhoi.Columns.Add("Nội dung");
            listCauHoiDuaTrenKhoi.Columns.Add("Câu A");
            listCauHoiDuaTrenKhoi.Columns.Add("Câu B");
            listCauHoiDuaTrenKhoi.Columns.Add("Câu C");
            listCauHoiDuaTrenKhoi.Columns.Add("Câu D");
            listCauHoiDuaTrenKhoi.Columns.Add("CauDung");
            listCauHoiDuaTrenKhoi.Columns.Add("DoKho");
            listCauHoiDuaTrenKhoi.Columns[0].Width = 100;
            listCauHoiDuaTrenKhoi.Columns[1].Width = 400;
            listCauHoiDuaTrenKhoi.Columns[2].Width = 80;
            listCauHoiDuaTrenKhoi.Columns[3].Width = 80;
            listCauHoiDuaTrenKhoi.Columns[4].Width = 100;
            listCauHoiDuaTrenKhoi.Columns[5].Width = 100;
            listCauHoiDuaTrenKhoi.Columns[6].Width = 100;
            listCauHoiDuaTrenKhoi.Columns[7].Width = 100;
            List<CauHoi> cauHois = cauHoiBUS_HT.getAllCauHoiCauHoiOnMaKhoi(MaKhoi);
            foreach (var mem in cauHois)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mem.MaCauHoi.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.NoiDung });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauA });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauB });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauC });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauD });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauDung });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.DoKho1.TenDoKho });
                listCauHoiDuaTrenKhoi.Items.Add(item);
            }
        }


        private void LoadComboBoxKhoi()
        {
            
            foreach(var mem in this.khois)
            {
                comboKhoi.Items.Add(mem.TenKhoi);
            }
            comboKhoi.Text = khois[0].TenKhoi;
        }

        private void comboKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var mem in khois)
            {
                if (mem.TenKhoi == comboKhoi.Text)
                {
                    this.MaKhoi = mem.MaKhoi;
                    break;
                }
            }
            this.LoadListViewCauHoiTrenKhoi(MaKhoi);
        }

        private void btnAddDeThi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listCauHoiDuaTrenKhoi.CheckedItems.Count; i++)
            {
                CauHoi cauHoi = new CauHoi();
                cauHoi = cauHoiBUS_HT.GetOneCauHoi(Int32.Parse(listCauHoiDuaTrenKhoi.CheckedItems[i].Text));
                cauHoisThemVaoDe.Add(cauHoi);
            }
            
            foreach (var mem in cauHoisThemVaoDe)
            {
                foreach(var mem2 in cauHoisThemVaoDe)
                {
                    if(mem.MaKhoi != mem2.MaKhoi)
                    {
                        cauHoisThemVaoDe.Clear();
                        MessageBox.Show("loi");
                        return;
                    }
                }
            }
            AdDeThi adDeThi = new AdDeThi(cauHoisThemVaoDe);
            adDeThi.ShowDialog();
        }
    }
}
