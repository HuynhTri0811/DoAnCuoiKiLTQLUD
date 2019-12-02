﻿using DAO.HS;
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
    }
}
