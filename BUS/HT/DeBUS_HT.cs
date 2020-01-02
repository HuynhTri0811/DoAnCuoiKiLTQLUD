using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DAO.HT;
using DAO;

namespace BUS.HT
{
    public class DeBUS_HT
    {
        public DeDAO deDAO = new DeDAO();

        public List<De> getAllMaKhoi(int MaKhoi)
        {
            return deDAO.getAllMaKhoi(MaKhoi);
        }
        public List<De> getAllDe()
        {
            return deDAO.getAllDe();
        }
        public int InsertDe(string TenDe, int MaKhoi, string DoKho)
        {
            return deDAO.InsertDe(TenDe, MaKhoi, DoKho);
        }
        public De getONeDeOnMaDEMoiTao(int MaKhoi)
        {
            /*
             * Tìm đề thông qua mã đề
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về đề
             */
            return deDAO.getONeDeOnMaDEMoiTao(MaKhoi);
        }
    }
}
