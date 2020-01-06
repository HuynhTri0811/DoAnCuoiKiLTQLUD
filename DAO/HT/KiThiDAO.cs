using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DTO;


namespace DAO.HT
{
    public class KyThiDAO
    {

        public List<KyThi> GetAllKyThi()
        {
            /*
             * Lấy hết danh sách kì thi
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                List<KyThi> allKyThis = new List<KyThi>();
                var findAllKyThis = from KT in DB.KyThis
                                    select KT;
                if (findAllKyThis.Count() == 0)
                {
                    return null;
                }
                foreach (var mem in findAllKyThis)
                {
                    allKyThis.Add(mem);
                }
                return allKyThis;
            }
        }


        public KyThi GetOneKyThiCuoiCung(string KT)
        {
            using (DataContextDataContext db = new DataContextDataContext())
            {
                KyThi KyThiLast = new KyThi();
                var KyThi = (from kt in db.KyThis
                             where kt.MaKyThi.Contains("KT" + DateTime.Now.Year.ToString() + KT)
                             orderby kt.MaKyThi descending
                             select kt);
                if(KyThi.Count() == 0)
                {
                    return null;
                }
                foreach(var mem in KyThi)
                {
                    KyThiLast = mem;
                    break;
                }
                
                return KyThiLast;
            }
            
        }

        public KyThi GetOneKyThiONMaKhiThi(string  MaKyThi)
        {
            /*
             * Tìm kì thi thông qua mã kì thi
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về kì thi
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                KyThi getOneKyThi = new KyThi();
                var KyThi = from KH in DB.KyThis
                            where KH.MaKyThi == MaKyThi
                            select KH;
                if (KyThi.Count() == 0)
                {
                    return null;
                }
                foreach (var kh in KyThi)
                {
                    getOneKyThi.MaKyThi = kh.MaKyThi;
                    getOneKyThi.TenKyThi = kh.TenKyThi;
                    getOneKyThi.NgayThi = kh.NgayThi;
                }

                return getOneKyThi;
            }

        }

        public bool DeleteKyThiOnMaKyThi(string MaKyThi)
        {
            /*
             * Xóa kì thi dựa trên mã kì thi được nhấp vào
             * Nếu không tìm thấy mã kì thi -> trả về false
             * Nếu tìm thấy và xóa thành công mã kì thi -> trả về true
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findOneKyThiONMaKyThi = from KH in DB.KyThis
                                            where KH.MaKyThi == MaKyThi
                                            select KH;
                if (findOneKyThiONMaKyThi.Count() == 0)
                {
                    return false;
                }
                foreach (var KH in findOneKyThiONMaKyThi)
                {
                    DB.KyThis.DeleteOnSubmit(KH);
                }
                DB.SubmitChanges();
                return true;
            }
        }

        public int UpdateNameKyThiONMaKyThi(string MaKyThi,string TenKyThi)
        {

            /*
             * Update tên kì thi dựa trên mã kì thi 
             * Nếu không tìm thấy mã kì thi -> trả về 1
             * Nếu tên kì thi mới = tên kì thi cũ thì -> trả về 2
             * Nếu Update thành công -> trả về 0
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findOneMaKyThi = from KT in DB.KyThis
                                     where KT.MaKyThi == MaKyThi
                                     select KT;
                if (findOneMaKyThi.Count() == 0)
                {
                    return 1;
                }
                var findOneMaKyThiANDTenKyThi = from KT in DB.KyThis
                                                where KT.MaKyThi == MaKyThi && KT.TenKyThi == TenKyThi
                                                select KT;
                if (findOneMaKyThiANDTenKyThi.Count() == 0)
                {
                    return 2;
                }

                foreach (var KT in findOneMaKyThi)
                {
                    KT.TenKyThi = TenKyThi;
                }
                DB.SubmitChanges();

                return 0;
            }
        }

        public int UpdateThoiGianThiCuaKyThi(string MaKyThi,DateTime ThoiGianThi)
        {
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                /*
                 * Update thời gian thi của kì thi 
                 * Nếu không tìm thấy mã kì thi -> trả về 1
                 * Update thành công -> trả về 0
                 */

                var findOneKyThi = from KT in DB.KyThis
                                   where KT.MaKyThi == MaKyThi
                                   select KT;
                if (findOneKyThi.Count() == 0)
                {
                    return 1;
                }
                foreach (var mem in findOneKyThi)
                {
                    mem.NgayThi = ThoiGianThi;
                }
                DB.SubmitChanges();
                return 0;
            }
        }

        public int InsertKyThi(string MaKT, string TenKyThi, DateTime ThoiGianThi)
        {

            /*
             * Mã kì thi =  KyThi+Nam+(01,02) 01 -> học kì 1 , 02 -> học kì 2 VD:KyThi201901
             * Tên Kì Thi 
             * Thời gian thi
             * Nếu Mã KT không phải 15 hoặc 1T hoặc không phải CK thì -> trả về 1
             * Nếu MaKyThi đẫ tồn tại thì thì trả về 2
             * 
             * 
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                string MaKyThi = "0";
                if (MaKT != "GK" && MaKT != "CK")
                {
                    return 1;
                }
                //KT2019KT01
                KyThi KyThi1 = GetOneKyThiCuoiCung(MaKT);
                if(KyThi1 != null)
                {
                    int SoCuoiCungTemp = Int32.Parse(KyThi1.MaKyThi.Substring(8, 2));
                    SoCuoiCungTemp++;
                    if (SoCuoiCungTemp.ToString().Length == 1)
                    {
                        MaKyThi = "KT" + DateTime.Now.Year.ToString() + MaKT + "0" + SoCuoiCungTemp.ToString();
                    }
                    if (SoCuoiCungTemp.ToString().Length == 2)
                    {
                        MaKyThi = "KT" + DateTime.Now.Year.ToString() + MaKT + SoCuoiCungTemp.ToString();
                    }
                }
                else
                {
                    MaKyThi = "KT" + DateTime.Now.Year.ToString() + MaKT + "00";

                }
                

                var findOneKyThi = from KT in DB.KyThis
                                   where KT.MaKyThi == MaKyThi
                                   select KT;
                if (findOneKyThi.Count() != 0)
                {
                    return 2;
                }

                KyThi KyThi = new KyThi();
                KyThi.MaKyThi = MaKyThi;
                KyThi.TenKyThi = TenKyThi;
                KyThi.NgayThi = ThoiGianThi;
                DB.KyThis.InsertOnSubmit(KyThi);
                DB.SubmitChanges();
                return 0;
            }
        }
    }
}
