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
    public partial class AdDeThi : Form
    {
        List<CauHoi> cauHois = new List<CauHoi>();
        DeBUS_HT deBUS_HT = new DeBUS_HT();
        CauHoiTrongDeNaoBUS_HT cauHoiTrongDeNaoBUS_HT = new CauHoiTrongDeNaoBUS_HT();

        public AdDeThi(List<CauHoi> cauHois)
        {
            this.cauHois = cauHois;
            InitializeComponent();
        }

        private void AdDeThi_Load(object sender, EventArgs e)
        {
            comboBoxDoKho.Items.Add("dễ");
            comboBoxDoKho.Items.Add("trung bình");
            comboBoxDoKho.Items.Add("khó");
            comboBoxDoKho.SelectedIndex = 0;
        }

        private void btnAddDeThi_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTenDe.Text) == true)
            {
                MessageBox.Show("Tên đề không thể bỏ trống được");
                return;
            }

            int insertDe = deBUS_HT.InsertDe(txtTenDe.Text, cauHois[0].MaKhoi.GetValueOrDefault(),comboBoxDoKho.Text);
            if(insertDe == 1)
            {
                MessageBox.Show("Lỗi về đề thi");
                return;
            }
            if (insertDe == 3)
            {
                MessageBox.Show("Tồn tại mã đề thi");
                return;
            }
            De de = deBUS_HT.getONeDeOnMaDEMoiTao(cauHois[0].MaKhoi.GetValueOrDefault());
            int temp2 = 0;
            foreach (var mem in this.cauHois)
            {
                temp2++;
                int temp = cauHoiTrongDeNaoBUS_HT.InsertDeVaCauHoi(de.MaDe, mem.MaCauHoi, mem.MaKhoi.GetValueOrDefault());
                if(this.cauHois.Count() == temp2)
                {
                    MessageBox.Show("Thành công . ", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
            return;
            
        }
    }
}
