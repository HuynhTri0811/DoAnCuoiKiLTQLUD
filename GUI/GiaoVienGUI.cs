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

namespace GUI
{
    public partial class GiaoVienGUI : Form
    {
        public GiaoVienGUI()
        {
            InitializeComponent();
            
        }

        private void GiaoVienGUI_Load(object sender, EventArgs e)
        {
        }

        private void btnUpdateGiaoVien_Click(object sender, EventArgs e)
        {
            CapNhatGiaoVienGUI capNhatGiaoVien = new CapNhatGiaoVienGUI();
            capNhatGiaoVien.ShowDialog();
        }
    }
}
