using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.HT;
using DTO.HT;

namespace BUS.HT
{
    public class CauHoiBUS_HT
    {
        CauHoiDAO cauHoiDAO = new CauHoiDAO();
        public List<CauHoi> getAllCauHoi()
        {
            return cauHoiDAO.getAllCauHoi();
        }
    }
}
