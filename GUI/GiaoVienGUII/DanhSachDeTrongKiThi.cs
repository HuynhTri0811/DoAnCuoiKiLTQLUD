using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.HT;
using BUS.HT;

namespace GUI.GiaoVienGUII
{
    public partial class DanhSachDeTrongKiThi : Form
    {
        KiThi kiThi = new KiThi();
        KhoiBUS_HT khoiBUS_HT = new KhoiBUS_HT();
        DeBUS_HT deBUS_HT = new DeBUS_HT();
        List<Khoi> khois = new List<Khoi>();
        int MaKhoi = -1;
        public DanhSachDeTrongKiThi(KiThi kiThi)
        {
            this.kiThi = kiThi;
            InitializeComponent();
            this.LoadComBoBoxKhoi();
        }

        
        private void LoadComBoBoxKhoi()
        {
            khois = khoiBUS_HT.GetKhoiAll();
            foreach(var mem in khois)
            {
                cbKhoi.Items.Add(mem.TenKhoi);
            }
            cbKhoi.Text = khois[0].TenKhoi;
        }

        private void LoadListViewMaDe(string tenKhoi)
        {
            foreach(var mem in khoiBUS_HT.GetKhoiAll())
            {
                if(mem.TenKhoi == tenKhoi)
                {
                    this.MaKhoi = mem.MaKhoi;
                    break;
                }
            }

            danhsachCauHoi.DataSource = deBUS_HT.getAllMaKhoi(this.MaKhoi).ToList();
            List<De> des = deBUS_HT.getAllMaKhoi(this.MaKhoi);
            listViewDanhSachDeTheoMaKhoi.Clear();
            listViewDanhSachDeTheoMaKhoi.View = View.Details;
            listViewDanhSachDeTheoMaKhoi.Columns.Add("Mã đề");
            listViewDanhSachDeTheoMaKhoi.Columns.Add("Tên đề ");
            listViewDanhSachDeTheoMaKhoi.Columns.Add("Độ khó");
            listViewDanhSachDeTheoMaKhoi.Columns[0].Width = 100;
            listViewDanhSachDeTheoMaKhoi.Columns[1].Width = 100;
            listViewDanhSachDeTheoMaKhoi.Columns[2].Width = 80;
            if(des == null)
            {
                return;
            }
            foreach(var mem in des)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mem.MaDe.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.TenDe });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.DoKho });
                listViewDanhSachDeTheoMaKhoi.Items.Add(item);
            }

        }

        private void DanhSachDeTrongKiThi_Load(object sender, EventArgs e)
        {
            txtMaKiThi.Text = this.kiThi.MaKiThi;
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Count = 0;
            foreach(var mem in khoiBUS_HT.GetKhoiAll())
            {

                if(mem.TenKhoi != cbKhoi.Text)
                {
                    Count++;
                }
                if(mem.TenKhoi == cbKhoi.Text)
                {
                    this.LoadListViewMaDe(cbKhoi.Text);
                    return;
                }
                if(khois.Count == Count)
                {
                    MessageBox.Show("Lỗi , không tìm thấy tên khối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void listViewDanhSachDeTheoMaKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listViewDanhSachDeTheoMaKhoi_Click(object sender, EventArgs e)
        {
            string tempMaCauHoi;
            ListView lsv = sender as ListView;
            ListViewItem item;
            if (lsv.SelectedItems.Count > 0)
            {
                item = lsv.SelectedItems[0];
            }
        }
    }
}
