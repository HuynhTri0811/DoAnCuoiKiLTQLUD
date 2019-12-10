using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DTO;

namespace DAO.HT
{
    public class CauHoiDAO
    {
        DataContextDataContext DB = new DataContextDataContext();

        public List<CauHoiGiaoVien> getAllCauHoi()
        {
            /*
             * Lấy ra danh sách câu hỏi trả về list
             */
            List<CauHoiGiaoVien> cauHois = new List<CauHoiGiaoVien>();

            var cauhois = from cauHoi in DB.CauHois
                          where cauHoi.HocSinhDongGop == false
                          select cauHoi;
            foreach(var cauhoi in cauhois)
            {
                CauHoiGiaoVien temp = new CauHoiGiaoVien();
                temp.MaCauHoi = cauhoi.MaCauHoi;
                temp.NoiDung = cauhoi.NoiDung;
                temp.CauA = cauhoi.CauA;
                temp.CauB = cauhoi.CauB;
                temp.CauC = cauhoi.CauC;
                temp.CauD = cauhoi.CauD;
                temp.CauDung = cauhoi.CauDung;
                temp.DoKhoTen = cauhoi.DoKho1.TenDoKho;
                temp.TenKhoi = cauhoi.Khoi.TenKhoi;

                cauHois.Add(temp);
            }
            return cauHois;
        }

        public CauHoiGiaoVien getOneCauHoiONMaCauHoi(int MaCauHoi)
        {
            CauHoiGiaoVien cauhoi = new CauHoiGiaoVien();

            var CauHoiFind = from CH in DB.CauHois
                             where CH.MaCauHoi == MaCauHoi
                             select CH;
            if(CauHoiFind.Count() == 0)
            {
                return null;
            }

            foreach(var cauhois in CauHoiFind)
            {
                cauhoi.MaCauHoi = cauhois.MaCauHoi;
                cauhoi.NoiDung = cauhois.NoiDung;
                cauhoi.CauA = cauhois.CauA;
                cauhoi.CauB = cauhois.CauB;
                cauhoi.CauC = cauhois.CauC;
                cauhoi.CauD = cauhois.CauD;
                cauhoi.CauDung = cauhois.CauDung;
                cauhoi.DoKhoTen = cauhois.DoKho1.TenDoKho;
                cauhoi.TenKhoi = cauhois.Khoi.TenKhoi;
            }


            return cauhoi;
        }
    }
}
