using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeDTO
    {
        private string _maDe;
        public string MaDe
        {
            get { return _maDe; }
            set { _maDe = value; }
        }

        private string _tenDe;
        public string TenDe
        {
            get { return _tenDe; }
            set { _tenDe = value; }
        }


        private int _maKhoi;
        public int MaKhoi
        {
            get { return _maKhoi; }
            set { _maKhoi = value; }
        }

        private string _doKho;
        public string DoKho
        {
            get { return _doKho; }
            set { _doKho = value; }
        }
    }
}
