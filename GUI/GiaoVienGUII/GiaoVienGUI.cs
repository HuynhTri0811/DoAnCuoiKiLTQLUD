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

namespace GUI
{
    public partial class GiaoVienGUI : Form
    {
        public DTO.HT.GiaoVien newGiaoVien;
        int MaCauHoi;
        GiaoVienBUS_HT giaoVienBUS_HT = new GiaoVienBUS_HT();
        CauHoiBUS_HT cauHoiBUS_HT = new CauHoiBUS_HT();
        DoKhoBUS_HT doKhoBUS_HT = new DoKhoBUS_HT();
        List<CauHoi> cauHois;
        CauHoi cauHoiHienTai;
        public GiaoVienGUI(DTO.HT.GiaoVien GiaoViens)
        {
            this.cauHois = cauHoiBUS_HT.getAllCauHoiCauHoi();
            this.cauHoiHienTai = this.cauHois[0];
            this.newGiaoVien = GiaoViens;
            
            InitializeComponent();
            this.LoadListView();
            this.loadDoKho();

        }

        public void GETVALUE(DTO.HT.GiaoVien giaoVien)
        {
            this.newGiaoVien = giaoVien;
        }

        public void GETVALUECAUHOI(List<CauHoi> cauHois,CauHoi cauhoi)
        {
            this.cauHois = cauHois;
            this.cauHoiHienTai = cauhoi;
        }

        private void loadDoKho()
        {
            List<DoKho> doKhos=  doKhoBUS_HT.getAll();
            foreach(var dokho in doKhos){
                comboxDoKho.Items.Add(dokho.TenDoKho);
            }
        }



        private void LoadListView()
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

            foreach(CauHoi giaovien in cauHois)
            {
                ListViewItem item = new ListViewItem();
                item.Text = giaovien.MaCauHoi.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = giaovien.NoiDung });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = giaovien.DoKho1.TenDoKho });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = giaovien.Khoi.TenKhoi });
                listCauHoi.Items.Add(item);
            }

        }

        private void GiaoVienGUI_Load(object sender, EventArgs e)
        {
            Binding binding = new Binding("Text", newGiaoVien, "HoTen", true, DataSourceUpdateMode.OnPropertyChanged);
            lbNameGiaoVien.DataBindings.Add(binding);
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


        private void btnUpdateGiaoVien_Click(object sender, EventArgs e)
        {
            CapNhatGiaoVienGUI capNhatGiaoVien = new CapNhatGiaoVienGUI(this.newGiaoVien);
            capNhatGiaoVien.truyenquabenkialai = new CapNhatGiaoVienGUI.GETDATE(this.GETVALUE);
            capNhatGiaoVien.ShowDialog();
            
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
                this.cauHoiHienTai = cauHoiBUS_HT.GetOneCauHoi(tempMaCauHoi);
                if(this.cauHoiHienTai == null)
                {
                    MessageBox.Show("Lỗi không tìm thấy câu hỏi .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtMaCauHoi.Text =  cauHoiHienTai.MaCauHoi.ToString();
                txtCauHoi.Text = cauHoiHienTai.NoiDung;
                radioCauA.Text = cauHoiHienTai.CauA;
                radioCauB.Text = cauHoiHienTai.CauB;
                radioCauC.Text = cauHoiHienTai.CauC;
                radioCauD.Text = cauHoiHienTai.CauD;
                comboBoxKhoi.Text = cauHoiHienTai.Khoi.TenKhoi;
                comboxDoKho.Text = cauHoiHienTai.DoKho1.TenDoKho;  
                if(cauHoiHienTai.CauDung == "A    ")
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

        private void btnDuyetCauHoi_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateCauHoi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaCauHoi.Text) == true)
            {
                MessageBox.Show("Không thể chỉnh sửa vì chưa có mã câu hỏi . Vui lòng chọn câu hỏi","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            UpdateCauHoi updateCauHoi = new UpdateCauHoi(this.cauHois,this.cauHoiHienTai);
            updateCauHoi.truyenquabenkialai = new UpdateCauHoi.GETDATE(this.GETVALUECAUHOI);
            updateCauHoi.ShowDialog();
            foreach(var mem in cauHois)
            {
                if(mem.MaCauHoi == cauHoiHienTai.MaCauHoi)
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

        private void btnAddCauHoi_Click(object sender, EventArgs e)
        {
            AddCauHoi addCauHoi = new AddCauHoi();
            addCauHoi.ShowDialog();
            listCauHoi.Clear();
            this.LoadListView();
        }
    }
}
