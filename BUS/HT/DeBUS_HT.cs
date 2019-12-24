using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.HT;
using DAO.HT;
using DAO;

namespace BUS.HT
{
    public class DeBUS_HT
    {
        public DeDAO deDAO = new DeDAO();

        public List<De> getAllDe()
        {
            return deDAO.getAllDe();
        }
    }
}
