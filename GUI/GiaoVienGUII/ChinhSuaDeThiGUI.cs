using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DTO.HT;
using BUS.HT;
using GUI.GiaoVien;
using GUI.GiaoVienGUII;

namespace GUI.GiaoVienGUII
{
    public partial class ChinhSuaDeThiGUI : Form
    {
        DTO.DeVaCauHoiOnMaDeDTO CauHoiTrongDeNao = new DeVaCauHoiOnMaDeDTO();
        KhoiBUS_HT khoiBUS_HT = new KhoiBUS_HT();
        DeBUS_HT deBUS_HT = new DeBUS_HT();
        Khoi khoi;
        List<De> de;
        CauHoi cauHoiHienTai = new CauHoi();
        public void GETVALUECAUHOI(List<CauHoi> cauHois, CauHoi cauhoi)
        {
            this.CauHoiTrongDeNao.listCauHoiOnMaDe = cauHois;
            this.cauHoiHienTai = cauhoi;
        }
        public ChinhSuaDeThiGUI(DTO.DeVaCauHoiOnMaDeDTO cauHoiTrongDeNao)
        {
            CauHoiTrongDeNao = cauHoiTrongDeNao;
            khoi = khoiBUS_HT.FindKhoiOnMaKhoi(CauHoiTrongDeNao.MaKhoi);
            de = deBUS_HT.getAllDe();
            InitializeComponent();
            this.LoadDanhSachCauHoi();
        }


        private void LoadDanhSachCauHoi()
        {
            listCauHoi.Clear();
            listCauHoi.View = View.Details;
            listCauHoi.Columns.Add("Mã");
            listCauHoi.Columns.Add("Nội dung");
            listCauHoi.Columns.Add("Khối");
            listCauHoi.Columns.Add("Tên đề ");
            listCauHoi.Columns.Add("Câu A");
            listCauHoi.Columns.Add("Câu B");
            listCauHoi.Columns.Add("Câu C");
            listCauHoi.Columns.Add("Câu D");
            listCauHoi.Columns.Add("CauDung");
            listCauHoi.Columns[0].Width = 100;
            listCauHoi.Columns[1].Width = 400;
            listCauHoi.Columns[2].Width = 80;
            listCauHoi.Columns[3].Width = 80;
            listCauHoi.Columns[4].Width = 100;
            listCauHoi.Columns[5].Width = 100;
            listCauHoi.Columns[6].Width = 100;
            listCauHoi.Columns[7].Width = 100;
            listCauHoi.Columns[8].Width = 100;
            List<CauHoi> cauHois = CauHoiTrongDeNao.listCauHoiOnMaDe;
            foreach(var mem in cauHois)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mem.MaCauHoi.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.NoiDung });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoi.TenKhoi });
                foreach (var mem1 in de)
                {
                    if (mem1.MaKhoi == CauHoiTrongDeNao.MaKhoi && mem1.MaDe == CauHoiTrongDeNao.MaDe)
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem1.MaDe });
                    }
                }
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauA });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauB });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauC });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauD });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.CauDung });
                listCauHoi.Items.Add(item);
            }
        }

        private void ChinhSuaDeThiGUI_Load(object sender, EventArgs e)
        {
            txtKhoi.Text = CauHoiTrongDeNao.MaKhoi.ToString();
            txtMaDe.Text = CauHoiTrongDeNao.MaDe.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listCauHoi_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

        }
    }
}
