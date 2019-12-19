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
        public List<CauHoi> getAllCauHoiCauHoi()
        {
            return cauHoiDAO.getAllCauHoiCauHoi();
        }

        public CauHoi GetOneCauHoi(int MaCauHoi)
        {
            return cauHoiDAO.GetOneCauHoi(MaCauHoi);
        }

        public CauHoiGiaoVien getOneCauHoiONMaCauHoi(int MaCauHoi)
        {
            return cauHoiDAO.getOneCauHoiONMaCauHoi(MaCauHoi);
        }

        public int UpdateCauHoi(int MaCauHoi, string NoiDung, string CauA, string CauB, string CauC, string CauD, string cauDung, int MaKhoi, int DoKho)
        {
            return cauHoiDAO.UpdateCauHoi(MaCauHoi, NoiDung, CauA, CauB, CauC, CauD, cauDung, MaKhoi, DoKho);
        }

        public int InsertCauHoi(string NoiDung, string CauA, string CauB, string CauC, string CauD, string CauDung, int MaKhoi, int DoKho)
        {
            return cauHoiDAO.InsertCauHoi(NoiDung, CauA, CauB, CauC, CauD, CauDung, MaKhoi, DoKho);
        }

    }
}
