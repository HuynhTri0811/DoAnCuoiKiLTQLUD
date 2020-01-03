using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;

namespace DAO.HT
{
    public class HocSinhDAO
    {
        DataContextDataContext DB = new DataContextDataContext();
        public List<HocSinh> getAllHocSinh()
        {
            /*
             * Lấy toàn bộ danh sách học sinh
             * nếu không có =  null
             */

            var getAllHocSinh = from H in DB.HocSinhs
                                select H;
            if(getAllHocSinh.Count() == 0)
            {
                return null;
            }
            return getAllHocSinh.ToList();
            
        }

        public List<HocSinh> getAllHocSinhTheoMaKhoi(int MaKhoi)
        {
            /*
             * Lấy toàn bộ danh sách học sinh
             * nếu không có =  null
             */

            var getAllHocSinh = from H in DB.HocSinhs
                                where H.Lop.MaKhoi == MaKhoi
                                select H;
            if (getAllHocSinh.Count() == 0)
            {
                return null;
            }
            return getAllHocSinh.ToList();

        }
    }
}
