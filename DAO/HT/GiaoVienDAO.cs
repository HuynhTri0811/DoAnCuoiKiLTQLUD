using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;

namespace DAO.HT
{
    public class GiaoVienDAO
    {
        DTO.HT.DataContextDataContext DB = new DataContextDataContext();

        public List<GiaoVien> FindAllGiaoVien()
        {
            /*
             * Tìm tất cả các giáo viên 
             * Nếu không có giáo viên nào thì trả về null
             * Nếu có thì trả về giáo viên
             */
            List<GiaoVien> giaoViens = new List<GiaoVien>();

            var FindAddGiaoVienTemp = from giaovien in DB.GiaoViens
                                      select giaovien;

            if(FindAddGiaoVienTemp.Count() == 0)
            {
                return null;
            }
            foreach(var temp in FindAddGiaoVienTemp)
            {
                giaoViens.Add(temp);
            }
            return giaoViens;
        }

        public GiaoVien FindOneGiaoVienOnMAGV(string MaGV)
        {
            /*
             * Tìm giáo viên thông qua Mã giáo viên
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về giáo viên
             */
            GiaoVien giaoVien = new GiaoVien();
            var findOne = from giaovien in DB.GiaoViens
                          where giaovien.MaGiaVien == MaGV
                          select giaovien;
            if(findOne.Count() == 0)
            {
                return null;
            }
            foreach(var temp in findOne)
            {
                giaoVien.MaGiaVien = temp.MaGiaVien;
                giaoVien.DiaChi = temp.DiaChi;
                giaoVien.Email = temp.Email;
                giaoVien.HoTen = temp.HoTen;
                giaoVien.MaKhoi = temp.MaKhoi;
                giaoVien.Password = temp.Password;
                giaoVien.SDT = temp.SDT;
            }
            return giaoVien;
        }

        public GiaoVien FindOneGiaoVienOnEmail(string Email)
        {
            /*
             * Tìm giáo viên thông qua Email
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về giáo viên
             */
            GiaoVien giaoVien = new GiaoVien();
            var findOne = from giaovien in DB.GiaoViens
                          where giaovien.Email == Email
                          select giaovien;
            if (findOne.Count() == 0)
            {
                return null;
            }
            foreach (var temp in findOne)
            {
                giaoVien.MaGiaVien = temp.MaGiaVien;
                giaoVien.DiaChi = temp.DiaChi;
                giaoVien.Email = temp.Email;
                giaoVien.HoTen = temp.HoTen;
                giaoVien.MaKhoi = temp.MaKhoi;
                giaoVien.Password = temp.Password;
                giaoVien.SDT = temp.SDT;
            }
            return giaoVien;
        }

        public GiaoVien FindOneGiaoVienOnSDT(string SDT)
        {
            /*
             * Tìm giáo viên thông qua số điện thoại
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về giáo viên
             */
            GiaoVien giaoVien = new GiaoVien();
            var findOne = from giaovien in DB.GiaoViens
                          where giaovien.SDT == SDT
                          select giaovien;
            if (findOne.Count() == 0)
            {
                return null;
            }
            foreach (var temp in findOne)
            {
                giaoVien.MaGiaVien = temp.MaGiaVien;
                giaoVien.DiaChi = temp.DiaChi;
                giaoVien.Email = temp.Email;
                giaoVien.HoTen = temp.HoTen;
                giaoVien.MaKhoi = temp.MaKhoi;
                giaoVien.Password = temp.Password;
                giaoVien.SDT = temp.SDT;
            }
            return giaoVien;
        }

        public GiaoVien FindGiaoVienOnEmailAndPassword(string Email,string Password)
        {
            /*
             * Tìm giáo viên thông qua Email và Password
             * Nếu không tìm thấy -> trả về null
             * Nếu tìm thấy -> trả về GiaoVien
             */
            GiaoVien GiaoVienOne = new GiaoVien();
            var GiaoViens = from giaovien in DB.GiaoViens
                            where giaovien.Email == Email && giaovien.Password == Password
                            select giaovien;
            if(GiaoViens.Count() == 0)
            {
                return null;
            }
            foreach(var temp in GiaoViens)
            {
                GiaoVienOne.MaGiaVien = temp.MaGiaVien;
                GiaoVienOne.DiaChi = temp.DiaChi;
                GiaoVienOne.Email = temp.Email;
                GiaoVienOne.HoTen = temp.HoTen;
                GiaoVienOne.MaKhoi = temp.MaKhoi;
                GiaoVienOne.Password = temp.Password;
                GiaoVienOne.SDT = temp.SDT;
                break;
            }
            return GiaoVienOne;
        }

