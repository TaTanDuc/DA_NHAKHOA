using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Status_Services
    {
        public List<Status> GetAll()
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Status.ToList();
            }
        }
    }
}
