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
using GUI.GiaoVien;
using GUI.GiaoVienGUII;
/*
 * -- Khoi tao
 * -- Thong ke cau hoi
 * -- Quan ly de thi
 * -- Giáo viên
 * -- Quản lý kì thi
 */
namespace GUI
{
    public partial class GiaoVienGUI : Form
    {
        // Khoi tao 
        DataContextDataContext DB = new DataContextDataContext();
        public DTO.HT.GiaoVien newGiaoVien;
        int MaCauHoi;
        GiaoVienBUS_HT giaoVienBUS_HT = new GiaoVienBUS_HT();
        CauHoiBUS_HT cauHoiBUS_HT = new CauHoiBUS_HT();
        DoKhoBUS_HT doKhoBUS_HT = new DoKhoBUS_HT();
        string MaKiThi;


        KhoiBUS_HT khoiBUS_HT = new KhoiBUS_HT();
        List<Khoi> khois;
        Khoi khoiInDeThi = new Khoi();

        DeBUS_HT deBUS_HT = new DeBUS_HT();
        List<De> des;
        De de = new De();
        List<DoKho> doKhos;

        CauHoiTrongDeNaoBUS_HT cauHoiTrongDeNaoBUS_HT = new CauHoiTrongDeNaoBUS_HT();
        DTO.DeVaCauHoiOnMaDeDTO cauHoiTrongDeNao;


        List<CauHoi> cauHois;
        CauHoi cauHoiHienTai;


        KiThiBUS kiThiBUS = new KiThiBUS();

        public GiaoVienGUI(DTO.HT.GiaoVien GiaoViens)
        {
            this.doKhos = doKhoBUS_HT.getAll();
            this.cauHois = cauHoiBUS_HT.getAllCauHoiCauHoi();
            this.cauHoiHienTai = null;
            this.newGiaoVien = GiaoViens;
            this.khois = khoiBUS_HT.GetKhoiAll();


            InitializeComponent();
            this.LoadListView();
            this.loadDoKho();
            this.loadDeThiVaKhoi();
            this.LoadDanhSachKiThi();
        }

        public void GETVALUE(DTO.HT.GiaoVien giaoVien)
        {
            this.newGiaoVien = giaoVien;
        }
        public void GETVALUECAUHOI(List<CauHoi> cauHois, CauHoi cauhoi)
        {
            this.cauHois = cauHois;
            this.cauHoiHienTai = cauhoi;
        }
        //


        // Load
        private void loadDoKho()
        {
            List<DoKho> doKhos = doKhoBUS_HT.getAll();
            foreach (var dokho in doKhos)
            {
                comboxDoKho.Items.Add(dokho.TenDoKho);
            }
        }

