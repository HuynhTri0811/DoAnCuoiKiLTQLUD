using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.HT;
using DAO.HT;

namespace BUS.HT
{
    public class CauHoiTrongDeNaoBUS_HT
    {
        DAO.HT.CauHoiTrongDeNaoDAO cauHoiTrongDeNaoDAO = new CauHoiTrongDeNaoDAO();
        public DeVaCauHoiOnMaDeDTO getAllCauHoiTrongDe(string MaDe, int MaKhoi)
        {
            return cauHoiTrongDeNaoDAO.getAllCauHoiTrongDe(MaDe, MaKhoi);
        }

        public int InsertDeVaCauHoi(string MaDe, int MaCauHoi, int MaKhoi)
        {
            return cauHoiTrongDeNaoDAO.InsertDeVaCauHoi(MaDe, MaCauHoi, MaKhoi);
        }

        public List<CauHoi> getAllCauHoiTrongDes(string MaDe, int MaKhoi)
        {
            return cauHoiTrongDeNaoDAO.getAllCauHoiTrongDes(MaDe, MaKhoi);
        }
    }
}
