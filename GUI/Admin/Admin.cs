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
using DTO;

namespace GUI.Admin
{
    public partial class Admin : Form
    {
        DataContextDataContext DB = new DataContextDataContext();

        public Admin()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        void LoadDanhSachGiaoVien()
        {
            List<DTO.HT.GiaoVien> hocSinhs = DB.GiaoViens.ToList();
            listDanhSachGiaoVien.Clear();
            listDanhSachGiaoVien.View = View.Details;
            listDanhSachGiaoVien.Columns.Add("Mã giáo viên");
            listDanhSachGiaoVien.Columns.Add("Tên giáo viên ");
            listDanhSachGiaoVien.Columns.Add("Khối");
            listDanhSachGiaoVien.Columns[0].Width = 100;
            listDanhSachGiaoVien.Columns[1].Width = 200;
            listDanhSachGiaoVien.Columns[2].Width = 80;
            if (hocSinhs == null)
            {
                return;
            }

            foreach (var mem in hocSinhs)
            {
                ListViewItem item = new ListViewItem();

                item.Text = mem.MaGiaVien.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.HoTen });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.MaKhoi.ToString() });
                listDanhSachGiaoVien.Items.Add(item);

            }
        }
        private void LoadGiaoVien(string maGiaoVien)
        {
            var findOneGiaoVien = DB.GiaoViens.Where(r => r.MaGiaVien == maGiaoVien).Single();
            txtMaGiaoVien.Text = findOneGiaoVien.MaGiaVien;
            txtHoTenGiaoVien.Text = findOneGiaoVien.HoTen;
            txtPasswordGiaoVien.Text = findOneGiaoVien.Password;
            txtSDTGiaoVien.Text = findOneGiaoVien.SDT;
            txtDiaChiGiaoVien.Text = findOneGiaoVien.DiaChi;
            txtEmailGiaoVien.Text = findOneGiaoVien.Email;
            txtMaKhoi.Text = findOneGiaoVien.Khoi.TenKhoi;
        }

        private void listDanhSachGiaoVien_Click(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            ListViewItem item;
            if (lsv.SelectedItems.Count > 0)
            {
                item = lsv.SelectedItems[0];
                this.LoadGiaoVien(item.Text);

            }
        }

        private void btnUpdateGiaoVien_Click(object sender, EventArgs e)
        {
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var find = DB.GiaoViens.Where(r => r.MaGiaVien == txtMaGiaoVien.Text).Single();
                find.DiaChi = txtDiaChiGiaoVien.Text;
                find.Email = txtEmailGiaoVien.Text;
                find.HoTen = txtHoTenGiaoVien.Text;
                find.Password = txtPasswordGiaoVien.Text;
                find.SDT = txtSDTGiaoVien.Text;
                DB.SubmitChanges();
                MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadGiaoVien(txtMaGiaoVien.Text);
            }
        }
    }
}
