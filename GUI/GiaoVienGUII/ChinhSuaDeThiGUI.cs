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
        DAO.HT.CauHoiTrongDeNaoDAO cauHoiTrongDeNaoDAO = new DAO.HT.CauHoiTrongDeNaoDAO();
        CauHoiBUS_HT cauHoiBUS_HT = new CauHoiBUS_HT();
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
            this.LoadDanhSachCauHoi2();
        }

        private void LoadDanhSachCauHoi2()
        {
            listDanhSachCauHoiTheoKhoi.Clear();
            listDanhSachCauHoiTheoKhoi.View = View.Details;
            listDanhSachCauHoiTheoKhoi.Columns.Add("Mã");
            listDanhSachCauHoiTheoKhoi.Columns.Add("Nội dung");
            listDanhSachCauHoiTheoKhoi.Columns.Add("Khối");
            listDanhSachCauHoiTheoKhoi.Columns.Add("Tên đề ");
            listDanhSachCauHoiTheoKhoi.Columns.Add("Câu A");
            listDanhSachCauHoiTheoKhoi.Columns.Add("Câu B");
            listDanhSachCauHoiTheoKhoi.Columns.Add("Câu C");
            listDanhSachCauHoiTheoKhoi.Columns.Add("Câu D");
            listDanhSachCauHoiTheoKhoi.Columns.Add("CauDung");
            listDanhSachCauHoiTheoKhoi.Columns[0].Width = 100;
            listDanhSachCauHoiTheoKhoi.Columns[1].Width = 400;
            listDanhSachCauHoiTheoKhoi.Columns[2].Width = 80;
            listDanhSachCauHoiTheoKhoi.Columns[3].Width = 80;
            listDanhSachCauHoiTheoKhoi.Columns[4].Width = 100;
            listDanhSachCauHoiTheoKhoi.Columns[5].Width = 100;
            listDanhSachCauHoiTheoKhoi.Columns[6].Width = 100;
            listDanhSachCauHoiTheoKhoi.Columns[7].Width = 100;
            listDanhSachCauHoiTheoKhoi.Columns[8].Width = 100;
            List<CauHoi> cauHois = cauHoiBUS_HT.getAllCauHoiCauHoiOnMaKhoi(CauHoiTrongDeNao.MaKhoi);
            foreach (var mem in cauHois)
            {
                var find = CauHoiTrongDeNao.listCauHoiOnMaDe.Find(r => r.MaCauHoi == mem.MaCauHoi);
                if (find != null)
                {
                    continue;
                }
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
                listDanhSachCauHoiTheoKhoi.Items.Add(item);
            }
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

        private void btnChuyen1ChuyenQua2_Click(object sender, EventArgs e)
        {
            if (listCauHoi.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn để có câu hỏi thay đổi", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<CauHoi> temp123 = new List<CauHoi>();
            for(int i = 0; i < listCauHoi.CheckedItems.Count; i++)
            {
                foreach(var mem in CauHoiTrongDeNao.listCauHoiOnMaDe)
                {
                    if (listCauHoi.CheckedItems[i].Text == mem.MaCauHoi.ToString())
                    {
                        
                        int temp =cauHoiTrongDeNaoDAO.DeleteCauHoiONMaDeVaMaKhoi(CauHoiTrongDeNao.MaDe,mem.MaCauHoi,CauHoiTrongDeNao.MaKhoi);
                        if(temp == 1)
                        {
                            MessageBox.Show("Không thể xóa câu hỏi này trong đề này vì có liên quan đến bảng câu hỏi.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        temp123.Add(mem);
                    }
                }
            }
            foreach(var temp in temp123)
            {
                var set = CauHoiTrongDeNao.listCauHoiOnMaDe.Single(r => r.MaCauHoi == temp.MaCauHoi);
                CauHoiTrongDeNao.listCauHoiOnMaDe.Remove(set);
            }

            this.LoadDanhSachCauHoi();
            this.LoadDanhSachCauHoi2();
        }

        private void btnTu2ChuyenQua1_Click(object sender, EventArgs e)
        {
            if (listDanhSachCauHoiTheoKhoi.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn để có câu hỏi thay đổi","Thông báo ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            List<CauHoi> temp123 = new List<CauHoi>();
            for (int i = 0; i < listDanhSachCauHoiTheoKhoi.CheckedItems.Count; i++)
            {
                CauHoi cauHoi = cauHoiBUS_HT.GetOneCauHoi(Int32.Parse(listDanhSachCauHoiTheoKhoi.CheckedItems[i].Text));
                if(cauHoi == null)
                {
                    continue;
                }
                int temp = cauHoiTrongDeNaoDAO.InsertDeVaCauHoi(CauHoiTrongDeNao.MaDe, cauHoi.MaCauHoi, CauHoiTrongDeNao.MaKhoi);
                if (temp == 4)
                {
                    MessageBox.Show("Đã tồn tại những câu hỏi này trong mã đề và mã khối.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                temp123.Add(cauHoi);
                 
            }
            foreach (var temp in temp123)
            {
                CauHoiTrongDeNao.listCauHoiOnMaDe.Add(temp);
            }

            this.LoadDanhSachCauHoi();
            this.LoadDanhSachCauHoi2();

        }
    }
}
