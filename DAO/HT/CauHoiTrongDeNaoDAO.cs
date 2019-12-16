using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DTO;

namespace DAO.HT
{
    
    public class CauHoiTrongDeNaoDAO
    {
        DataContextDataContext DB = new DataContextDataContext();

        public List<CauHoiTrongDeNao> getAllCauHoiTrongDeNao()
        {
            /*
             * lấy ra toàn bộ danh sách câu hỏi trong đề nào 
             */
            List<CauHoiTrongDeNao> cauHoiTrongDeNaos = new List<CauHoiTrongDeNao>();
            var findAllCauHoi = from CHTDN in DB.CauHoiTrongDeNaos
                                select CHTDN;
            foreach(var mem in findAllCauHoi)
            {
                cauHoiTrongDeNaos.Add(mem);
            }return cauHoiTrongDeNaos;
        }

        public DeVaCauHoiOnMaDeDTO getAllCauHoiTrongDe(string MaDe,int MaKhoi)
        {
            /*
             * Tìm Câu hỏi trong đề nào
             * Nếu không tìm tấy Mã đề và mã khối  trong CSDL -> trả về null
             * Nếu tìm thấy -> trả về Mã đề + List cau hỏi
             */

            DeVaCauHoiOnMaDeDTO getAllCauHoiOnMaDe = new DeVaCauHoiOnMaDeDTO();
            var findMaDe = from D in DB.CauHoiTrongDeNaos
                           where D.MaDe == MaDe && D.MaKhoi == MaKhoi
                           select D;
            if(findMaDe.Count() == 0)
            {
                return null;
            }
            int tempCount = 0;
            foreach(var mem in findMaDe)
            {
                if(tempCount == 0)
                {
                    getAllCauHoiOnMaDe.MaDe = mem.MaDe;
                    getAllCauHoiOnMaDe.MaKhoi = mem.MaKhoi;
                    tempCount++;
                }
                getAllCauHoiOnMaDe.listCauHoiOnMaDe.Add(mem.CauHoi);
            }
            return getAllCauHoiOnMaDe;
        }
    }
}
