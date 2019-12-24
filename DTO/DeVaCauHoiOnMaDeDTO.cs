using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
namespace DTO
{
    public class DeVaCauHoiOnMaDeDTO
    {
        public string MaDe;
        public List<CauHoi> listCauHoiOnMaDe = new List<CauHoi>();
        public int MaKhoi;
    }
}
