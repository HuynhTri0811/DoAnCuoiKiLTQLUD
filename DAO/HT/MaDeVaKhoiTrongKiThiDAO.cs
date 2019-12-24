using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.HT;
using DAO;  

namespace DAO.HT
{
    public class MaDeVaKhoiTrongKiThiDAO
    {

        public List<MaDeVaKhoiTrongKiThi> GetAllMaDeVaKhoiTrongKiThi()
        {
            /*
             * Lấy hết danh sách trong mã khối trong kì thi
             * 
             */

            using (DataContextDataContext DB = new DataContextDataContext())
            {

                List<MaDeVaKhoiTrongKiThi> maDeVaKhoiTrongKiThis = new List<MaDeVaKhoiTrongKiThi>();

                var findAllMaDeVaKhoITrongKiThis = from D in DB.MaDeVaKhoiTrongKiThis
                                                   select D;
                if (findAllMaDeVaKhoITrongKiThis.Count() == 0)
                {
                    return null;
                }
                foreach (var mem in findAllMaDeVaKhoITrongKiThis)
                {
                    maDeVaKhoiTrongKiThis.Add(mem);
                }
                return maDeVaKhoiTrongKiThis;
            }
        }


        
    }
}