        private void LoadDeThi(string TenKhoi)
        {
            this.comboDeThiONQuyenLyDeThi.Items.Clear();
            int MaKhoi = -1;
            foreach (var mem in khoiBUS_HT.GetKhoiAll())
            {
                if (mem.TenKhoi == TenKhoi)
                {
                    MaKhoi = mem.MaKhoi;
                    break;
                }
            }
            this.des = deBUS_HT.getAllMaKhoi(MaKhoi);
            this.de = des[0];
            foreach (var de in des)
            {
                comboDeThiONQuyenLyDeThi.Items.Add(de.TenDe);
            }

            this.comboDeThiONQuyenLyDeThi.Text = de.TenDe;
        }
        private void loadDeThiVaKhoi() // Load lý đề thi
        {
            this.comboKhoiONQuyenLyDeThi.Items.Clear();
            this.khois = khoiBUS_HT.GetKhoiAll();
            this.khoiInDeThi = khois[0];
            foreach (var khoi in khois)
            {
                comboKhoiONQuyenLyDeThi.Items.Add(khoi.TenKhoi);
            }
            this.comboKhoiONQuyenLyDeThi.Text = khoiInDeThi.TenKhoi;

            this.LoadDeThi(this.comboKhoiONQuyenLyDeThi.Text);

        }
        private void LoadListView()// Load danh sách câu hỏi
        {
            this.listCauHoi.Clear();
            listCauHoi.View = View.Details;

            listCauHoi.Columns.Add("Mã câu hỏi");
            listCauHoi.Columns.Add("Nội dung câu hỏi");
            listCauHoi.Columns.Add("Độ khó");
            listCauHoi.Columns.Add("Khối");
            listCauHoi.Columns[0].Width = 100;
            listCauHoi.Columns[1].Width = 400;
            listCauHoi.Columns[2].Width = 80;
            listCauHoi.Columns[3].Width = 80;

            foreach (CauHoi giaovien in cauHois)
            {
                ListViewItem item = new ListViewItem();
                item.Text = giaovien.MaCauHoi.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = giaovien.NoiDung });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = giaovien.DoKho1.TenDoKho });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = giaovien.Khoi.TenKhoi });
                listCauHoi.Items.Add(item);
            }
            this.LoadDanhSachCauhoi();

        }
        void DatabingTemp()
        {

            Binding bindingNoiDungCauHoi = new Binding("Text", cauHoiHienTai, "NoiDung", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCauHoi.DataBindings.Add(bindingNoiDungCauHoi);
            Binding bindingCauACauHoi = new Binding("Text", cauHoiHienTai, "CauA", true, DataSourceUpdateMode.OnPropertyChanged);
            radioCauA.DataBindings.Add(bindingCauACauHoi);
            Binding bindingCauBCauHoi = new Binding("Text", cauHoiHienTai, "CauB", true, DataSourceUpdateMode.OnPropertyChanged);
            radioCauB.DataBindings.Add(bindingCauBCauHoi);
            Binding bindingCauCCauHoi = new Binding("Text", cauHoiHienTai, "CauC", true, DataSourceUpdateMode.OnPropertyChanged);
            radioCauC.DataBindings.Add(bindingCauCCauHoi);
            Binding bindingCauDCauHoi = new Binding("Text", cauHoiHienTai, "CauD", true, DataSourceUpdateMode.OnPropertyChanged);
            radioCauD.DataBindings.Add(bindingCauDCauHoi);
            Binding bindingKhoiCauHoi = new Binding("Text", cauHoiHienTai, "Khoi.TenKhoi", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxKhoi.DataBindings.Add(bindingKhoiCauHoi);
            Binding bindingDoKhoCauHoi = new Binding("Text", cauHoiHienTai, "DoKho1.TenDoKho", true, DataSourceUpdateMode.OnPropertyChanged);
            comboxDoKho.DataBindings.Add(bindingDoKhoCauHoi);

        }
        private void LoadDanhSachCauHoi(int MaKhoi, string MaDe) //Load danh sách quản lý đề thi 
        {
            listViewCauHoiOnMaDeAndKhoi.Clear();
            listViewCauHoiOnMaDeAndKhoi.View = View.Details;
            listViewCauHoiOnMaDeAndKhoi.Columns.Add("Mã câu hỏi");
            listViewCauHoiOnMaDeAndKhoi.Columns.Add("Nội dung câu hỏi");
            listViewCauHoiOnMaDeAndKhoi.Columns.Add("Độ khó");
            listViewCauHoiOnMaDeAndKhoi.Columns.Add("Khối");
            listViewCauHoiOnMaDeAndKhoi.Columns[0].Width = 100;
            listViewCauHoiOnMaDeAndKhoi.Columns[1].Width = 400;
            listViewCauHoiOnMaDeAndKhoi.Columns[2].Width = 80;
            listViewCauHoiOnMaDeAndKhoi.Columns[3].Width = 80;
            cauHoiTrongDeNao = cauHoiTrongDeNaoBUS_HT.getAllCauHoiTrongDe(MaDe, MaKhoi);
            if (cauHoiTrongDeNao == null)
            {
                return;
            }
            foreach (var cauhoi in cauHoiTrongDeNao.listCauHoiOnMaDe)
            {
                ListViewItem item = new ListViewItem();
                item.Text = cauhoi.MaCauHoi.ToString();

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cauhoi.NoiDung });
                foreach (var mem2 in doKhos)
                {
                    if (mem2.maDoKho == cauhoi.DoKho)
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem2.TenDoKho });
                    }
                }
                foreach (var mem1 in khois)
                {
                    if (mem1.MaKhoi == cauhoi.MaKhoi)
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem1.TenKhoi });
                    }
                }
                listViewCauHoiOnMaDeAndKhoi.Items.Add(item);
            }

        }
        private void GiaoVienGUI_Load(object sender, EventArgs e)// Load giáo viên GUI
        {
            Binding binding = new Binding("Text", newGiaoVien, "HoTen", true, DataSourceUpdateMode.OnPropertyChanged);
            lbNameGiaoVien.DataBindings.Add(binding);
            if (cauHoiHienTai != null)
            {
                this.DatabingTemp();
            }
        }
        void LoadDanhSachCauhoi()//Load một câu hỏi
        {
            if (cauHoiHienTai == null)
            {
                return;
            }
            txtMaCauHoi.Text = cauHoiHienTai.MaCauHoi.ToString();
            txtCauHoi.Text = cauHoiHienTai.NoiDung;
            radioCauA.Text = cauHoiHienTai.CauA;
            radioCauB.Text = cauHoiHienTai.CauB;
            radioCauC.Text = cauHoiHienTai.CauC;
            radioCauD.Text = cauHoiHienTai.CauD;
            comboBoxKhoi.Text = cauHoiHienTai.Khoi.TenKhoi;
            comboxDoKho.Text = cauHoiHienTai.DoKho1.TenDoKho;
            if (cauHoiHienTai.CauDung == "A    ")
            {
                radioCauA.Checked = true;
            }
            if (cauHoiHienTai.CauDung == "B    ")
            {
                radioCauB.Checked = true;
            }
            if (cauHoiHienTai.CauDung == "C    ")
            {
                radioCauC.Checked = true;
            }
            if (cauHoiHienTai.CauDung == "D    ")
            {
                radioCauD.Checked = true;
            }
        }
        //


        // Thong ke cau hoi
        private void btnAddCauHoi_Click(object sender, EventArgs e)
        {
            AddCauHoi addCauHoi = new AddCauHoi();
            addCauHoi.ShowDialog();
            listCauHoi.Clear();
            this.LoadListView();
        }
        private void btnDuyetCauHoi_Click(object sender, EventArgs e)
        {

        }
        private void UpdateCauHoi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaCauHoi.Text) == true)
            {
                MessageBox.Show("Không thể chỉnh sửa vì chưa có mã câu hỏi . Vui lòng chọn câu hỏi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdateCauHoi updateCauHoi = new UpdateCauHoi(this.cauHois, this.cauHoiHienTai);
            updateCauHoi.truyenquabenkialai = new UpdateCauHoi.GETDATE(this.GETVALUECAUHOI);
            updateCauHoi.ShowDialog();
            foreach (var mem in cauHois)
            {
                if (mem.MaCauHoi == cauHoiHienTai.MaCauHoi)
                {
                    cauHoiHienTai = mem;
                }
            }
            this.listCauHoi.Clear();
            this.LoadListView();
            if (cauHoiHienTai.CauDung == "A    ")
            {
                radioCauA.Checked = true;
            }
            if (cauHoiHienTai.CauDung == "B    ")
            {
                radioCauB.Checked = true;
            }
            if (cauHoiHienTai.CauDung == "C    ")
            {
                radioCauC.Checked = true;
            }
            if (cauHoiHienTai.CauDung == "D    ")
            {
                radioCauD.Checked = true;
            }
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
                if (!Int32.TryParse(item.Text, out tempMaCauHoi))
                {
                    MessageBox.Show("Lối . ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tempMaCauHoi = Int16.Parse(item.Text);
                foreach (var mem in cauHois)
                {
                    if (mem.MaCauHoi == tempMaCauHoi)
                    {
                        cauHoiHienTai = mem;
                        break;
                    }
                }
                if (this.cauHoiHienTai == null)
                {
                    MessageBox.Show("Lỗi không tìm thấy câu hỏi .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtMaCauHoi.Text = cauHoiHienTai.MaCauHoi.ToString();
                txtCauHoi.Text = cauHoiHienTai.NoiDung;
                radioCauA.Text = cauHoiHienTai.CauA;
                radioCauB.Text = cauHoiHienTai.CauB;
                radioCauC.Text = cauHoiHienTai.CauC;
                radioCauD.Text = cauHoiHienTai.CauD;
                comboBoxKhoi.Text = cauHoiHienTai.Khoi.TenKhoi;
                comboxDoKho.Text = cauHoiHienTai.DoKho1.TenDoKho;
                if (cauHoiHienTai.CauDung == "A    ")
                {
                    radioCauA.Checked = true;
                }
                if (cauHoiHienTai.CauDung == "B    ")
                {
                    radioCauB.Checked = true;
                }
                if (cauHoiHienTai.CauDung == "C    ")
                {
                    radioCauC.Checked = true;
                }
                if (cauHoiHienTai.CauDung == "D    ")
                {
                    radioCauD.Checked = true;
                }
            }
        }
        //


        // Quan ly de thi
        private void btnLoadDanhSachCauHoiONDeThi_Click(object sender, EventArgs e)
        {
            int tempMaKhoi = -1;
            foreach (var mem in khois)
            {
                if (mem.TenKhoi == comboKhoiONQuyenLyDeThi.Text)
                {
                    tempMaKhoi = mem.MaKhoi;
                    break;
                }
            }
            string tempMaDe = "";
            foreach (var mem in des)
            {
                if (mem.TenDe == comboDeThiONQuyenLyDeThi.Text)
                {
                    tempMaDe = mem.MaDe;
                    break;
                }
            }

            this.LoadDanhSachCauHoi(tempMaKhoi, tempMaDe);
        }
        private void listViewCauHoiOnMaDeAndKhoi_Click(object sender, EventArgs e)
        {
            int tempMaCauHoi;
            ListView lsv = sender as ListView;
            ListViewItem item;
            if (lsv.SelectedItems.Count > 0)
            {
                item = lsv.SelectedItems[0];
                if (!Int32.TryParse(item.Text, out tempMaCauHoi))
                {
                    MessageBox.Show("Lối . ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tempMaCauHoi = Int16.Parse(item.Text);
                foreach (var mem in cauHois)
                {
                    if (mem.MaCauHoi == tempMaCauHoi)
                    {
                        cauHoiHienTai = mem;
                        break;
                    }
                }
                if (this.cauHoiHienTai == null)
                {
                    MessageBox.Show("Lỗi không tìm thấy câu hỏi .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            UpdateCauHoi updateCauHoi = new UpdateCauHoi(this.cauHois, this.cauHoiHienTai);
            updateCauHoi.truyenquabenkialai = new UpdateCauHoi.GETDATE(this.GETVALUECAUHOI);
            updateCauHoi.ShowDialog();
            foreach (var mem in cauHois)
            {
                if (mem.MaCauHoi == cauHoiHienTai.MaCauHoi)
                {
                    cauHoiHienTai = mem;
                }
            }
            this.listViewCauHoiOnMaDeAndKhoi.Clear();
            int tempMaKhoi = -1;
            foreach (var mem in khois)
            {
                if (mem.TenKhoi == comboKhoiONQuyenLyDeThi.Text)
                {
                    tempMaKhoi = mem.MaKhoi;
                    break;
                }
            }
            string tempMaDe = "";
            foreach (var mem in des)
            {
                if (mem.TenDe == comboDeThiONQuyenLyDeThi.Text)
                {
                    tempMaDe = mem.MaDe;
                    break;
                }
            }
            this.LoadDanhSachCauHoi(tempMaKhoi, tempMaDe);
        }
        private void btnUpdateDanhSachCauHoiONDeThi_Click(object sender, EventArgs e)
        {
            if (cauHoiTrongDeNao == null)
            {
                MessageBox.Show("Lỗi");
                return;
            }
            ChinhSuaDeThiGUI chinhSuaDeThiGUI = new ChinhSuaDeThiGUI(cauHoiTrongDeNao);
            chinhSuaDeThiGUI.ShowDialog();
            this.LoadDanhSachCauHoi(cauHoiTrongDeNao.MaKhoi, cauHoiTrongDeNao.MaDe);
        }
        private void btnAddTDeThi_Click(object sender, EventArgs e)
        {
            AddThemDeThiGUI addThemDeThiGUI = new AddThemDeThiGUI();
            addThemDeThiGUI.ShowDialog();
            this.loadDeThiVaKhoi();
        }
        //

        // Quản lý giáo viên
        private void btnUpdateGiaoVien_Click(object sender, EventArgs e)
        {
            CapNhatGiaoVienGUI capNhatGiaoVien = new CapNhatGiaoVienGUI(this.newGiaoVien);
            capNhatGiaoVien.truyenquabenkialai = new CapNhatGiaoVienGUI.GETDATE(this.GETVALUE);
            capNhatGiaoVien.ShowDialog();

        }
        //

        // Quản lý kì thi
        private void btnThemKiThi_Click(object sender, EventArgs e)
        {
            ThemKiThi themKiThi = new ThemKiThi();
            themKiThi.ShowDialog();
            this.LoadChiTietKiThi();
        }

        // Load Tam xam
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void listViewCauHoiOnMaDeAndKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tabThongKeHocSinh_Click(object sender, EventArgs e)
        {

        }

        private void comboDeThiONQuyenLyDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboKhoiONQuyenLyDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadDeThi(comboKhoiONQuyenLyDeThi.Text);
        }

        private void btnXoaDeThi_Click(object sender, EventArgs e)
        {
            int MaKhoi = -1;
            DAO.HT.DeDAO deDAO = new DAO.HT.DeDAO();
            foreach (var mem in khoiBUS_HT.GetKhoiAll())
            {
                if (mem.TenKhoi == comboKhoiONQuyenLyDeThi.Text)
                {
                    MaKhoi = mem.MaKhoi;
                }
            }
            foreach (var mem in deBUS_HT.getAllMaKhoi(MaKhoi))
            {
                if (mem.TenDe == comboDeThiONQuyenLyDeThi.Text)
                {
                    bool thanhconghaykhong = deDAO.DeleteDeOnMaDeAndMaKhoi(mem.MaDe, MaKhoi);
                    if (thanhconghaykhong == true)
                    {
                        MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadDeThi(comboKhoiONQuyenLyDeThi.Text);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        //

        // QuanLyKiThi
        private void LoadDanhSachKiThi()
        {
            this.ListViewQuanLyKiThi.Clear();
            ListViewQuanLyKiThi.View = View.Details;

            ListViewQuanLyKiThi.Columns.Add("Mã ki thi");
            ListViewQuanLyKiThi.Columns.Add("Tên kì thi");
            ListViewQuanLyKiThi.Columns.Add("Ngày thi");
            ListViewQuanLyKiThi.Columns[0].Width = 100;
            ListViewQuanLyKiThi.Columns[1].Width = 100;
            ListViewQuanLyKiThi.Columns[2].Width = 100;
            var getAllKiThi = DB.KyThis;
            foreach (var mem in getAllKiThi)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mem.MaKyThi.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.TenKyThi });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.NgayThi.ToString() });
                ListViewQuanLyKiThi.Items.Add(item);
            }

        }

        private void tabQuanLyKiThi_Click(object sender, EventArgs e)
        {

        }

        private void LoadChiTietKiThi()
        {
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var find = from k in DB.DeVaKhoiTrongKyThis
                           join r in DB.HocSinhTrongKiThis on k.MaDeVaKhoiTrongKyThi equals r.MaDeVaKhoiTrongKiThi
                           where k.MaKyThi == MaKiThi
                           select new { k, r };


                var find2 = DB.KyThis.Where(r => r.MaKyThi == MaKiThi).Single();

                this.ChiTietKiThi.Clear();
                ChiTietKiThi.View = View.Details;

                ChiTietKiThi.Columns.Add("Ma đề thi");
                ChiTietKiThi.Columns.Add("Học sinh thi");
                ChiTietKiThi.Columns.Add("Điểm");
                ChiTietKiThi.Columns.Add("Mã khôi");
                ChiTietKiThi.Columns[0].Width = 100;
                ChiTietKiThi.Columns[1].Width = 100;
                ChiTietKiThi.Columns[2].Width = 100;
                ChiTietKiThi.Columns[3].Width = 100;
                foreach (var mem in find)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = mem.k.MaDe.ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.r.HocSinh.HoTen });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.r.Diem.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = mem.k.MaKhoi.ToString() });
                    ChiTietKiThi.Items.Add(item);
                }
                MaKiThiLb.Text = MaKiThi;
                TenKiThiLB.Text = find2.TenKyThi;
                NgayThi.Text = find2.NgayThi.ToString();
            }
        }
        

        private void ListViewQuanLyKiThi_Click(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            ListViewItem item;
            if (lsv.SelectedItems.Count > 0)
            {
                item = lsv.SelectedItems[0];

                this.MaKiThi = item.Text;
                this.LoadChiTietKiThi();
            }
        }

        private void ChiTietKiThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaKiThi_Click(object sender, EventArgs e)
        {
            var find = DB.DeVaKhoiTrongKyThis.Where(r => r.MaKyThi == MaKiThi);
            if (find.Count() != 0)
            {
                MessageBox.Show("Đề này đã được sử dụng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                    using(DataContextDataContext DB =new DataContextDataContext())
                    {
                    var find2 = DB.KyThis.Where(r => r.MaKyThi == MaKiThi).Single();
                    DB.KyThis.DeleteOnSubmit(find2);
                        DB.SubmitChanges();
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                this.LoadDanhSachKiThi();
            }
        }
    }
}