using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;

namespace DAO.HT
{
    public class CauHoiDAO
    {
        DataContextDataContext DB = new DataContextDataContext();

        public List<CauHoi> getAllCauHoi()
        {
            /*
             * Lấy ra danh sách câu hỏi trả về list
             */

            List<CauHoi> cauHois = new List<CauHoi>();

            var cauhois = from cauHoi in DB.CauHois
                          where cauHoi.HocSinhDongGop == false
                          select cauHoi;
            foreach(var cauhoi in cauhois)
            {
                cauHois.Add(cauhoi);
            }
            return cauHois;
        }
    }
}
