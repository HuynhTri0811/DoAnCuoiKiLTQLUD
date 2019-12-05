using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.HT;
using DTO.HT;

namespace BUS.HT
{
    public class GiaoVienBUS_HT
    {
        DTO.HT.DataContextDataContext DB = new DataContextDataContext();
        DAO.HT.GiaoVienDAO giaovien = new GiaoVienDAO();

        public GiaoVien findGiaoVien(string Email,string Password)
        {
            return giaovien.FindGiaoVienOnEmailAndPassword(Email,Password);
        }

        public bool UpdateTenGiaoVien(string MaGV,string HoTen)
        {
            return giaovien.UpdateGiaoVienOnHoTen(MaGV, HoTen);
        }

        public GiaoVien FindOneGiaoVienOnMAGV(string MaGV)
        {
            return giaovien.FindOneGiaoVienOnMAGV(MaGV);
        }
    }
}
