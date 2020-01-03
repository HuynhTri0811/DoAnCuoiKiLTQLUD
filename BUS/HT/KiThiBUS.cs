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
        KyThiDAO kiThiDAO = new KyThiDAO();

        public int InsertKiThi(string MaKT, string TenKiThi, DateTime ThoiGianThi)
        {
            return kiThiDAO.InsertKyThi(MaKT, TenKiThi, ThoiGianThi);
        }
        public KyThi GetOneKiThiCuoiCung(string KT)
        {
            return kiThiDAO.GetOneKyThiCuoiCung(KT);
        }
    }
}
