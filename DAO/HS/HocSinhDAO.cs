using DTO.HT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.HS
{
    public class HocSinhDAO
    {
        DTO.HT.DataContextDataContext db = new DataContextDataContext();

        public HocSinh FindOneHocSinh(string maHS, string passHS)
        {
            HocSinh hocSinh = new HocSinh();

            try
            {
                var findOneHS = from hs in db.HocSinhs
                                where hs.MaHocSinh == maHS && hs.Password == passHS
                                select hs;
                if(findOneHS.Count() != 0)
                {
                    foreach (var hs in findOneHS)
                    {
                        hocSinh.MaHocSinh = hs.MaHocSinh;
                        hocSinh.Password = hs.Password;
                        hocSinh.HoTen = hs.HoTen;
                        hocSinh.NgaySinh = hs.NgaySinh;
                        hocSinh.MaLop = hs.MaLop;
                        hocSinh.Lop = hs.Lop;
                    }
                    return hocSinh;
                }

                return null;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }            
        }

    }
}
