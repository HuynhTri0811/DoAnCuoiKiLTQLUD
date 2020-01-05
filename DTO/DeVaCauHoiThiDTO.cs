using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeVaCauHoiThiDTO : DeVaCauHoiDTO
    {
        string _maKyThi;
        public string MaKyThi
        {
            get { return _maKyThi; }
            set { _maKyThi = value; }
        }

        string _tenKyThi;
        public string TenKyThi
        {
            get { return _tenKyThi; }
            set { _tenKyThi = value; }
        }

        DateTime _ngayThi;
        public DateTime NgayThi
        {
            get { return _ngayThi; }
            set { _ngayThi = value; }
        }

        string _maDeVaKhoiTrongKyThi;
        public string MaDeVaKhoiTrongKyThi
        {
            get { return _maDeVaKhoiTrongKyThi; }
            set { _maDeVaKhoiTrongKyThi = value; }
        }       
    }
}
