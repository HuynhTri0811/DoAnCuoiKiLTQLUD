using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.HT;
using DAO;  

namespace DAO.HT
{
    public class DeVaKhoiTrongKyThiDAO
    {
        DataContextDataContext DB = new DataContextDataContext();
        public List<DeVaKhoiTrongKyThi> GetAllDeVaKhoiTrongKyThi()
        {
            /*
             * Lấy hết danh sách trong mã khối trong kì thi
             * 
             */


                List<DeVaKhoiTrongKyThi> DeVaKhoiTrongKyThis = new List<DeVaKhoiTrongKyThi>();

                var findAllDeVaKhoiTrongKyThis = from D in DB.DeVaKhoiTrongKyThis
                                                   select D;
                if (findAllDeVaKhoiTrongKyThis.Count() == 0)
                {
                    return null;
                }
                foreach (var mem in findAllDeVaKhoiTrongKyThis)
                {
                    DeVaKhoiTrongKyThis.Add(mem);
                }
                return DeVaKhoiTrongKyThis;
        }

        public int InsertDeVaKhoiTrongKyThi(int MaKhoi,string MaDe,string MaKyThi)
        {
            /*
             * Thêm 1 mã đề và mã khối Vào trong CSDl
             * Nếu không tìm thấy Mã Đề trong CSDL và không tìm thấy Mã Khôi trong CSDL -> 2
             * Nếu không tìm thấy Mã Kì Thi trong CSDL -> 3
             * DeVaKhoiTrongKyThi = Mã Khối  + 2 kí tự cuối của MaDe và 6 kí tự cuối của MaKyThi 
             * VD : Mã khối = 10 , Mã đề : MA20200000 ,  Ma kì thi : KT20201520  => DeVaKhoiTrongKyThi = "1000201520"
             * VD : Mã khối = 12 , Mã đề : MA20200001 ,  Ma kì thi : KT20201520  => DeVaKhoiTrongKyThi = "1201201520"
             * Trả về 0
             */


            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findMaKhoiAndMaDeINCSDL = from de in DB.Des
                                              where de.MaDe == MaDe && de.MaKhoi == MaKhoi
                                              select de;
                if (findMaKhoiAndMaDeINCSDL.Count()==0)
                {
                    return 2;
                }
                var findMaKyThiINCSDL = from KyThi in DB.KyThis
                                        where KyThi.MaKyThi == MaKyThi
                                        select KyThi;
                if (findMaKyThiINCSDL.Count() == 0)
                {
                    return 3;
                }

                string DeVaKhoiTrongKyThis = MaKhoi.ToString() + MaDe.Substring(8, 2) + MaKyThi.Substring(4, 6);
                DeVaKhoiTrongKyThi DeVaKhoiTrongKyThi = new DeVaKhoiTrongKyThi();
                DeVaKhoiTrongKyThi.MaKyThi = MaKyThi;
                DeVaKhoiTrongKyThi.MaKhoi = MaKhoi;
                DeVaKhoiTrongKyThi.MaDe = MaDe;
                DeVaKhoiTrongKyThi.MaDeVaKhoiTrongKyThi = DeVaKhoiTrongKyThis;
                DB.DeVaKhoiTrongKyThis.InsertOnSubmit(DeVaKhoiTrongKyThi);
                DB.SubmitChanges();
                return 0;
            }
        }


        
    }
}