        public int AddGiaoVien(string Password,string HoTen,string DiaChi,string Email,string SDT,int MaKhoi)
        {
            /*
             * Thêm giáo viên vào cơ sở dữ liệu
             * Nếu thành công -> trả về 0
             * Nếu email trùng với email của giáo viên khác -> trả về 1
             * Nếu SDT trùng với SDT của giáo viên khác -> trả về 2
             * Nếu MaKhoi không tồn tại trong cơ sỡ dữ liệu -> trả về 3
             */
            int CountEmailTemp = (from giaovien in DB.GiaoViens
                             where giaovien.Email == Email
                             select giaovien).Count();
            if(CountEmailTemp != 0)
            {
                return 1;
            }

            int CountSDTTemp = (from giaovien in DB.GiaoViens
                                where giaovien.SDT == SDT
                                select giaovien).Count();
            if(CountSDTTemp != 0)
            {
                return 2;
            }

            int CountMaKhoiTemp = (from khoi in DB.Khois
                                   where khoi.MaKhoi == MaKhoi
                                   select khoi).Count();
            if(CountMaKhoiTemp ==0)
            {
                return 3;
            }

            string Temp = (from giaovien in DB.GiaoViens
                           orderby giaovien.MaGiaVien descending
                           select giaovien.MaGiaVien).FirstOrDefault();
            string maGVint = Temp.Substring(2, 4);
            int MaSoGV = Int32.Parse(maGVint);
            MaSoGV = MaSoGV + 1;
            maGVint = MaSoGV.ToString();
            if(maGVint.Length == 1)
            {
                Temp = "GV0000" + maGVint;
            }
            if(maGVint.Length == 2)
            {
                Temp = "GV000" + maGVint;
            }
            if(maGVint.Length == 3)
            {
                Temp = "GV00" + maGVint;
            }
            if (maGVint.Length == 4)
            {
                Temp = "GV0" + maGVint;
            }
            if(maGVint.Length == 5)
            {
                Temp = "GV" + maGVint;
            }
            GiaoVien newGiaoVien = new GiaoVien();
            newGiaoVien.MaGiaVien = Temp;
            newGiaoVien.DiaChi = DiaChi;
            newGiaoVien.Email = Email;
            newGiaoVien.HoTen = HoTen;
            newGiaoVien.MaKhoi = MaKhoi;
            newGiaoVien.Password = Password;
            newGiaoVien.SDT = SDT;
            DB.GiaoViens.InsertOnSubmit(newGiaoVien);
            DB.SubmitChanges();

            return 0;
        }

        public bool  DeleteGiaoVienOnMaGV(string MaGV)
        {
            /*
             * Xóa giáo viên thông qua mã giáo viên
             * Nếu tìm thấy  , xóa thành công -> trả về true
             * Nếu không tìm thấy -> trả về false
             */

            var KiemTraGiaoVienCoTonTaiHayKhong = from giaovien in DB.GiaoViens
                                                   where giaovien.MaGiaVien == MaGV
                                                   select giaovien;
            if(KiemTraGiaoVienCoTonTaiHayKhong.Count() == 0)
            {
                return false;
            }

            foreach(var men in KiemTraGiaoVienCoTonTaiHayKhong)
            {
                DB.GiaoViens.DeleteOnSubmit(men);
            }
            DB.SubmitChanges();
            return true;
        }

