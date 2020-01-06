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
            if (listViewDanhSachDeTheoMaKhoi.CheckedItems.Count > 1)
            {
                MessageBox.Show("Bạn đã chọn nhiều hơn 1 mã đề . Làm hơn chọn 1 mã đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string MaDe = null;
            List<HocSinh> find = null;
            if (listViewDanhSachDeTheoMaKhoi.CheckedItems.Count != 0)
            {
                string Made = listViewDanhSachDeTheoMaKhoi.CheckedItems[0].Text;

               find = (from hs in DB.HocSinhTrongKiThis
                            where hs.DeVaKhoiTrongKyThi.MaKyThi == txtMaKiThi.Text && hs.DeVaKhoiTrongKyThi.MaKhoi == MaKhoi && hs.DeVaKhoiTrongKyThi.MaDe == Made
                            select hs.HocSinh).ToList();
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
                if(find != null)
                {
                    foreach (var hocsinhtontai in find)
                    {
                        if (hocsinhtontai.MaHocSinh == mem.MaHocSinh)
                        {
                            item.Checked = true;
                        }
                    }
                }
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

        private void btnLoadDanhSachCauHoi_Click(object sender, EventArgs e)
        {
            if (listViewDanhSachDeTheoMaKhoi.CheckedItems.Count > 1)
            {
                MessageBox.Show("Bạn đã chọn nhiều hơn 1 mã đề . Làm hơn chọn 1 mã đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listViewDanhSachDeTheoMaKhoi.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bạn đã không chọn mã đề nào . Làm hơn chọn 1 mã đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Made = listViewDanhSachDeTheoMaKhoi.CheckedItems[0].Text;
            foreach (var mem in khoiBUS_HT.GetKhoiAll())
            {
                if (mem.TenKhoi == cbKhoi.Text)
                {
                    this.MaKhoi = mem.MaKhoi;
                    break;
                }
            }
            string MaDeVaKhoiTrongKiThi = MaKhoi.ToString() + Made.Substring(6, 4) + txtMaKiThi.Text.Substring(6, 4);
            DTO.HT.DeVaKhoiTrongKyThi deVaKhoiTrongKyThi = new DeVaKhoiTrongKyThi();
            deVaKhoiTrongKyThi.MaDe = Made;
            deVaKhoiTrongKyThi.MaKhoi = this.MaKhoi;
            deVaKhoiTrongKyThi.MaKyThi = txtMaKiThi.Text;
            deVaKhoiTrongKyThi.MaDeVaKhoiTrongKyThi = MaDeVaKhoiTrongKiThi;
            var find = DB.DeVaKhoiTrongKyThis.Where(r => r.MaDe == Made && r.MaKhoi == MaKhoi && r.MaKyThi == txtMaKiThi.Text);
            
            if(find.Count() == 0)
            {
                using (DataContextDataContext DB = new DataContextDataContext())
                {
                    DB.DeVaKhoiTrongKyThis.InsertOnSubmit(deVaKhoiTrongKyThi);
                    DB.SubmitChanges();
                }
            }
            int temp = 0;
            for(int i = 0; i < listViewDanhSachHocSinh.CheckedItems.Count; i++)
            {
                string Ma = (from mdevakhoitrongkithi in DB.DeVaKhoiTrongKyThis
                             where mdevakhoitrongkithi.MaDe == Made && mdevakhoitrongkithi.MaKhoi == this.MaKhoi && mdevakhoitrongkithi.MaKyThi == txtMaKiThi.Text
                             select mdevakhoitrongkithi.MaDeVaKhoiTrongKyThi).Single();
                var find2 = DB.HocSinhTrongKiThis.Where(r => r.MaHocSinh == listViewDanhSachHocSinh.CheckedItems[i].Text && r.MaDeVaKhoiTrongKiThi == Ma);
                HocSinhTrongKiThi hocSinhTrongKiThi = new HocSinhTrongKiThi();
                hocSinhTrongKiThi.MaDeVaKhoiTrongKiThi = Ma;
                hocSinhTrongKiThi.MaHocSinh = listViewDanhSachHocSinh.CheckedItems[i].Text;
                hocSinhTrongKiThi.Diem = null;
                if(find2.Count() == 0)
                {
                    using (DataContextDataContext DB = new DataContextDataContext())
                    {
                        temp++;
                        DB.HocSinhTrongKiThis.InsertOnSubmit(hocSinhTrongKiThi);
                        DB.SubmitChanges();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công khi thêm hoc sinh " + listViewDanhSachHocSinh.CheckedItems[i].Text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            if(temp == listViewDanhSachHocSinh.CheckedItems.Count)
            {
                MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXemCauHoiTrongDe_Click(object sender, EventArgs e)
        {
            DTO.DeVaCauHoiOnMaDeDTO deVaCauHoiOnMaDeDTO = new DTO.DeVaCauHoiOnMaDeDTO();
            if(listViewDanhSachDeTheoMaKhoi.CheckedItems.Count > 1)
            {
                MessageBox.Show("Bạn đã chọn nhiều hơn 1 mã đề . Làm hơn chọn 1 mã đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listViewDanhSachDeTheoMaKhoi.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bạn đã không chọn mã đề nào . Làm hơn chọn 1 mã đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Made = listViewDanhSachDeTheoMaKhoi.CheckedItems[0].Text;
            foreach (var mem in khoiBUS_HT.GetKhoiAll())
            {
                if (mem.TenKhoi == cbKhoi.Text)
                {
                    this.MaKhoi = mem.MaKhoi;
                    break;
                }
            }
            
            deVaCauHoiOnMaDeDTO = cauHoiTrongDeNaoBUS_HT.getAllCauHoiTrongDe(Made, this.MaKhoi);
            if(deVaCauHoiOnMaDeDTO == null)
            {
                MessageBox.Show("Câu hỏi trong bộ đề này trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChinhSuaDeThiGUI chinhSuaDeThiGUI = new ChinhSuaDeThiGUI(deVaCauHoiOnMaDeDTO);
            chinhSuaDeThiGUI.ShowDialog();
        }

        private void listViewDanhSachHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
