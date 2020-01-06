using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.HT;
using DAO.HT;
using DTO.HT;
using ExcelDataReader;
using ExcelDataReader;

namespace GUI
{
    public partial class AddCauHoi : Form
    {
        public KhoiBUS_HT khoiBUS_HT = new KhoiBUS_HT();
        List<Khoi> khois;
        CauHoiBUS_HT cauHoiBUS_HT = new CauHoiBUS_HT();
        DoKhoBUS_HT doKhoBUS_HT = new DoKhoBUS_HT();
        List<DoKho> doKhos;
        List<CauHoi> cauHois = new List<CauHoi>();
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


        DataTableCollection tableCollection;

        private void btnLayFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog() { Filter="Excel Workbook|*.xlsx" })
            {
                if(openFileDialog.ShowDialog()== DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using(var steam = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(steam))
                        {
                            DataSet dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable=(_)=>new ExcelDataTableConfiguration() { UseHeaderRow  = true}
                            });
                            tableCollection = dataSet.Tables;
                            comboBox1.Items.Clear();
                            foreach(DataTable table in tableCollection)
                            {
                                comboBox1.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            if(dt != null)
            {
                List<CauHoi> caus = new List<CauHoi>();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    CauHoi cau = new CauHoi();
                    cau.NoiDung = dt.Rows[i]["NoiDung"].ToString();
                    cau.CauA = dt.Rows[i]["CauA"].ToString();
                    cau.CauB = dt.Rows[i]["CauB"].ToString();
                    cau.CauC = dt.Rows[i]["CauC"].ToString();
                    cau.CauD = dt.Rows[i]["CauD"].ToString();
                    cau.CauDung = dt.Rows[i]["CauDung"].ToString();
                    cau.MaKhoi = Int32.Parse(dt.Rows[i]["MaKhoi"].ToString());
                    cau.HocSinhDongGop = Boolean.Parse(dt.Rows[i]["HocSinhDongGop"].ToString());
                    cau.DoKho = Int32.Parse(dt.Rows[i]["DoKho"].ToString());
                    caus.Add(cau);
                }
                cauHois = caus;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DataContextDataContext DB = new DataContextDataContext())
            {
                DAO.HT.CauHoiDAO cauHoiDAO = new CauHoiDAO();
                if(String.IsNullOrEmpty(txtFileName.Text)== true)
                {
                    MessageBox.Show("File trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrEmpty(comboBox1.Text) == true)
                {
                    MessageBox.Show("sheet trông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var mem in cauHois)
                {
                    if(cauHoiDAO.getCauHoiOnCauHoi(mem.NoiDung) == true)
                    {
                        MessageBox.Show("Câu hỏi có nội dung là :" + mem.NoiDung + " . Đã là tồn tại trong csdl ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        continue;
                    }
                    DB.CauHois.InsertOnSubmit(mem);
                }
                DB.SubmitChanges();
                MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
