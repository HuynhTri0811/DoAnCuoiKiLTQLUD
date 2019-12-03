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

namespace GUI
{
    public partial class GiaoVienGUI : Form
    {
        GiaoVien newGiaoVien;
        public GiaoVienGUI(GiaoVien GiaoViens)
        {
            InitializeComponent();
            newGiaoVien = GiaoViens;
        }

        private void GiaoVienGUI_Load(object sender, EventArgs e)
        {
            lbNameGiaoVien.Text = newGiaoVien.HoTen;
        }

        private void btnUpdateGiaoVien_Click(object sender, EventArgs e)
        {
            CapNhatGiaoVienGUI capNhatGiaoVien = new CapNhatGiaoVienGUI(newGiaoVien);
            capNhatGiaoVien.ShowDialog();
        }
    }
}
