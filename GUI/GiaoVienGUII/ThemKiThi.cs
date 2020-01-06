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
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("GK", "Kiểm tra giữa kỳ");
            test.Add("CK", "Kiểm tra cuối kỳ");
            comboBoxThemKiThiKT.DataSource = new BindingSource(test, null);
            comboBoxThemKiThiKT.DisplayMember = "Value";
            comboBoxThemKiThiKT.ValueMember = "Key";
 
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
            int temp =  kiThiBUS.InsertKiThi(comboBoxThemKiThiKT.SelectedValue.ToString(), comboBoxThemKiThiKT.Text, dateTimeThi.Value.Date);
            if(temp == 1)
            {
                MessageBox.Show("Lỗi , mã kiểm tra phải là GK hoặc CK", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(temp == 2)
            {
                MessageBox.Show("Lỗi , đã tồn tại Mã Kì Thi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KyThi kiThi = kiThiBUS.GetOneKiThiCuoiCung(comboBoxThemKiThiKT.SelectedValue.ToString());
            DanhSachDeTrongKiThi danhSachDeTrongKiThi = new DanhSachDeTrongKiThi(kiThi);
            danhSachDeTrongKiThi.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void ThemKiThi_Load(object sender, EventArgs e)
        {

        }
    }
}
