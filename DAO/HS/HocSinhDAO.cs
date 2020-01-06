using DTO;
using DTO.HT;
using System;
using System.Collections.Generic;
using System.Data;
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

                    dsCauHoi.Add(deThi);
                }

                return dsCauHoi;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        public int LayMaKhoiTheoMaDe(string maDe)
        {
            int MaKhoi = -1;
            try
            {
                var maKhoi = (from de in db.Des
                              where de.MaDe == maDe
                              select new { de.MaDe, de.MaKhoi });
                if(maKhoi.Count() > 0)
                {
                    foreach(var item in maKhoi)
                    {
                        MaKhoi = item.MaKhoi;
                    }
                }

                return MaKhoi;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        //thêm kết quả thi thử vào database
        public Boolean AddKetQuaThiThu(string maHS, string maDe, int maKhoi, double diem)
        {
            DeOnTap DeOT = new DeOnTap();

            DeOT.MaHocSinh = maHS;
            DeOT.MaDe = maDe;
            DeOT.MaKhoi = maKhoi;
            DeOT.Diem = diem;
            DateTime now = DateTime.Now;
            DeOT.NgayGioiHan = now;
            

            try
            {
                var truocInsert = from deot in db.DeOnTaps
                                  select deot;
                int soBanGhiTruocInsert = truocInsert.Count();

                db.DeOnTaps.InsertOnSubmit(DeOT);
                db.SubmitChanges();

                var sauInsert = from deot in db.DeOnTaps
                                select deot;
                int soBanGhiSauInsert = sauInsert.Count();

                if (soBanGhiSauInsert == soBanGhiTruocInsert)
                {
                    return false;
                }

                return true;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //tìm kỳ thi cho học sinh theo mã
        public List<DeVaCauHoiThiDTO> FindDeVaCauHoiTrongKyThi(string maHS)
        {
            List<DeVaCauHoiThiDTO> dsCauHoiThi = new List<DeVaCauHoiThiDTO>();

            try
            {
                var query = (from hs in db.HocSinhs
                             join hstkt in db.HocSinhTrongKiThis on hs.MaHocSinh equals hstkt.MaHocSinh
                             join dvktkt in db.DeVaKhoiTrongKyThis on hstkt.MaDeVaKhoiTrongKiThi equals dvktkt.MaDeVaKhoiTrongKyThi                             
                             join d in db.Des on new { dvktkt.MaDe,  dvktkt.MaKhoi }  equals new { d.MaDe, d.MaKhoi }
                             join chtdn in db.CauHoiTrongDeNaos on new { d.MaDe, d.MaKhoi } equals new { chtdn.MaDe, chtdn.MaKhoi }
                             join ch in db.CauHois on chtdn.MaCauHoi equals ch.MaCauHoi
                             join dk in db.DoKhos on ch.DoKho equals dk.maDoKho
                             join kt in db.KyThis on dvktkt.MaKyThi equals kt.MaKyThi
                             where hs.MaHocSinh == maHS && kt.NgayThi == DateTime.Now.Date
                             select new { kt.MaKyThi, kt.TenKyThi, kt.NgayThi, hstkt.MaDeVaKhoiTrongKiThi, d.MaDe, d.TenDe, dk.TenDoKho, d.MaKhoi, ch.MaCauHoi, ch.NoiDung, ch.CauA, ch.CauB, ch.CauC, ch.CauD, ch.CauDung }).Distinct();
                if(query.Count() == 0)
                {
                    dsCauHoiThi = null;
                }

                foreach(var q in query)
                {
                    DeVaCauHoiThiDTO deThi = new DeVaCauHoiThiDTO();

                    deThi.MaKyThi = q.MaKyThi;
                    deThi.TenKyThi = q.TenKyThi;
                    deThi.NgayThi = q.NgayThi.GetValueOrDefault();
                    deThi.MaDeVaKhoiTrongKyThi = q.MaDeVaKhoiTrongKiThi;
                    deThi.MaDe = q.MaDe;
                    deThi.TenDe = q.TenDe;
                    deThi.DoKho = q.TenDoKho;
                    deThi.MaKhoi = q.MaKhoi;
                    deThi.MaCauHoi = q.MaCauHoi;
                    deThi.NoiDung = q.NoiDung;
                    deThi.CauA = q.CauA;
                    deThi.CauB = q.CauB;
                    deThi.CauC = q.CauC;
                    deThi.CauD = q.CauD;
                    deThi.CauDung = q.CauDung;

                    dsCauHoiThi.Add(deThi);
                }

                return dsCauHoiThi;
                
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //lấy tên kỳ thi
        public string GetNameKyThi(string maHS)
        {
            string tenKyThi = "";

            try
            {
                var query = (from hs in db.HocSinhs
                             join hstkt in db.HocSinhTrongKiThis on hs.MaHocSinh equals hstkt.MaHocSinh
                             join dvktkt in db.DeVaKhoiTrongKyThis on hstkt.MaDeVaKhoiTrongKiThi equals dvktkt.MaDeVaKhoiTrongKyThi
                             join kt in db.KyThis on dvktkt.MaKyThi equals kt.MaKyThi
                             where hs.MaHocSinh == maHS
                             select new { kt.TenKyThi}).Distinct();
                if (query.Count() == 0)
                {
                    tenKyThi = "";
                }

                foreach (var q in query)
                {                
                    tenKyThi = q.TenKyThi;
                    break;
                }

                return tenKyThi;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //thêm kết quả thi vào database
        public void AddKetQuaThi(string maHS, string maDeVaKhoiTrongKyThi, double diem)
        {
            try
            {
                HocSinhTrongKiThi hsTrongKyThi = db.HocSinhTrongKiThis.Single(h => (h.MaHocSinh == maHS) && (h.MaDeVaKhoiTrongKiThi == maDeVaKhoiTrongKyThi));
                hsTrongKyThi.Diem = diem;

                db.SubmitChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //lấy lịch sử thi thử
        public IQueryable GetAllLichSuThiThu(string maHS)
        {
            try
            {
                var query =(from dot in db.DeOnTaps
                            where dot.MaHocSinh == maHS
                            select new { dot.MaDe, dot.MaKhoi, dot.NgayGioiHan, dot.Diem });
                if(query.Count() == 0)
                {
                    return null;
                }
                return query;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //lấy lịch sử thi
        public IQueryable GetAllLichSuKetQuaThi(string maHS)
        {
            try
            {
                var query = (from hs in db.HocSinhs
                             join hstkt in db.HocSinhTrongKiThis on hs.MaHocSinh equals hstkt.MaHocSinh
                             join dvktkt in db.DeVaKhoiTrongKyThis on hstkt.MaDeVaKhoiTrongKiThi equals dvktkt.MaDeVaKhoiTrongKyThi
                             join kt in db.KyThis on dvktkt.MaKyThi equals kt.MaKyThi
                             where hs.MaHocSinh == maHS
                             select new { kt.MaKyThi, kt.TenKyThi, kt.NgayThi, hstkt.Diem }).Distinct();
                if (query.Count() == 0)
                {
                    return null;
                }
                return query;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
