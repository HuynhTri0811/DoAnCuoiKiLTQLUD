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


    }
}
