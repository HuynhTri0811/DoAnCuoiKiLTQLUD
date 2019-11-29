using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinhTrongKiThiDTO
    {
        private string _maHocSinh;
        public string MaHocSinh
        {
            get { return _maHocSinh; }
            set { _maHocSinh = value; }
        }

        private string _maDeVaKhoiTrongKiThi;
        public string MaDeVaKhoiTrongKiThi
        {
            get { return _maDeVaKhoiTrongKiThi; }
            set { _maDeVaKhoiTrongKiThi = value; }
        }

        private float _diem;
        public float Diem
        {
            get { return _diem; }
            set { _diem = value; }
        }
    }
}
