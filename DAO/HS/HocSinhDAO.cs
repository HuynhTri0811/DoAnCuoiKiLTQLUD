using DTO;
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
                        hocSinh.DiaChi = hs.DiaChi;
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

        public void UpdateHocSinh(string maHS, string hoTen, DateTime ngaySinh, string diaChi)
        {
            try
            {
                HocSinh hocSinhUpdate = db.HocSinhs.Single(h => h.MaHocSinh == maHS);
                hocSinhUpdate.HoTen = hoTen;
                hocSinhUpdate.NgaySinh = ngaySinh;
                hocSinhUpdate.DiaChi = diaChi;
               
                db.SubmitChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<DeVaCauHoiDTO> GetAllDeThi()
        {
            try
            {
                var tatCaDeThi = (from de in db.Des
                                 join  chinde in db.CauHoiTrongDeNaos on de.MaDe equals chinde.MaDe
                                 join ch in db.CauHois on chinde.MaCauHoi equals ch.MaCauHoi
                                 orderby de.MaDe
                                 select new {de.MaDe, de.TenDe, de.DoKho, de.MaKhoi, ch.MaCauHoi, ch.NoiDung, ch.CauA, ch.CauB, ch.CauC, ch.CauD, ch.CauDung});

                if(tatCaDeThi.Count() == 0)
                {
                    return null;
                }

                List<DeVaCauHoiDTO> listDeCauHoi = new List<DeVaCauHoiDTO>();

                foreach(var chTrongDe in tatCaDeThi)
                {
                    DeVaCauHoiDTO deVaCauHoi = new DeVaCauHoiDTO();
                    deVaCauHoi.MaDe = chTrongDe.MaDe;
                    deVaCauHoi.TenDe = chTrongDe.TenDe;
                    deVaCauHoi.DoKho = chTrongDe.DoKho;
                    deVaCauHoi.MaKhoi = chTrongDe.MaKhoi;
                    deVaCauHoi.MaCauHoi = chTrongDe.MaCauHoi;
                    deVaCauHoi.NoiDung = chTrongDe.NoiDung;
                    deVaCauHoi.CauA = chTrongDe.CauA;
                    deVaCauHoi.CauB = chTrongDe.CauB;
                    deVaCauHoi.CauC = chTrongDe.CauC;
                    deVaCauHoi.CauD = chTrongDe.CauD;
                    deVaCauHoi.CauDung = chTrongDe.CauDung;
                    deVaCauHoi.CauChon = "";

                    listDeCauHoi.Add(deVaCauHoi);
                }

                return listDeCauHoi;          
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        public List<De> LayDanhSachDe(string doKho)
        {
            List<De> danhSachDe = new List<De>();

            if (doKho == "" || doKho == null)
            {
                danhSachDe = null;
            }
            else
            {
                try
                {
                    var dsDe = (from d in db.Des
                                where d.DoKho == doKho
                                select d);

                    if(dsDe.Count() == 0)
                    {
                        return null;
                    }
                    foreach(var d in dsDe)
                    {
                        danhSachDe.Add(d);
                    }
                }
                catch(Exception Ex)
                {
                    throw Ex;
                }
            }

            return danhSachDe;
        }

        public List<DeVaCauHoiDTO> LayDeTheoMaDe(string maDe)
        {
            try
            {
                var dThi = (from de in db.Des
                            join chinde in db.CauHoiTrongDeNaos on de.MaDe equals chinde.MaDe
                            join ch in db.CauHois on chinde.MaCauHoi equals ch.MaCauHoi
                            where de.MaDe == maDe
                            orderby ch.MaCauHoi
                            select new { de.MaDe, de.TenDe, de.DoKho, de.MaKhoi, ch.MaCauHoi, ch.NoiDung, ch.CauA, ch.CauB, ch.CauC, ch.CauD, ch.CauDung });

                if(dThi.Count() == 0)
                {
                    return null;
                }

                List<DeVaCauHoiDTO> dsCauHoi = new List<DeVaCauHoiDTO>();
                foreach(var item in dThi)
                {
                    DeVaCauHoiDTO deThi = new DeVaCauHoiDTO();

                    deThi.MaDe = item.MaDe;
                    deThi.TenDe = item.TenDe;
                    deThi.DoKho = item.DoKho;
                    deThi.MaKhoi = item.MaKhoi;
                    deThi.MaCauHoi = item.MaCauHoi;
                    deThi.NoiDung = item.NoiDung;
                    deThi.CauA = item.CauA;
                    deThi.CauB = item.CauB;
                    deThi.CauC = item.CauC;
                    deThi.CauD = item.CauD;
                    deThi.CauDung = item.CauDung;
                    deThi.CauChon = "";

                    dsCauHoi.Add(deThi);
                }

                return dsCauHoi;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
