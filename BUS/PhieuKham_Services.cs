using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class PhieuKham_Services
    {
        public List<ExamTicket> GetAll()
        {
            var context = new NhaKhoaDB();
          //  var list = context.ExamTickets.Select(t => new { FullName = t.Customer.FullName, BDay = t.Customer.BirthDay, SDT = t.Customer.Phone, ApDate = t.AppointmentDate }).ToList();
            return context.ExamTickets.ToList();
        }
    }
}
