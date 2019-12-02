using DTO.HT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO.HS
{
    public class HocSinhDAO
    {
        DTO.HT.DataContextDataContext db = new DataContextDataContext();

        public HocSinh FindOneHocSinh(string maHS, string passHS)
        {
            //tìm học sinh thông qua mã và pass, không có trả về null
            HocSinh hocSinh = new HocSinh();

            try
            {
                var findOneHS = from hs in db.HocSinhs
                                where hs.MaHocSinh == maHS
                                select hs;
                
                if (findOneHS.Count() != 0)
                {
                    foreach (var hs in findOneHS)
                    {
                        hocSinh.MaHocSinh = hs.MaHocSinh;
                        hocSinh.Password = hs.Password;
                        hocSinh.HoTen = hs.HoTen;
                        hocSinh.NgaySinh = hs.NgaySinh;
                        hocSinh.MaLop = hs.MaLop;
                        hocSinh.SoilPass = hs.SoilPass;
                    }
                }

                //mã hóa pass bằng MD5
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(passHS + hocSinh.SoilPass);
                byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

                string hashPass = "";

                foreach (byte item in hashData)
                {
                    hashPass += item;
                }

                if(String.Compare(hashPass, hocSinh.Password, false) == 0)
                {
                    return hocSinh;
                }

                return null;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }            
        }

        public string LastMaHocSinh()
        {
            try
            {
                var lastMaHocSinh = from hs in db.HocSinhs
                                    orderby hs.MaHocSinh descending
                                    select hs;
                string result = null;
                if(lastMaHocSinh.Count() != 0)
                {
                    foreach(var hs in lastMaHocSinh)
                    {
                        result = hs.MaHocSinh.ToString();
                    }
                }

                return result;
                                    
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        public Boolean AddHocSinh(string maHS, string hoTen, DateTime ngaySinh, string diaChi, string password)
        {
            //tạo chuỗi SoilPass
            Random rand = new Random();
            string numRand = rand.Next(10000, 99999).ToString();

            //mã hóa pass bằng MD5
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password + numRand);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hashPass = "";

            foreach (byte item in hashData)
            {
                hashPass += item;
            }

            HocSinh hocSinh = new HocSinh();

            hocSinh.MaHocSinh = maHS;
            hocSinh.HoTen = hoTen;
            hocSinh.NgaySinh = ngaySinh;
            hocSinh.DiaChi = diaChi;
            hocSinh.Password = hashPass;
            hocSinh.SoilPass = numRand;

            try
            {
                var truocInsert = from hs in db.HocSinhs
                                  select hs;
                int soBanGhiTruocInsert = truocInsert.Count();

                db.HocSinhs.InsertOnSubmit(hocSinh);
                db.SubmitChanges();

                var sauInsert = from hs in db.HocSinhs
                                select hs;
                int soBanGhiSauInsert = sauInsert.Count();

                if(soBanGhiSauInsert == soBanGhiTruocInsert)
                {
                    return false;
                }          

                return true;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

    }
}
