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
using BUS.HT;
using BUS;

namespace GUI.GiaoVien
{
    public partial class UpdateCauHoi : Form
    {
        DoKhoBUS_HT doKhoBUS_HT = new DoKhoBUS_HT();
        KhoiBUS_HT khoiBUS_HT = new KhoiBUS_HT();
        CauHoiBUS_HT cauHoiBUS_HT = new CauHoiBUS_HT();
        public List<CauHoi> cauHois;
        public CauHoi cauHoi;
        private List<DoKho> dokhobus = new List<DoKho>();
        private List<Khoi> khois = new List<Khoi>();
        public delegate void GETDATE(List<CauHoi> cauHoi,CauHoi MaCauHoi);
        public GETDATE truyenquabenkialai;
        DataContextDataContext DB = new DataContextDataContext();
        public UpdateCauHoi(List<CauHoi> cauhoi,CauHoi cauHoi)
        {
            dokhobus = doKhoBUS_HT.getAll();
            khois = khoiBUS_HT.GetKhoiAll();
            cauHois = cauhoi;
            this.cauHoi = cauHoi;
            InitializeComponent();
            this.LoadCauHoi();
        }

        private void LoadCauHoi()
        {
            txtNoiDung.Text = cauHoi.NoiDung;
            txtCauA.Text = cauHoi.CauA;
            txtCauB.Text = cauHoi.CauB;
            txtCauC.Text = cauHoi.CauC;
            txtCauD.Text = cauHoi.CauD;
            cbCauDung.Text = cauHoi.CauDung;
            cbDoKho.Text = cauHoi.DoKho1.TenDoKho;
            cbKhoi.Text = cauHoi.Khoi.TenKhoi;

            foreach(var mem in dokhobus)
            {
                cbDoKho.Items.Add(mem.TenDoKho);
                
            }
            foreach(var mem in khois)
            {
                cbKhoi.Items.Add(mem.TenKhoi);
            }
            cbCauDung.Items.Add("A    ");
            cbCauDung.Items.Add("B    ");
            cbCauDung.Items.Add("C    ");
            cbCauDung.Items.Add("D    ");
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc là muốn chỉnh sửa ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.No)
            {
                return;
            }

            if (String.IsNullOrEmpty(txtNoiDung.Text) == true)
            {
                MessageBox.Show("Không được để nội dung trống . Xin mời nhập lại", "Lối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtCauA.Text) == true)
            {
                MessageBox.Show("Không được để câu A trống . Xin mời nhập lại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtCauB.Text) == true)
            {
                MessageBox.Show("Không được để câu B trống . Xin mời nhập lại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtCauC.Text) == true)
            {
                MessageBox.Show("Không được để câu C trống . Xin mời nhập lại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtCauD.Text) == true)
            {
                MessageBox.Show("Không được để câu D trống . Xin mời nhập lại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Khoi MaKhoi = new Khoi();
            DoKho doKho = new DoKho();
            foreach (var b in khois)
            {
                if (b.TenKhoi == cbKhoi.Text)
                {
                    MaKhoi = b;
                    break;
                }
            }
            foreach (var c in dokhobus)
            {
                if (c.TenDoKho == cbDoKho.Text)
                {
                    doKho = c;
                    break;
                }
            }
            int ThanhCong = cauHoiBUS_HT.UpdateCauHoi(cauHoi.MaCauHoi,txtNoiDung.Text, txtCauA.Text, txtCauB.Text, txtCauC.Text, txtCauD.Text, cbCauDung.Text, MaKhoi.MaKhoi, doKho.maDoKho);  
            if (ThanhCong == 0)
            {
                
                foreach(var mem in cauHois)
                {
                    if(this.cauHoi.MaCauHoi == mem.MaCauHoi)
                    {
                        mem.NoiDung = txtNoiDung.Text;
                        mem.CauA = txtCauA.Text;
                        mem.CauB = txtCauB.Text;
                        mem.CauC = txtCauC.Text;
                        mem.CauD = txtCauD.Text;
                        mem.CauDung = cbCauDung.Text;
                        mem.DoKho1 = doKho;
                        mem.Khoi = MaKhoi;
                    }
                }
                truyenquabenkialai(this.cauHois,cauHoi);
                MessageBox.Show("Thành Công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ThanhCong == 1)
            {
                MessageBox.Show("Lối nằm ở chỗ không thêm được đáp án", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ThanhCong == 2)
            {
                MessageBox.Show("Lối không tìm thấy mã khối", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ThanhCong == 3)
            {
                MessageBox.Show("Lối không tìm thấy độ khó", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ThanhCong == 4)
            {
                MessageBox.Show("Bạn chưa chỉnh sửa gì để update .", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ThanhCong == 5)
            {
                MessageBox.Show("Mã câu hỏi chưa tồn tại trong bảng câu hỏi .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ThanhCong == 6)
            {
                MessageBox.Show("Nội dung trùng với câu nào đó trong bảng câu hỏi ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateCauHoi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
