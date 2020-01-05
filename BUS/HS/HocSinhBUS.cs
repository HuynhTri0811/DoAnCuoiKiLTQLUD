using DAO.HS;
using DTO;
using DTO.HT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.HS
{
    public class HocSinhBUS
    {
        DTO.HT.DataContextDataContext db = new DataContextDataContext();

        public HocSinh FindOneHocSinh(string maHS, string passHS)
        {
            HocSinhDAO hocSinh = new HocSinhDAO();

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
            HocSinhDAO hocSinh = new HocSinhDAO();

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
            HocSinhDAO hocSinh = new HocSinhDAO();

            try
            {
                return hocSinh.AddHocSinh(maHS, hoTen, ngaySinh, diaChi, password);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void UpdateHocSinh(string maHS, string hoTen, DateTime ngaySinh, string diaChi)
        {
            HocSinhDAO hocSinh = new HocSinhDAO();

            try
            {
                hocSinh.UpdateHocSinh(maHS, hoTen, ngaySinh, diaChi);    
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<DeVaCauHoiDTO> GetAllDeThi()
        {
            HocSinhDAO hocSinh = new HocSinhDAO();

            try
            {
                return hocSinh.GetAllDeThi();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<De> LayDanhSachDe(string doKho)
        {
            HocSinhDAO hocSinh = new HocSinhDAO();

            try
            {
                return hocSinh.LayDanhSachDe(doKho);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            
        }

        public List<DeVaCauHoiDTO> LayDeTheoMaDe(string maDe)
        {
            HocSinhDAO hocSinh = new HocSinhDAO();
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
            HocSinhDAO hocSinh = new HocSinhDAO();
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
            HocSinhDAO hocSinh = new HocSinhDAO();
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
            HocSinhDAO hocSinh = new HocSinhDAO();

            try
            {
                return hocSinh.FindDeVaCauHoiTrongKyThi(maHS);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        //thêm kết quả thi vào database
        public void AddKetQuaThi(string maHS, string maDeVaKhoiTrongKyThi, double diem)
        {
            HocSinhDAO hocSinh = new HocSinhDAO();

            try
            {
                hocSinh.AddKetQuaThi(maHS, maDeVaKhoiTrongKyThi, diem);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
