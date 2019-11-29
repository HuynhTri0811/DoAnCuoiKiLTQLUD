using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CauHoiDTO
    {
        private int _maCauHoi;
        public int MaCauHoi
        {
            get { return _maCauHoi; }
            set { _maCauHoi = value; }
        }

        private string _cauHoi;
        public string CauHoi
        {
            get { return _cauHoi; }
            set { _cauHoi = value; }
        }

        private string _cauA;
        public string CauA
        {
            get { return _cauA; }
            set { _cauA = value; }
        }

        private string _cauB;
        public string CauB
        {
            get { return _cauB; }
            set { _cauB = value; }
        }

        private string _cauC;
        public string CauC
        {
            get { return _cauC; }
            set { _cauC = value; }
        }

        private string _cauD;
        public string CauD
        {
            get { return _cauD; }
            set { _cauD = value;  }
        }

        public string _cauDung;
        public string CauDung
        {
            get { return _cauDung; }
            set { _cauDung = value; }
        }

        private int _maKhoi;
        public int MaKhoi
        {
            get { return _maKhoi; }
            set { _maKhoi = value; }
        }
    }
}
