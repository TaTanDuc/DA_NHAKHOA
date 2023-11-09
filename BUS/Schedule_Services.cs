using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.SqlServer.Server;

namespace BUS
{
    public class Schedule_Services
    {
        public void Add(Schedule schedule)
        {
            using (var context = new DentalClinicDB())
            {
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
        }

        public List<Schedule> getAll()
        {
            var context = new DentalClinicDB();
            context.Database.Connection.Open();
            return context.Schedules.ToList();
        }
    }
}
