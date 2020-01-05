using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;

namespace DTO
{
    public class DanhSachHocSinhVsDeThi
    {
        public List<HocSinh> hocSinhs { get; set; }
        public string MaKiThi { get; set; }
        public string MaDe { get; set; }
        public int MaKhoi { get; set; }
    }
}
