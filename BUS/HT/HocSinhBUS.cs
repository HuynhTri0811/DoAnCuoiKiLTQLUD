using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DAO.HT;
namespace BUS.HT
{
    public class HocSinhBUS
    {
        DAO.HT.HocSinhDAO hocSinhDAO = new HocSinhDAO();
        public List<HocSinh> getAllHocSinhTheoMaKhoi(int Makhoi)
        {
            return hocSinhDAO.getAllHocSinhTheoMaKhoi(Makhoi);
        }
    }
}
