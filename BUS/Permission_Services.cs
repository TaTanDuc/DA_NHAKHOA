using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class Permission_Services
    {
       public List<Permission> GetAll()
       {
            using (var context = new DentalClinicDB())
            {
                return context.Permissions.ToList();
            } 
       }
    }
}
