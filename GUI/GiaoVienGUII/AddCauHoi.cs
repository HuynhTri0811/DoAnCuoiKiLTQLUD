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


namespace GUI
{
    public partial class AddCauHoi : Form
    {
        public KhoiBUS_HT khoiBUS_HT = new KhoiBUS_HT();
        List<Khoi> khois;
        CauHoiBUS_HT cauHoiBUS_HT = new CauHoiBUS_HT();
        DoKhoBUS_HT doKhoBUS_HT = new DoKhoBUS_HT();
        List<DoKho> doKhos;
        public AddCauHoi()
        {
            doKhos = doKhoBUS_HT.getAll();
            khois = khoiBUS_HT.GetKhoiAll();
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCauHoi_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc là muốn thêm ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialog == DialogResult.No)
            {
                return;
            }
            
            if(String.IsNullOrEmpty(txtNoiDungCauHoi.Text) == true)
            {
                MessageBox.Show("Không được để nội dung trống . Xin mời nhập lại", "Lối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(txtNoiDungCauA.Text) == true)
            {
                MessageBox.Show("Không được để câu A trống . Xin mời nhập lại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNoiDungCauB.Text) == true)
            {
                MessageBox.Show("Không được để câu B trống . Xin mời nhập lại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNoiDungCauC.Text) == true)
            {
                MessageBox.Show("Không được để câu C trống . Xin mời nhập lại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNoiDungCauD.Text) == true)
            {
                MessageBox.Show("Không được để câu D trống . Xin mời nhập lại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int MaKhoi = -1;
            int doKho = -1;
            foreach(var b in khois)
            {
                if(b.TenKhoi == cbKhoi.Text)
                {
                    MaKhoi = b.MaKhoi;
                    break;
                }
            }
            foreach(var c in doKhos)
            {
                if(c.TenDoKho == cbboxDoKho.Text)
                {
                    doKho = c.maDoKho;
                }
            }
            int ThanhCong = cauHoiBUS_HT.InsertCauHoi(txtNoiDungCauHoi.Text, txtNoiDungCauA.Text, txtNoiDungCauB.Text, txtNoiDungCauC.Text, txtNoiDungCauD.Text, cbCauDung.Text, MaKhoi, doKho);
            if(ThanhCong == 0)
            {
                MessageBox.Show("Thành Công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNoiDungCauA.Clear();
                txtNoiDungCauB.Clear();
                txtNoiDungCauC.Clear();
                txtNoiDungCauD.Clear();
                txtNoiDungCauHoi.Clear();
                cbKhoi.Text = khois[0].TenKhoi;
                cbCauDung.Text = "A";
                cbboxDoKho.Text = doKhos[0].TenDoKho;
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
                MessageBox.Show("Bạn chưa thay đổi gì để update", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ThanhCong == 5)
            {
                MessageBox.Show("Không tìm thấy mã câu hỏi trong csdl", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AddCauHoi_Load(object sender, EventArgs e)
        {
            foreach(var khoi in khois)
            {
                cbKhoi.Items.Add(khoi.TenKhoi);
            }
            cbKhoi.SelectedIndex = 0;

            cbCauDung.Items.Add("A");
            cbCauDung.Items.Add("B");
            cbCauDung.Items.Add("C");
            cbCauDung.Items.Add("D");
            cbCauDung.SelectedItem = "A";


            foreach(var dokho in doKhos)
            {
                cbboxDoKho.Items.Add(dokho.TenDoKho);
            }
            cbboxDoKho.SelectedIndex = 0;
        }
    }
}
