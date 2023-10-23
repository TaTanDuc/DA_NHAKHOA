using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            return context.ExamTickets.ToList();
        }

        public List<ExamTicket> Find(string s, DateTime d, int i)
        {
            var context = new NhaKhoaDB();
            return context.ExamTickets.Where(t =>  t.AppointmentDate == d && t.StatusID == i || t.Customer.FullName == s || t.Customer.Phone == s).ToList();
        }

        public List<ExamTicket> GetToday()
        {
            var context = new NhaKhoaDB();
            var date = DateTime.Now;
            return context.ExamTickets.Where(t => t.AppointmentDate == date).ToList();
        }
    }
}