        public int UpdateGiaoVienOnEmail(string MaGV,string Email)
        {
            /*
             * Update Email của giáo viên thông qua Email
             * Nếu không tồn tại MaGV -> trả về 1
             * Nếu Email đã tồn tại -> trả về 2
             * Nếu Email không không tồn tại -> update thành công -> 0
             */
            int FindMaGVGiaoVienTemp = (from giaovien in DB.GiaoViens
                                        where giaovien.MaGiaVien == MaGV
                                        select giaovien).Count();
            if(FindMaGVGiaoVienTemp == 0)
            {
                return 1;
            }
            int FindEmailGiaoVien = (from giaovien in DB.GiaoViens
                                     where giaovien.Email == Email && giaovien.MaGiaVien != MaGV
                                     select giaovien ).Count();
            if(FindEmailGiaoVien != 0)
            {
                return 2;
            }
            var FindMaGVGiaoVien = from giaovien in DB.GiaoViens
                                   where giaovien.MaGiaVien == MaGV
                                   select giaovien;
            foreach(var giaovientemp in FindMaGVGiaoVien)
            {
                giaovientemp.Email = Email;
            }
            DB.SubmitChanges();
            return 0;
        }

        public bool UpdateGiaoVienOnDiaChi(string MaGV,string DiaChi)
        {
            /*
             * Update địa chỉ của giáo viên 
             * Nếu không tồn tại MaGV -> trả về false
             * Nếu tồn tại MaGV -> update địa chỉ thành công -> trả về true
             */
            int FindMaGVOnGiaoVien = (from giaovien in DB.GiaoViens
                                      where giaovien.MaGiaVien == MaGV
                                      select MaGV).Count();
            if(FindMaGVOnGiaoVien == 0)
            {
                return false;
            }
            var FindGiaoVien = from giaovien in DB.GiaoViens
                               where giaovien.MaGiaVien == MaGV
                               select giaovien;
            foreach(var giaovien in FindGiaoVien)
            {
                giaovien.DiaChi = DiaChi;
            }
            DB.SubmitChanges();
            return true;
        }

        public bool UpdateGiaoVienOnPassword(string MaGV,string Password)
        {
            /*
             * Update password in giáo viên thông ma MaGV
             * Nếu không tìm thấy MaGV -> trả về false
             * Nếu tìm thấy MaGV -> thay đổi Password -> thay đổi thành công -> trả về true
             */

            int FindMaGVOnGiaoVien = (from giaovien in DB.GiaoViens
                                      where giaovien.MaGiaVien == MaGV
                                      select giaovien).Count();
            if(FindMaGVOnGiaoVien == 0)
            {
                return false;
            }
            var FindGiaoVien = from giaovien in DB.GiaoViens
                               where giaovien.MaGiaVien == MaGV
                               select giaovien;
            foreach(var Temp in FindGiaoVien)
            {
                Temp.Password = Password;
            }
            DB.SubmitChanges();
            return true;
        }

        public bool UpdateGiaoVienOnHoTen(string MaGV,string HoTen)
        {
            /*
             * Update họ và tên trong giáo viên
             * Nếu không tồn tại MaGV -> trả về false
             * Nếu tồn tại MaGV -> update họ tên thành công -> trả về true
             */

            var FindMaGVGiaoVien = from giaovien in DB.GiaoViens
                                    where giaovien.MaGiaVien == MaGV
                                    select giaovien;
            if(FindMaGVGiaoVien.Count() == 0)
            {
                return false;
            }
            foreach(var temp in FindMaGVGiaoVien)
            {
                temp.HoTen = HoTen;
            }
            DB.SubmitChanges();
            return true;
        }

        public int UpdateGiaoVienOnSDT(string MaGV,string SDT)
        {
            /*
             * Update số điện thoại của giáo viên 
             * Nếu MaGV không tồn tại , trả về 1
             * Nếu tìm thấy SDT trùng với 1 giáo viên khác , trả về 2
             * Update thành công , trả về 0
             */

            var FindMaGVGiaoVien = from giaovien in DB.GiaoViens
                                    where giaovien.MaGiaVien == MaGV
                                    select giaovien;
            if(FindMaGVGiaoVien.Count() == 0)
            {
                return 1;
            }
            int FindSDTGiaoVien = (from giaovien in DB.GiaoViens
                                   where giaovien.MaGiaVien != MaGV && giaovien.SDT == SDT
                                   select giaovien).Count();
            if(FindSDTGiaoVien != 0)
            {
                return 2;
            }

            foreach(var men in FindMaGVGiaoVien)
            {
                men.SDT = SDT;
            }
            DB.SubmitChanges();
            return 0;
        }

        public int UpdateGiaoVienOnMaKhoi(string MaGV,int MaKhoi)
        {
            /*
             * 
             */
            return 0;
        }
    }
}
