using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CauHoiTrongDeNaoDTO
    {
        private int _maCauHoi;
        public int MaCauHoi
        {
            get { return _maCauHoi; }
            set { _maCauHoi = value; }
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
