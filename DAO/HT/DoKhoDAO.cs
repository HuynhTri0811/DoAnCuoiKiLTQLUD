﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DTO.HT;

namespace DAO.HT
{
    public class DoKhoDAO
    {
        public List<DoKho> getAll()
        {
            /*
             * Lay het do kho trong db
             */
            using (DataContextDataContext DB = new DataContextDataContext())
            {
                List<DoKho> DoKho = new List<DoKho>();

                var doKho = from DK in DB.DoKhos
                            select DK;
                foreach (var d in doKho)
                {
                    DoKho.Add(d);
                }
                return DoKho;
            }
        }
    }
}