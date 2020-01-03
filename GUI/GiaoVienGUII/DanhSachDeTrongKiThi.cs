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
using DAO.HT;

namespace GUI.GiaoVienGUII
{
    public partial class DanhSachDeTrongKiThi : Form
    {
        DataContextDataContext DB = new DataContextDataContext();
        KyThi kiThi = new KyThi();
        KhoiBUS_HT khoiBUS_HT = new KhoiBUS_HT();
        DeBUS_HT deBUS_HT = new DeBUS_HT();
        List<Khoi> khois = new List<Khoi>();
        CauHoiTrongDeNaoBUS_HT cauHoiTrongDeNaoBUS_HT = new CauHoiTrongDeNaoBUS_HT();
        HocSinhBUS hocSinhBUS = new HocSinhBUS();
        int MaKhoi = -1;



        public DanhSachDeTrongKiThi(KyThi kiThi)
        {
            this.kiThi = kiThi;
            InitializeComponent();
            this.LoadComBoBoxKhoi();
        }


        private void LoadDanhSachhoCSinh(string TenKhoi)
        {
            foreach (var mem in khoiBUS_HT.GetKhoiAll())
            {
                if (mem.TenKhoi == TenKhoi)
                {
                    this.MaKhoi = mem.MaKhoi;
                    break;
                }
            }
            List<HocSinh> hocSinhs = hocSinhBUS.getAllHocSinhTheoMaKhoi(this.MaKhoi);
            listViewDanhSachHocSinh.Clear();
            listViewDanhSachHocSinh.View = View.Details;
            listViewDanhSachHocSinh.Columns.Add("Mã Học Sinh");
            listViewDanhSachHocSinh.Columns.Add("Tên học sinh ");
            listViewDanhSachHocSinh.Columns.Add("Lớp");
            listViewDanhSachHocSinh.Columns[0].Width = 100;
            listViewDanhSachHocSinh.Columns[1].Width = 100;
            listViewDanhSachHocSinh.Columns[2].Width = 80;
            if (hocSinhs == null)
            {
                return;
            }
            foreach (var mem in hocSinhs)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mem.MaHocSinh.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.HoTen });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.MaLop });
                listViewDanhSachHocSinh.Items.Add(item);
            }

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
            txtMaKiThi.Text = this.kiThi.MaKyThi;
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
                    this.LoadDanhSachhoCSinh(cbKhoi.Text);
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
            ListView lsv = sender as ListView;
            ListViewItem item;
            if (lsv.SelectedItems.Count > 0)
            {
                item = lsv.SelectedItems[0];
                List<CauHoi> cauHois = cauHoiTrongDeNaoBUS_HT.getAllCauHoiTrongDes(item.Text, this.MaKhoi);
                if(cauHois == null)
                {
                    return;
                }
            }
        }

        private void btnDanhSachHocSinh_Click(object sender, EventArgs e)
        {

        }
    }
}
