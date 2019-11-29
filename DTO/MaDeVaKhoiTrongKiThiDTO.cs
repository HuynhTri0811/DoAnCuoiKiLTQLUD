using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaDeVaKhoiTrongKiThiDTO
    {
        private string _maDeVaKhoiTrongKiThi;
        public string MaDeVaKhoiTrongKiThi
        {
            get { return _maDeVaKhoiTrongKiThi; }
            set { _maDeVaKhoiTrongKiThi = value; }
        }


        private string _maKiThi;
        public string MaKiThi
        {
            get { return _maKiThi; }
            set { _maKiThi = value; }
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
    }
}
