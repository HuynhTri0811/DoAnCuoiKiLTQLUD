using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.HT;
using DTO.HT;
using DTO;

namespace BUS.HT
{
    public class CauHoiBUS_HT
    {
        CauHoiDAO cauHoiDAO = new CauHoiDAO();
        public List<CauHoiGiaoVien> getAllCauHoi()
        {
            return cauHoiDAO.getAllCauHoi();
        }

        public CauHoiGiaoVien getOneCauHoiONMaCauHoi(int MaCauHoi)
        {
            return cauHoiDAO.getOneCauHoiONMaCauHoi(MaCauHoi);
        }
    }
}
