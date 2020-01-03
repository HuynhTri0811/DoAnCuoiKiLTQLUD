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
    public partial class ThemKiThi : Form
    {

        KiThiBUS kiThiBUS = new KiThiBUS();


        public ThemKiThi()
        {
            InitializeComponent();
            this.LoadComboBoxKiThi();
            
        }

        void LoadComboBoxKiThi()
        {
            comboBoxThemKiThiKT.Items.Add("15");
            comboBoxThemKiThiKT.Items.Add("1T");
            comboBoxThemKiThiKT.Items.Add("CK");
            comboBoxThemKiThiKT.SelectedIndex = 0;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm kì thi", "Thông tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.Cancel)
            {
                return;
            }
            int temp =  kiThiBUS.InsertKiThi(comboBoxThemKiThiKT.Text, comboBoxThemKiThiKT.Text, dateTimeThi.Value.Date);
            if(temp == 1)
            {
                MessageBox.Show("Lỗi , mã kiểm tra phải là 15 hoặc 1T hoặc CK", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(temp == 2)
            {
                MessageBox.Show("Lỗi , đã tồn tại Mã Kì Thi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KyThi kiThi = kiThiBUS.GetOneKiThiCuoiCung(comboBoxThemKiThiKT.Text);
            DanhSachDeTrongKiThi danhSachDeTrongKiThi = new DanhSachDeTrongKiThi(kiThi);
            danhSachDeTrongKiThi.ShowDialog();
        }

        private void ThemKiThi_Load(object sender, EventArgs e)
        {

        }
    }
}
