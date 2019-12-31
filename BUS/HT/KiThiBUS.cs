using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DAO.HT;

namespace BUS.HT
{
    public class KiThiBUS
    {
        KiThiDAO kiThiDAO = new KiThiDAO();

        public int InsertKiThi(string MaKT, string TenKiThi, DateTime ThoiGianThi)
        {
            return kiThiDAO.InsertKiThi(MaKT, TenKiThi, ThoiGianThi);
        }
    }
}
