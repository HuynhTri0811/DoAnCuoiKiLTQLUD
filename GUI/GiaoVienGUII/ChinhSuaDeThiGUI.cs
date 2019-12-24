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

namespace GUI.GiaoVienGUII
{
    public partial class ChinhSuaDeThiGUI : Form
    {
        DTO.DeVaCauHoiOnMaDeDTO CauHoiTrongDeNao = new DeVaCauHoiOnMaDeDTO();
        public ChinhSuaDeThiGUI(DTO.DeVaCauHoiOnMaDeDTO cauHoiTrongDeNao)
        {
            InitializeComponent();
            CauHoiTrongDeNao = cauHoiTrongDeNao;
        }

        private void ChinhSuaDeThiGUI_Load(object sender, EventArgs e)
        {
            txtKhoi.Text = CauHoiTrongDeNao.MaKhoi.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
