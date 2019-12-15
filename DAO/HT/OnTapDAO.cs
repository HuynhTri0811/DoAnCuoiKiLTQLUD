using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DTO;

namespace DAO
{
    public class OnTapDAO
    {
        DataContextDataContext DB = new DataContextDataContext();
        public List<DeOnTap> GetAllDeOnTap()
        {
            /*
             * Lấy toàn bộ đề ôn tập trong đề ôn tập
             */
            List<DeOnTap> deOnTaps = new List<DeOnTap>();
            var deontaps = from DOT in DB.DeOnTaps
                           select DOT;
            
            foreach(var men in deontaps)
            {
                deOnTaps.Add(men);
            }
            return deOnTaps;
        }

        public DeOnTap FindOneDeOnTapONMaHocSinhANDMaDeANDMaKhoi(string MaHocSinh,int MaKhoi,string MaDe)
        {

            /*
             * Tìm 1 dề ôn tập dựa trên mã học sinh và mã đề và mã khối
             * Nếu không tồn tại mã khối , mã học sinh , mã đề trong DeOnTap -> trả về null
             * Nếu tồn tại thì trả đề ôn tâp
             */
            DeOnTap deOnTap = new DeOnTap();

            var findOneDeOnTapONMaHocSinhANDMaDeANDMaKhoi = from HSonDEONTAP in DB.DeOnTaps
                                                            where HSonDEONTAP.MaHocSinh == MaHocSinh && HSonDEONTAP.MaKhoi == MaKhoi && HSonDEONTAP.MaDe == MaDe
                                                            select   HSonDEONTAP;
            if (findOneDeOnTapONMaHocSinhANDMaDeANDMaKhoi.Count() == 0)
            {
                return null;
            }

            foreach(var men in findOneDeOnTapONMaHocSinhANDMaDeANDMaKhoi)
            {
                deOnTap.MaDe = men.MaDe;
                deOnTap.MaHocSinh = men.MaHocSinh;
                deOnTap.MaKhoi = men.MaKhoi;
                deOnTap.Diem = men.Diem;
                deOnTap.NgayGioiHan = men.NgayGioiHan;
            }
            return deOnTap;
        }

        public int InsertDeOnTap(string MaHocSinh,string MaDe,int MaKhoi)
        {
            /*
             * Nếu thêm thành công -> trả về 0
             * Nếu không tồn tại mã học sinh -> trả về 1
             * Nếu không tồn tại mã đề  -> trả về 2
             * Nếu không tồn tại mã khối -> trả về 3
             */

            var findMaHocSinh = from HS in DB.HocSinhs
                                where HS.MaHocSinh == MaHocSinh
                                select HS;
            if(findMaHocSinh.Count() == 0)
            {
                return 1;
            }


            var findMaDe = from MD in DB.Des
                           where MD.MaDe == MaDe
                           select MD;
            if(findMaDe.Count() == 0)
            {
                return 2;
            }

            var findMaKhoi = from KH in DB.Khois
                             where KH.MaKhoi == MaKhoi
                             select KH;
            if(findMaKhoi.Count() == 0)
            {
                return 3;
            }

            DeOnTap deOnTap = new DeOnTap();
            deOnTap.MaDe = MaDe;
            deOnTap.MaHocSinh = MaHocSinh;
            deOnTap.MaKhoi = MaKhoi;

            DB.DeOnTaps.InsertOnSubmit(deOnTap);
            DB.SubmitChanges();

            return 0;
        }
        
        public bool DeleteDeOnTapOnMaDeThi(string MaDe)
        {
            /*
             * Xóa đề ôn tập dựa trên mã đề
             * Nếu mã đề không tồn tại -> trả về false
             * Nếu mã đề tồn tại và xóa thành công thì trả về true
             */

            var findMaDeONDeOnTap = from MADEONDEONTAP in DB.DeOnTaps
                                    where MADEONDEONTAP.MaDe == MaDe
                                    select MADEONDEONTAP;
            if(findMaDeONDeOnTap.Count() == 0)
            {
                return false;
            }

            foreach(var men in findMaDeONDeOnTap)
            {
                DB.DeOnTaps.DeleteOnSubmit(men);
            }

            DB.SubmitChanges();

            return true;
        }

        public bool DeleteDeOnTapOnMaHocSinh(string MaHocSinh, string MaDe)
        {
            /*
             * Xóa đề on tập trên bảng ôn tập 
             * Nếu không tìm thấy Ma Hoc Sinh và Ma De -> thì trả về false
             * Nếu tìm thấy và xóa thành công -> thì trả về true
             */


            var findMaHocSinhANDMaDe = from DE in DB.DeOnTaps
                                       where DE.MaDe == MaDe && DE.MaHocSinh == MaHocSinh
                                       select DE;
            if(findMaHocSinhANDMaDe.Count() == 0)
            {
                return false;
            }

            foreach(var men in findMaHocSinhANDMaDe)
            {
                DB.DeOnTaps.DeleteOnSubmit(men);
            }
            DB.SubmitChanges();
            return true;
        }
        
        public int UpdateDeOnTapONMaDeANDMaHocSinhANDMaKhoi(string MaHocSinh,string MaDe,int MaKhoi)
        {
            /*
             * Update MaHocSinh và MaDe và MaKhoi
             */



            return 0;
        }

        public int UpdateDeOnTapONDiem(string MaHocSinh, string MaDe, int MaKhoi,float Diem)
        {

            /*
             * Update điểm ôn tập dựa trên MaHocSinh và MaDe và MaKhoi
             * Nếu không tìm thấy Mã Học Sinh trong bảng học sinh -> trả về 1
             * Nếu không tìm thấy Mã Đề trong Đề -> trả về 2
             * Nếu không tìm thấy Mã Khối trong Khối -> trả về 3
             * Nếu không tìm thấy Mã Học Sinh , Mã Đề , Mã Khối trong bảng đề Ôn Tập thì trả về 4
             */

            var findMaHocSinhONHocSinh = from HS in DB.HocSinhs
                                         where HS.MaHocSinh == MaHocSinh
                                         select HS;
            if(findMaHocSinhONHocSinh.Count() ==0)
            {
                return 1;
            }

            var findMaDeONDe = from DE in DB.Des
                               where DE.MaDe == MaDe
                               select DE;
            if(findMaDeONDe.Count() == 0)
            {
                return 2;
            }

            var findMaKhoiONKhoi = from KH in DB.Khois
                                   where KH.MaKhoi == MaKhoi
                                   select KH;
            if(findMaKhoiONKhoi.Count() == 0)
            {
                return 3;
            }

            var findMaHocSinhANDMaDeANDMaKhoiONDeOntap = from HSonDEONTAP in DB.DeOnTaps
                                                         where HSonDEONTAP.MaDe == MaDe && HSonDEONTAP.MaHocSinh == MaHocSinh && HSonDEONTAP.MaKhoi == MaKhoi
                                                         select HSonDEONTAP;

            if (findMaHocSinhANDMaDeANDMaKhoiONDeOntap.Count() == 0)
            {
                return 4;
            }


            foreach(var mem in findMaHocSinhANDMaDeANDMaKhoiONDeOntap)
            {
                mem.Diem = Diem;
            }
            DB.SubmitChanges();
            return 0;
        }

    }
}
