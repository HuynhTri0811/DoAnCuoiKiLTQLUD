using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DTO;


namespace DAO.HT
{
    public class KiThiDAO
    {

        public List<KiThi> GetAllKiThi()
        {
            /*
             * Lấy hết danh sách kì thi
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                List<KiThi> allKiThis = new List<KiThi>();
                var findAllKiThis = from KT in DB.KiThis
                                    select KT;
                if (findAllKiThis.Count() == 0)
                {
                    return null;
                }
                foreach (var mem in findAllKiThis)
                {
                    allKiThis.Add(mem);
                }
                return allKiThis;
            }
        }


        public KiThi GetOneKiThiCuoiCung(string KT)
        {
            using (DataContextDataContext db = new DataContextDataContext())
            {
                KiThi kithiLast = new KiThi();
                var kiThi = (from kt in db.KiThis
                             where kt.MaKiThi.Contains("KT" + DateTime.Now.Year.ToString() + KT)
                             orderby kt.MaKiThi descending
                             select kt);
                if(kiThi.Count() == 0)
                {
                    return null;
                }
                foreach(var mem in kiThi)
                {
                    kithiLast = mem;
                    break;
                }
                
                return kithiLast;
            }
            
        }

        public KiThi GetOneKiThiONMaKhiThi(string  MaKiThi)
        {
            /*
             * Tìm kì thi thông qua mã kì thi
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về kì thi
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                KiThi getOneKiThi = new KiThi();
                var kithi = from KH in DB.KiThis
                            where KH.MaKiThi == MaKiThi
                            select KH;
                if (kithi.Count() == 0)
                {
                    return null;
                }
                foreach (var kh in kithi)
                {
                    getOneKiThi.MaKiThi = kh.MaKiThi;
                    getOneKiThi.TenKiThi = kh.TenKiThi;
                    getOneKiThi.NgayThi = kh.NgayThi;
                }

                return getOneKiThi;
            }

        }

        public bool DeleteKiThiOnMaKiThi(string MaKiThi)
        {
            /*
             * Xóa kì thi dựa trên mã kì thi được nhấp vào
             * Nếu không tìm thấy mã kì thi -> trả về false
             * Nếu tìm thấy và xóa thành công mã kì thi -> trả về true
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findOneKiThiONMaKiThi = from KH in DB.KiThis
                                            where KH.MaKiThi == MaKiThi
                                            select KH;
                if (findOneKiThiONMaKiThi.Count() == 0)
                {
                    return false;
                }
                foreach (var KH in findOneKiThiONMaKiThi)
                {
                    DB.KiThis.DeleteOnSubmit(KH);
                }
                DB.SubmitChanges();
                return true;
            }
        }

        public int UpdateNameKiThiONMaKiThi(string MaKiThi,string TenKiThi)
        {

            /*
             * Update tên kì thi dựa trên mã kì thi 
             * Nếu không tìm thấy mã kì thi -> trả về 1
             * Nếu tên kì thi mới = tên kì thi cũ thì -> trả về 2
             * Nếu Update thành công -> trả về 0
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findOneMaKiThi = from KT in DB.KiThis
                                     where KT.MaKiThi == MaKiThi
                                     select KT;
                if (findOneMaKiThi.Count() == 0)
                {
                    return 1;
                }
                var findOneMaKiThiANDTenKiThi = from KT in DB.KiThis
                                                where KT.MaKiThi == MaKiThi && KT.TenKiThi == TenKiThi
                                                select KT;
                if (findOneMaKiThiANDTenKiThi.Count() == 0)
                {
                    return 2;
                }

                foreach (var KT in findOneMaKiThi)
                {
                    KT.TenKiThi = TenKiThi;
                }
                DB.SubmitChanges();

                return 0;
            }
        }

        public int UpdateThoiGianThiCuaKiThi(string MaKiThi,DateTime ThoiGianThi)
        {
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                /*
                 * Update thời gian thi của kì thi 
                 * Nếu không tìm thấy mã kì thi -> trả về 1
                 * Update thành công -> trả về 0
                 */

                var findOneKiThi = from KT in DB.KiThis
                                   where KT.MaKiThi == MaKiThi
                                   select KT;
                if (findOneKiThi.Count() == 0)
                {
                    return 1;
                }
                foreach (var mem in findOneKiThi)
                {
                    mem.NgayThi = ThoiGianThi;
                }
                DB.SubmitChanges();
                return 0;
            }
        }

        public int InsertKiThi(string MaKT, string TenKiThi, DateTime ThoiGianThi)
        {

            /*
             * Mã kì thi =  KITHI+Nam+(01,02) 01 -> học kì 1 , 02 -> học kì 2 VD:KITHI201901
             * Tên Kì Thi 
             * Thời gian thi
             * Nếu Mã KT không phải 15 hoặc 1T hoặc không phải CK thì -> trả về 1
             * Nếu MaKiThi đẫ tồn tại thì thì trả về 2
             * 
             * 
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                string MaKiThi = "0";
                if (MaKT != "15" && MaKT != "1T" && MaKT != "CK")
                {
                    return 1;
                }
                //KT2019KT01
                KiThi kiThi1 = GetOneKiThiCuoiCung(MaKT);
                if(kiThi1 != null)
                {
                    int SoCuoiCungTemp = Int32.Parse(kiThi1.MaKiThi.Substring(8, 2));
                    SoCuoiCungTemp++;
                    if (SoCuoiCungTemp.ToString().Length == 1)
                    {
                        MaKiThi = "KT" + DateTime.Now.Year.ToString() + MaKT + "0" + SoCuoiCungTemp.ToString();
                    }
                    if (SoCuoiCungTemp.ToString().Length == 2)
                    {
                        MaKiThi = "KT" + DateTime.Now.Year.ToString() + MaKT + SoCuoiCungTemp.ToString();
                    }
                }
                else
                {
                    MaKiThi = "KT" + DateTime.Now.Year.ToString() + MaKT + "00";

                }
                

                var findOneKiThi = from KT in DB.KiThis
                                   where KT.MaKiThi == MaKiThi
                                   select KT;
                if (findOneKiThi.Count() != 0)
                {
                    return 2;
                }

                KiThi kiThi = new KiThi();
                kiThi.MaKiThi = MaKiThi;
                kiThi.TenKiThi = TenKiThi;
                kiThi.NgayThi = ThoiGianThi;
                DB.KiThis.InsertOnSubmit(kiThi);
                DB.SubmitChanges();
                return 0;
            }
        }
    }
}
