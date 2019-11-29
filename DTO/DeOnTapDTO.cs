using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeOnTapDTO
    {
        private string _maHocSinh;
        public string MaHocSinh
        {
            get { return _maHocSinh; }
            set { _maHocSinh = value; }
        }

        private string _maDe;
        public string MaDe
        {
            get { return _maDe; }
            set { _maDe = value; }
        }

        private int _maKhoi;
        public int MaKhoi
        {
            get { return _maKhoi; }
            set { _maKhoi = value; }
        }

        private DateTime _ngayGioiHan;
        public DateTime NgayGioiHan
        {
            get { return _ngayGioiHan; }
            set { _ngayGioiHan = value; }
        }

        private float _diem;
        public float Diem
        {
            get { return _diem; }
            set { _diem = value; }
        }
    }
}
