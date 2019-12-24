﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.HT;
using DAO.HT;

namespace BUS.HT
{
    public class CauHoiTrongDeNaoBUS_HT
    {
        DAO.HT.CauHoiTrongDeNaoDAO cauHoiTrongDeNaoDAO = new CauHoiTrongDeNaoDAO();
        public DeVaCauHoiOnMaDeDTO getAllCauHoiTrongDe(string MaDe, int MaKhoi)
        {
            return cauHoiTrongDeNaoDAO.getAllCauHoiTrongDe(MaDe, MaKhoi);
        }

    }
}
