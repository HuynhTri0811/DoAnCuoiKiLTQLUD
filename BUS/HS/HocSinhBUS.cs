using DAO.HS;
using DTO;
using DTO.HT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.HS
{
    public class HocSinhBUS
    {
        DTO.HT.DataContextDataContext db = new DataContextDataContext();
        HocSinhDAO hocSinh = new HocSinhDAO();

        public HocSinh FindOneHocSinh(string maHS, string passHS)
        {
            try
            {
                return hocSinh.FindOneHocSinh(maHS, passHS);
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
                return hocSinh.LastMaHocSinh();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public Boolean AddHocSinh(string maHS, string hoTen, DateTime ngaySinh, string diaChi, string password)
        {
            try
            {
                return hocSinh.AddHocSinh(maHS, hoTen, ngaySinh, diaChi, password);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void UpdateHocSinh(string maHS, string hoTen, DateTime ngaySinh, string diaChi, string maLop)
        {
            try
            {
                hocSinh.UpdateHocSinh(maHS, hoTen, ngaySinh, diaChi, maLop);    
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<DeVaCauHoiDTO> GetAllDeThi(string maHS)
        {
            try
            {
                return hocSinh.GetAllDeThi(maHS);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<De> LayDanhSachDe(string doKho, string maHS)
        {
            try
            {
                return hocSinh.LayDanhSachDe(doKho, maHS);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            
        }

        public List<DeVaCauHoiDTO> LayDeTheoMaDe(string maDe)
        {
            try
            {
                return hocSinh.LayDeTheoMaDe(maDe);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public int LayMaKhoiTheoMaDe(string maDe)
        {
            try
            {
                return hocSinh.LayMaKhoiTheoMaDe(maDe);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //thêm kết quả thi thử vào database
        public Boolean AddKetQuaThiThu(string maHS, string maDe, int maKhoi, double diem)
        {
            try
            {
                return hocSinh.AddKetQuaThiThu(maHS, maDe, maKhoi, diem);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //tìm kỳ thi cho học sinh theo mã
        public List<DeVaCauHoiThiDTO> FindDeVaCauHoiTrongKyThi(string maHS)
        {
            try
            {
                return hocSinh.FindDeVaCauHoiTrongKyThi(maHS);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //lấy tên kỳ thi
        public string GetNameKyThi(string maHS)
        {
            try
            {                
                return hocSinh.GetNameKyThi(maHS);
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
                hocSinh.AddKetQuaThi(maHS, maDeVaKhoiTrongKyThi, diem);
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
                return hocSinh.GetAllLichSuThiThu(maHS);
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
                return hocSinh.GetAllLichSuKetQuaThi(maHS);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public IQueryable GetLichThi(string maHS)
        {
            try
            {
                return hocSinh.GetLichThi(maHS);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //lấy danh sách lớp
        public List<Lop> LayDanhSachLop()
        {
            try
            {
                return hocSinh.LayDanhSachLop();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
