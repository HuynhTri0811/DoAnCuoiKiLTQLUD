﻿using System;
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
        DataContextDataContext DB = new DataContextDataContext();
        public List<MaDeVaKhoiTrongKiThi> GetAllMaDeVaKhoiTrongKiThi()
        {
            /*
             * Lấy hết danh sách trong mã khối trong kì thi
             * 
             */

            List<MaDeVaKhoiTrongKiThi> maDeVaKhoiTrongKiThis = new List<MaDeVaKhoiTrongKiThi>();

            var findAllMaDeVaKhoITrongKiThis = from D in DB.MaDeVaKhoiTrongKiThis
                                               select D;
            if (findAllMaDeVaKhoITrongKiThis.Count() == 0)
            {
                return null;
            }
            foreach(var mem in findAllMaDeVaKhoITrongKiThis)
            {
                maDeVaKhoiTrongKiThis.Add(mem);
            }
            return maDeVaKhoiTrongKiThis;
        }

        public List<MaDeVaKhoiTrongKiThi> GetAllMaDeOneTrongKiThi(string MaKiThi)
        {
            /*
             * 
             */

            return null;
        }
    }
}
