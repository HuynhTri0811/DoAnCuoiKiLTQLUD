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

        public List<De> getAllDe()
        {
            /*
             * lấy toàn bộ đề trong cơ sở dữ liệu
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                List<De> allDe = new List<De>();

                var findallDe = from D in DB.Des
                                select D;
                foreach (var mem in findallDe)
                {
                    allDe.Add(mem);
                }
                return allDe;
            }
        }

        public De getOneDeOnMaDe(string MaDe)
        {
            /*
             * Tìm đề thông qua mã đề
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về đề
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                De de = new De();
                var findOneDeONMaDe = from D in DB.Des
                                      where D.MaDe == MaDe
                                      select D;
                if (findOneDeONMaDe.Count() == 0)
                {
                    return null;
                }
                foreach (var mem in findOneDeONMaDe)
                {
                    de.MaDe = mem.MaDe;
                    de.TenDe = mem.TenDe;
                    de.MaKhoi = mem.MaKhoi;
                    de.DoKho = mem.DoKho;
                }
                return de;
            }
        }

        public De getONeDeOnMaDEMoiTao(int MaKhoi)
        {
            /*
             * Tìm đề thông qua mã đề
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về đề
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                De de = new De();
                de = (from D in DB.Des
                      where D.MaKhoi == MaKhoi
                      orderby D.MaDe descending
                      select D).First();
                return de;
            }
        }

        public bool DeleteDeOnMaDeAndMaKhoi(string MaDe,int MaKhoi)
        {

            /*
             * Xóa de trong bang de va ma khoi
             * Nếu không tồn tại MaDe va MaKhoi trong bang de -> tra về false
             * Nếu tồn tại và xóa thành công -> trả về true
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findOneDeOnMaDeVaMaKhoi = from D in DB.Des
                                              where D.MaDe == MaDe && D.MaKhoi == MaKhoi
                                              select D;
                if (findOneDeOnMaDeVaMaKhoi.Count() == 0)
                {
                    return false;
                }
                foreach (var mem in findOneDeOnMaDeVaMaKhoi)
                {
                    DB.Des.DeleteOnSubmit(mem);
                }
                DB.SubmitChanges();
                return true;
            }
        }

        public int UpdateTenDeOnMaDeAndMaKhoi(string MaDe,int MaKhoi, string TenDe)
        {
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                /*
                 * Update tên đề dựa trên mã đề và mã khối
                 * Nếu không tìm thấy mã đề và mã khối trong csdl -> trả về 1
                 * Nếu tìm thấy và update thành công -> trả về 0
                 */

                var findOneTenDeOnMaDeAndMaKhoi = from D in DB.Des
                                                  where D.MaDe == MaDe && D.MaKhoi == MaKhoi
                                                  select D;
                if (findOneTenDeOnMaDeAndMaKhoi.Count() == 0)
                {
                    return 1;
                }
                foreach (var mem in findOneTenDeOnMaDeAndMaKhoi)
                {
                    mem.TenDe = TenDe;
                }
                DB.SubmitChanges();
                return 0;
            }
        }

        public int UpdateDoKhoOnMaDeAndMaKhoi(string MaDe,int MaKhoi,string DoKho)
        {
            /*
             * Update độ khó của mã đề và mã khối
             * Nếu không tìm thấy MaDe và Mã khối -> trả về 1
             * Nếu độ khó khác dễ hoặc vừa hoặc khó -> trả về 2
             * Update thành công thì trả -> trả về 0
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findOneDeOnMaDeAndMaKhoi = from D in DB.Des
                                               where D.MaDe == MaDe && D.MaKhoi == MaKhoi
                                               select D;
                if (findOneDeOnMaDeAndMaKhoi.Count() == 0)
                {
                    return 1;
                }
                if (DoKho != "dễ" && DoKho != "trung bình" && DoKho != "khó")
                {
                    return 2;
                }
                foreach (var mem in findOneDeOnMaDeAndMaKhoi)
                {
                    mem.DoKho = DoKho;
                }
                DB.SubmitChanges();

                return 0;
            }
        }

        public int UpdateMaKhoiOnMaKhoiAndMaDe(string MaDe, int MaKhoiTruocUpdate, int MaKhoiSauUpdate)
        {

            /*
             * Tìm và update mã khối sau khi update , 
             * Nếu không tìm thấy mã đề và khối trong BangDe thì -> trả về 1
             * Nếu mã khối không update không tìm thấy trong khối -> trả về 2
             * Update thành công -> trả về 3
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findMaKhoiSaoKhiUpdate = from KH in DB.Khois
                                             where KH.MaKhoi == MaKhoiSauUpdate
                                             select KH;
                if (findMaKhoiSaoKhiUpdate.Count() == 0)
                {
                    return 2;
                }
                var findDeTruocKhiUpdate = from KH in DB.Des
                                           where KH.MaDe == MaDe && KH.MaKhoi == MaKhoiTruocUpdate
                                           select KH;
                if (findDeTruocKhiUpdate.Count() == 0)
                {
                    return 1;
                }

                foreach (var mem in findDeTruocKhiUpdate)
                {
                    mem.MaKhoi = MaKhoiSauUpdate;
                }
                DB.SubmitChanges();
                return 0;
            }
        }
        public int InsertDe(string TenDe,int MaKhoi,string DoKho)
        {
            /*
             * Insert đề vào bảng đề
             * Nếu Mã khối không tồn tại trong database -> trả về 1
             * DoKho khác với dễ hoặc trung bình khó -> trả về 2
             * MaDe = MA+NAM+STT VD : MA20190001 MA190002 , Nếu tạo mã đề , mà mã đề đã tồn tại thì trả về 3
             * Tạo thành công -> trả về 0
             * 
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {
                string MaDe = "0";
                string STTCuoi = " ";
                int N;
                var findOneMaDeCuoiCung = (from MD in DB.Des
                                           orderby MD.MaDe descending
                                           select MD).FirstOrDefault();
                if (DateTime.Now.Year != Int32.Parse(findOneMaDeCuoiCung.MaDe.Substring(2, 4)))
                {
                    MaDe = "MA" + DateTime.Now.Year.ToString() + "0000";
                }
                else
                {
                    STTCuoi = findOneMaDeCuoiCung.MaDe.Substring(6, 4);
                    if (!Int32.TryParse(STTCuoi, out N))
                    {
                        return 3;
                    }
                    N = Int32.Parse(STTCuoi) + 1;
                    if (N.ToString().Length == 1)
                    {
                        MaDe = "MA" + DateTime.Now.Year.ToString() + "000" + N.ToString();
                    }
                    if (N.ToString().Length == 2)
                    {
                        MaDe = "MA" + DateTime.Now.Year.ToString() + "00" + N.ToString();
                    }
                    if (N.ToString().Length == 3)
                    {
                        MaDe = "MA" + DateTime.Now.Year.ToString() + "0" + N.ToString();
                    }
                    if (N.ToString().Length == 4)
                    {
                        MaDe = "MA" + DateTime.Now.Year.ToString() + "" + N.ToString();
                    }
                }

                var findOneMaDe = from MD in DB.Des
                                  where MD.MaDe == MaDe
                                  select MD;
                if (findOneMaDe.Count() != 0)
                {
                    return 3;
                }

                De de = new De();
                de.MaDe = MaDe;
                de.TenDe = TenDe;
                de.MaKhoi = MaKhoi;
                de.DoKho = DoKho;

                DB.Des.InsertOnSubmit(de);
                DB.SubmitChanges();

                return 0;
            }
        }

        
    }
}
