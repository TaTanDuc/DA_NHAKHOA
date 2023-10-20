using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon_Services
    {
        public List<Bill> GetAll()
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Bills.ToList();
            }
        }
    }


}
