using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DTO;

namespace DAO.HT
{
    public class CauHoiDAO
    {
        DataContextDataContext DB = new DataContextDataContext();

        public List<CauHoiGiaoVien> getAllCauHoi()
        {
            /*
             * Lấy ra danh sách câu hỏi trả về list
             */
            List<CauHoiGiaoVien> cauHois = new List<CauHoiGiaoVien>();

            var cauhois = from cauHoi in DB.CauHois
                          where cauHoi.HocSinhDongGop == false
                          select cauHoi;
            foreach(var cauhoi in cauhois)
            {
                CauHoiGiaoVien temp = new CauHoiGiaoVien();
                temp.MaCauHoi = cauhoi.MaCauHoi;
                temp.NoiDung = cauhoi.NoiDung;
                temp.CauA = cauhoi.CauA;
                temp.CauB = cauhoi.CauB;
                temp.CauC = cauhoi.CauC;
                temp.CauD = cauhoi.CauD;
                temp.CauDung = cauhoi.CauDung;
                temp.DoKhoTen = cauhoi.DoKho1.TenDoKho;
                temp.TenKhoi = cauhoi.Khoi.TenKhoi;

                cauHois.Add(temp);
            }
            return cauHois;
        }

        public List<CauHoi> getAllCauHoiCauHoi()
        {
            /*
             * Lấy ra danh sách câu hỏi trả về list
             */
            List<CauHoi> cauHois = new List<CauHoi>();

            var cauhois = from cauHoi in DB.CauHois
                          where cauHoi.HocSinhDongGop == false
                          select cauHoi;
            foreach(var cauhoi in cauhois)
            {
                CauHoi temp = new CauHoi();
                temp.MaCauHoi = cauhoi.MaCauHoi;
                temp.NoiDung = cauhoi.NoiDung;
                temp.CauA = cauhoi.CauA;
                temp.CauB = cauhoi.CauB;
                temp.CauC = cauhoi.CauC;
                temp.CauD = cauhoi.CauD;
                temp.CauDung = cauhoi.CauDung;
                temp.DoKho1 = cauhoi.DoKho1;
                temp.Khoi = cauhoi.Khoi;

                cauHois.Add(temp);
            }
            return cauHois;
        }

        public CauHoiGiaoVien getOneCauHoiONMaCauHoi(int MaCauHoi)
        {
            /*
             * Tìm kiếm câu hỏi dựa trên mã câu hỏi
             * Nếu không tìm ra câu hỏi -> trả về null
             * Nếu tìm ra câu hỏi -> trả về câu hỏi
            */
            CauHoiGiaoVien cauhoi = new CauHoiGiaoVien();

            var CauHoiFind = from CH in DB.CauHois
                             where CH.MaCauHoi == MaCauHoi
                             select CH;
            if(CauHoiFind.Count() == 0)
            {
                return null;
            }

            foreach(var cauhois in CauHoiFind)
            {
                cauhoi.MaCauHoi = cauhois.MaCauHoi;
                cauhoi.NoiDung = cauhois.NoiDung;
                cauhoi.CauA = cauhois.CauA;
                cauhoi.CauB = cauhois.CauB;
                cauhoi.CauC = cauhois.CauC;
                cauhoi.CauD = cauhois.CauD;
                cauhoi.CauDung = cauhois.CauDung;
                cauhoi.DoKhoTen = cauhois.DoKho1.TenDoKho;
                cauhoi.TenKhoi = cauhois.Khoi.TenKhoi;
            }


            return cauhoi;
        }

        public CauHoi GetOneCauHoi(int MaCauHoi)
        {
            /*
             * Kiếm câu hỏi thông qua mã câu hỏi
             * Nếu không tìm thấy mã câu hỏi  -> trả về null
             * Nếu tìm thấy câu hỏi -> trả về câu hỏi
             */

            CauHoi cauHoi = new CauHoi();

            var findCauHoi = from cau in DB.CauHois
                             where cau.MaCauHoi == MaCauHoi
                             select cau;
            if (findCauHoi.Count() == 0)
            {
                return null;
            }
            foreach(var mem in findCauHoi)
            {
                cauHoi.MaCauHoi = mem.MaCauHoi;
                cauHoi.CauA = mem.CauA;
                cauHoi.CauB = mem.CauB;
                cauHoi.CauC = mem.CauC;
                cauHoi.CauD = mem.CauD;
                cauHoi.CauDung = mem.CauDung;
                cauHoi.DoKho1 = mem.DoKho1;
                cauHoi.Khoi = mem.Khoi;
                cauHoi.NoiDung = mem.NoiDung;
            }
            return cauHoi;
        }

