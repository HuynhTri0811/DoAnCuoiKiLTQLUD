using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DAO.HT;

namespace BUS.HT
{
    public class DoKhoBUS_HT
    {
        DoKhoDAO khoDAO = new DoKhoDAO();
        public List<DoKho> getAll()
        {
            return khoDAO.getAll();
        }
    }
}
