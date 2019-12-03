using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;

namespace DAO.HT
{
    public class KhoiDAO
    {
        DataContextDataContext DB = new DataContextDataContext();

        public List<Khoi> GetKhoiAll()
        {
            /*
             * Lấy trả cả các khối có trong csdl 
             * trả về list<khoi>
             */
            List<Khoi> khois = new List<Khoi>();

            var getKhois = from khoi in DB.Khois
                           select khoi;

            foreach(var khoi in getKhois)
            {
                khois.Add(khoi);
            }

            return khois;
        }

        public string getNameKhoi(int MaKhoi)
        {
            /*
             * Tìm kiếm tên của khối thông qua mã khối
             * Nếu không tìm thấy trả về null
             * Nếu tìm thấy trả về tên của khoi
             */

            string nameKhoi = null;

            var khoiName =  from khoi in DB.Khois
                            where khoi.MaKhoi == MaKhoi
                            select khoi;
            if(khoiName.Count() == 0)
            {
                return null;
            }

            foreach(var khoi in khoiName)
            {
                nameKhoi = khoi.TenKhoi;
            }

            return nameKhoi;
        }

        public Khoi FindKhoiOnMaKhoi(int MaKhoi)
        {

            /*
             * tìm khối trả về khoi 
             * nếu không tìm thấy -> trả về null
             * Nếu tìm thấy trả về khoi
             */
            Khoi khoiOne = new Khoi();

            var khois = from khoi in DB.Khois
                        where khoi.MaKhoi == MaKhoi
                        select khoi;
            if(khois.Count() == 0)
            {
                return null;
            }
            foreach(var khoi in khois)
            {
                khoiOne = khoi;
            }
            return khoiOne;
        }
    }
}
