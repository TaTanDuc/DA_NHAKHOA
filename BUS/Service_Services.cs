using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class Service_Services
    {
        public List<ServiceCategory> getCategories()
        {
            using (var context = new DentalClinicDB())
            {
                return context.ServiceCategories.ToList();
            }
        }

        public List<Service> getServices(string categoryID) 
        {
            using (var context = new DentalClinicDB())
            {
                return context.Services.Where(s => s.CategoryID == categoryID).ToList();
            }
        }

        public Service getService(string categoryID, int serviceID)
        {
            var context = new DentalClinicDB();
            context.Database.Connection.Open();
            return context.Services.FirstOrDefault(s => s.CategoryID == categoryID && s.ServiceID == serviceID);
        }
    }
}
