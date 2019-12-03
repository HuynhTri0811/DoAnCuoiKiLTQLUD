using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DAO.HT;

namespace BUS.HT
{
    public class KhoiBUS_HT
    {
        DAO.HT.KhoiDAO KhoiDAO = new KhoiDAO();

        public List<Khoi> GetKhoiAll()
        {
            return KhoiDAO.GetKhoiAll();
        }

        public string getNameKhoi(int MaKhoi)
        {
            return KhoiDAO.getNameKhoi(MaKhoi);
        }

        public Khoi FindKhoiOnMaKhoi(int MaKhoi)
        {
            return KhoiDAO.FindKhoiOnMaKhoi(MaKhoi);
        }

    }
}
