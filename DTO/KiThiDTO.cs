using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KiThiDTO
    {
        private string _maKiThi;
        public string MaKiThi
        {
            get { return _maKiThi; }
            set { _maKiThi = value; }
        }

        private string _tenKiThi;
        public string TenKiThi
        {
            get { return _tenKiThi; }
            set { _tenKiThi = value; }
        }

        private DateTime _ngayThi;
        public DateTime NgayThi
        {
            get { return _ngayThi; }
            set { _ngayThi = value; }
        }
    }
}