        public int InsertCauHoi(string NoiDung,string CauA,string CauB,string CauC,string CauD,string CauDung,int MaKhoi,int DoKho)
        {
            /*
             * Thêm 1 câu hỏi vào trong cơ sơ dữ liệu trong bảng câu hỏi
             * Nếu CauDung không phải là A , B , C , D -> trả về 1
             * Nếu MaKhoi không tồn tại -> trả về 2
             * Nếu DoKho không tồn tại -> trả về 3
             * Nếu Nội dung trùng -> trả về 4
             * Nếu thành công -> trả về 0
             */

            if(CauDung != "A" && CauDung != "B" && CauDung != "C" && CauDung != "D")
            {
                return 1;
            }
            var CountMaKhoi = from khois in DB.Khois
                              where khois.MaKhoi == MaKhoi
                              select khois;
            if(CountMaKhoi.Count() == 0)
            {
                return 2;
            }
            var CountDoKho = from dokho in DB.DoKhos
                             where dokho.maDoKho == DoKho
                             select dokho;
            if(CountDoKho.Count() == 0)
            {
                return 3;
            }
            var CountNoiDung = from cauhoi in DB.CauHois
                               where cauhoi.NoiDung == NoiDung
                               select cauhoi;
            if(CountNoiDung.Count() != 0)
            {
                return 4;
            }

            CauHoi cauHoi = new CauHoi();
            cauHoi.NoiDung = NoiDung;
            cauHoi.CauA = CauA;
            cauHoi.CauB = CauB;
            cauHoi.CauC = CauC;
            cauHoi.CauD = CauD;
            cauHoi.CauDung = CauDung;
            cauHoi.DoKho = DoKho;
            cauHoi.MaKhoi = MaKhoi;
            cauHoi.HocSinhDongGop = false;

            DB.CauHois.InsertOnSubmit(cauHoi);

            DB.SubmitChanges();
            


            return 0;
        }

        public bool DeleteCauHoi(int MaCauHoi)
        {
            /*
             * Xóa Câu hỏi  thông qua mã câu hỏi 
             * Nếu câu hỏi không tồn tại , trả về false
             * Nếu xóa thành công , trả về true
             */

            var cauhoi = from CH in DB.CauHois
                         where CH.MaCauHoi == MaCauHoi
                         select CH;
            if(cauhoi.Count() ==0)
            {
                return false;
            }
            foreach(var men in cauhoi)
            {
                DB.CauHois.DeleteOnSubmit(men);
            }
            DB.SubmitChanges();
            return true;
        }

        public int UpdateCauHoi(int MaCauHoi,string NoiDung,string CauA,string CauB,string CauC,string CauD,string cauDung,int MaKhoi,int DoKho)
        {
            /*
             * Thêm 1 câu hỏi vào trong cơ sơ dữ liệu trong bảng câu hỏi
             * Nếu CauDung không phải là A , B , C , D -> trả về 1
             * Nếu MaKhoi không tồn tại -> trả về 2
             * Nếu DoKho không tồn tại -> trả về 3
             * Nếu không thay đổi thì -> trả về 4
             * Nếu không tồn tại mã câu hỏi -> trả về 5
             * Nếu câu hỏi chỉnh sửa xong trùng với 1 câu khác thì -> trả về 6
             * Nếu thành công -> trả về 0
             */

            if (cauDung != "A    " && cauDung != "B    " && cauDung != "C    " && cauDung != "D    ")
            {
                return 1;
            }
            var CountMaKhoi = from khois in DB.Khois
                              where khois.MaKhoi == MaKhoi
                              select khois;
            if (CountMaKhoi.Count() == 0)
            {
                return 2;
            }
            var CountDoKho = from dokho in DB.DoKhos
                             where dokho.maDoKho == DoKho
                             select dokho;
            if (CountDoKho.Count() == 0)
            {
                return 3;
            }
            var CountNoiDung = from cauhoi in DB.CauHois
                               where cauhoi.NoiDung == NoiDung && cauhoi.CauA == CauA && cauhoi.CauB == CauB && cauhoi.CauC==CauC && cauhoi.CauD == CauD &&cauhoi.CauDung == cauDung && cauhoi.MaCauHoi == MaCauHoi && cauhoi.MaKhoi == MaKhoi && cauhoi.DoKho == DoKho
                               select cauhoi;
            if (CountNoiDung.Count() != 0)
            {
                return 4;
            }
            var findOneMaCauHoi = from cauhoi in DB.CauHois
                                  where cauhoi.MaCauHoi == MaCauHoi
                                  select cauhoi;
            if(findOneMaCauHoi.Count()==0)
            {
                return 5;
            }
            var CountNoiDungTrungNhau = from cauhoi in DB.CauHois
                                        where cauhoi.MaCauHoi != MaCauHoi && cauhoi.NoiDung == NoiDung
                                        select cauhoi;
            if(CountNoiDungTrungNhau.Count() != 0)
            {
                return 6;
            }

            foreach (var mem in findOneMaCauHoi)
            {
                mem.NoiDung = NoiDung;
                mem.CauA = CauA;
                mem.CauB = CauB;
                mem.CauC = CauC;
                mem.CauD = CauD;
                mem.CauDung = cauDung;
                mem.DoKho = DoKho;
                mem.MaKhoi = MaKhoi;
            }

            DB.SubmitChanges();
            return 0;
        }
    }
}

