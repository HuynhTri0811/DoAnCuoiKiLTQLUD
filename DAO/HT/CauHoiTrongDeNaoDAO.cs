using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DTO;

namespace DAO.HT
{
    
    public class CauHoiTrongDeNaoDAO
    {

        public List<CauHoiTrongDeNao> getAllCauHoiTrongDeNao()
        {
            /*
             * lấy ra toàn bộ danh sách câu hỏi trong đề nào 
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                List<CauHoiTrongDeNao> cauHoiTrongDeNaos = new List<CauHoiTrongDeNao>();
                var findAllCauHoi = from CHTDN in DB.CauHoiTrongDeNaos
                                    select CHTDN;
                foreach (var mem in findAllCauHoi)
                {
                    cauHoiTrongDeNaos.Add(mem);
                }
                return cauHoiTrongDeNaos;
            }
        }

        public DeVaCauHoiOnMaDeDTO getAllCauHoiTrongDe(string MaDe,int MaKhoi)
        {
            /*
             * Tìm Câu hỏi trong đề nào
             * Nếu không tìm tấy Mã đề và mã khối  trong CSDL -> trả về null
             * Nếu tìm thấy -> trả về Mã đề + List cau hỏi
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                DeVaCauHoiOnMaDeDTO getAllCauHoiOnMaDe = new DeVaCauHoiOnMaDeDTO();
                var findMaDe = from D in DB.CauHoiTrongDeNaos
                               where D.MaDe == MaDe && D.MaKhoi == MaKhoi
                               select D;
                if (findMaDe.Count() == 0)
                {
                    return null;
                }
                int tempCount = 0;
                foreach (var mem in findMaDe)
                {
                    if (tempCount == 0)
                    {
                        getAllCauHoiOnMaDe.MaDe = mem.MaDe;
                        getAllCauHoiOnMaDe.MaKhoi = mem.MaKhoi;
                        tempCount++;
                    }
                    getAllCauHoiOnMaDe.listCauHoiOnMaDe.Add(mem.CauHoi);
                }
                return getAllCauHoiOnMaDe;
            }
        }

        public int InsertDeVaCauHoi(string MaDe,int MaCauHoi,int MaKhoi)
        {
            /*
             * Thêm câu hỏi vào trong đề thi  dựa trên : mã đề , mã câu hỏi , mã khối
             * Nếu Mã đề không tồn tại -> trả về 1
             * Nếu mã câu hỏi không tồn tại -> trả về 2
             * Nếu mã khối không tồn tại thì -> trả về 3
             * Nếu mã đề và mã câu hỏi và mã khối tồn tại trong bảng DeVaCauHoi -> trả về 4
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findOneMaDe = from D in DB.Des
                                  where D.MaDe == MaDe
                                  select D;
                if (findOneMaDe.Count() == 0)
                {
                    return 1;
                }
                var findOneMaCauHoi = from CH in DB.CauHois
                                      where CH.MaCauHoi == MaCauHoi
                                      select CH;
                if (findOneMaCauHoi.Count() == 0)
                {
                    return 2;
                }
                var findOneMaKhoi = from KH in DB.Khois
                                    where KH.MaKhoi == MaKhoi
                                    select KH;
                if (findOneMaKhoi.Count() == 0)
                {
                    return 3;
                }
                var findOneMaCauHoiOnMaDeOnMaKhoi = from MCH in DB.CauHoiTrongDeNaos
                                                    where MCH.MaDe == MaDe && MCH.MaKhoi == MaKhoi && MCH.MaCauHoi == MaCauHoi
                                                    select MCH;
                if (findOneMaCauHoiOnMaDeOnMaKhoi.Count() != 0)
                {
                    return 4;
                }

                CauHoiTrongDeNao cauHoiTrongDeNao = new CauHoiTrongDeNao();
                cauHoiTrongDeNao.MaCauHoi = MaCauHoi;
                cauHoiTrongDeNao.MaDe = MaDe;
                cauHoiTrongDeNao.MaKhoi = MaKhoi;

                DB.CauHoiTrongDeNaos.InsertOnSubmit(cauHoiTrongDeNao);
                DB.SubmitChanges();
                return 0;
            }
        }

        public int DeleteCauHoiONMaDeVaMaKhoi(string MaDe, int MaCauHoi, int MaKhoi)
        {
            /*
             * Xóa câu hỏi trong đề dựa trên mã đề , mã câu hỏi , mã khối
             * Nếu MaDe,MaCauHoi,MaKhoi không tồn tại trong bảng câu hỏi -> trả về 1
             * Xóa thành công -> trả về 2
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findCauHoiOnMaDeAndMaKhoi = from CH in DB.CauHoiTrongDeNaos
                                                where CH.MaCauHoi == MaCauHoi && CH.MaDe == MaDe && CH.MaKhoi == MaKhoi
                                                select CH;
                if (findCauHoiOnMaDeAndMaKhoi.Count() == 0)
                {
                    return 1;
                }
                foreach (var mem in findCauHoiOnMaDeAndMaKhoi)
                {
                    DB.CauHoiTrongDeNaos.DeleteOnSubmit(mem);
                }
                DB.SubmitChanges();
                return 0;
            }
        }
        public int UpdateCauHoiOnMaDeVaMaKhoi(string MaDe, int MaCauHoiCu, int MaKhoi, int MaCauHoiMoi)
        {
            /*
             * Update Câu hỏi dựa trên mã đề và mã khối
             * Nếu không tìm thấy mã đề , mã câu hỏi cũ , mã khối -> trả về 1
             * Nếu không tìm thấy câu hỏi mới -> trả về 2
             * Nếu Update mã đề , mã câu hỏi mới , mã khối có trong database rồi -> trả về 3
             * Update thành công trả về ->0
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                var findmaDeMaCauHoiCuVaMaKhoi = from CH in DB.CauHoiTrongDeNaos
                                                 where CH.MaCauHoi == MaCauHoiCu && CH.MaDe == MaDe && CH.MaKhoi == MaKhoi
                                                 select CH;
                if (findmaDeMaCauHoiCuVaMaKhoi.Count() == 0)
                {
                    return 1;
                }
                var findCauHoiMoi = from CH in DB.CauHois
                                    where CH.MaCauHoi == MaCauHoiMoi
                                    select CH;
                if (findCauHoiMoi.Count() == 0)
                {
                    return 2;
                }
                var findCauHoiMoiONMaKhoiAndMaDe = from CH in DB.CauHoiTrongDeNaos
                                                   where CH.MaCauHoi == MaCauHoiMoi && CH.MaDe == MaDe && CH.MaKhoi == MaKhoi
                                                   select CH;
                if (findCauHoiMoiONMaKhoiAndMaDe.Count() == 0)
                {
                    return 3;
                }

                foreach (var mem in findmaDeMaCauHoiCuVaMaKhoi)
                {
                    mem.MaCauHoi = MaCauHoiMoi;
                }
                DB.SubmitChanges();
                return 0;
            }
        }
    }
}
