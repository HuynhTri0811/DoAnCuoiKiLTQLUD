using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DTO;

namespace DAO.HT
{
    public class DeDAO
    {

        DataContextDataContext DB = new DataContextDataContext();
        public List<De> getAllDe()
        {
            /*
             * lấy toàn bộ đề trong cơ sở dữ liệu
             */

            List<De> allDe = new List<De>();

            var findallDe = from D in DB.Des
                            select D;
            foreach(var mem in findallDe)
            {
                allDe.Add(mem);
            }
            return allDe;
        }

        public De getOneDeOnMaDe(string MaDe)
        {
            /*
             * Tìm đề thông qua mã đề
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về đề
             */
            De de = new De();
            var findOneDeONMaDe = from D in DB.Des
                                  where D.MaDe == MaDe
                                  select D;
            if (findOneDeONMaDe.Count() == 0)
            {
                return null;
            }
            foreach(var mem in findOneDeONMaDe)
            {
                de.MaDe = mem.MaDe;
                de.TenDe = mem.TenDe;
                de.MaKhoi = mem.MaKhoi;
                de.DoKho = mem.DoKho;
            }
            return de;
        }

        public bool DeleteDeOnMaDeAndMaKhoi(string MaDe,int MaKhoi)
        {

            /*
             * Xóa de trong bang de va ma khoi
             * Nếu không tồn tại MaDe va MaKhoi trong bang de -> tra về false
             * Nếu tồn tại và xóa thành công -> trả về true
             */


            var findOneDeOnMaDeVaMaKhoi = from D in DB.Des
                                          where D.MaDe == MaDe && D.MaKhoi == MaKhoi
                                          select D;
            if(findOneDeOnMaDeVaMaKhoi.Count() ==0)
            {
                return false;
            }
            foreach(var mem in findOneDeOnMaDeVaMaKhoi)
            {
                DB.Des.DeleteOnSubmit(mem);
            }
            DB.SubmitChanges();
            return true;
        }

        public int UpdateTenDeOnMaDeAndMaKhoi(string MaDe,int MaKhoi, string TenDe)
        {
            /*
             * Update tên đề dựa trên mã đề và mã khối
             * Nếu không tìm thấy mã đề và mã khối trong csdl -> trả về 1
             * Nếu tìm thấy và update thành công -> trả về 0
             */

            var findOneTenDeOnMaDeAndMaKhoi = from D in DB.Des
                                              where D.MaDe == MaDe && D.MaKhoi == MaKhoi
                                              select D;
            if(findOneTenDeOnMaDeAndMaKhoi.Count() ==0)
            {
                return 1;
            }
            foreach(var mem in findOneTenDeOnMaDeAndMaKhoi)
            {
                mem.TenDe = TenDe;
            }
            DB.SubmitChanges();
            return 0;
        }

        public int UpdateDoKhoOnMaDeAndMaKhoi(string MaDe,int MaKhoi,string DoKho)
        {
            /*
             * Update độ khó của mã đề và mã khối
             * Nếu không tìm thấy MaDe và Mã khối -> trả về 1
             * Nếu độ khó khác dễ hoặc vừa hoặc khó -> trả về 2
             * Update thành công thì trả -> trả về 0
             */

            var findOneDeOnMaDeAndMaKhoi = from D in DB.Des
                                           where D.MaDe == MaDe && D.MaKhoi == MaKhoi
                                           select D;
            if(findOneDeOnMaDeAndMaKhoi.Count() == 0)
            {
                return 1;
            }
            if(DoKho != "dễ" && DoKho !="trung bình" && DoKho != "khó")
            {
                return 2;
            }
            foreach(var mem in findOneDeOnMaDeAndMaKhoi)
            {
                mem.DoKho = DoKho;
            }
            DB.SubmitChanges();

            return 0;
        }
    }
}
