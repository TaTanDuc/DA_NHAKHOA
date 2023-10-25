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
    public class PhieuKham_Services
    {
        private readonly BenhNhanServices benhNhanServices = new BenhNhanServices();
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

        public List<ExamTicket> Tim(string s)
        {
            var context = new NhaKhoaDB();
            return context.ExamTickets.Where(t => t.Customer.FullName == s || t.Customer.Phone == s).ToList();
        }

        public List<ExamTicket> GetToday()
        {
            DateTime date = DateTime.Today;
            var context = new NhaKhoaDB();
            return context.ExamTickets.Where(e => e.AppointmentDate >= date).ToList();
        }

        public void SaveDetails(string CID, DateTime ApD , int d, int tr, int q, int t)
        {
            var context = new NhaKhoaDB();
            var count = context.ExamTickets.Count();
            context.ExamTickets.Add(new ExamTicket { TicketID = count + 1 ,CustomerID = CID , AppointmentDate = ApD , StatusID = 0});
            context.ExamDetails.Add(new ExamDetail { TicketID = count + 1 ,DiagnoseID = d , TreatmentID = tr, Quantity = q , Total = t});
            context.SaveChanges();
        }

        public int GetTicketID()
        {
            using (var context = new NhaKhoaDB())
            {
                return context.ExamTickets.Count() + 1;
            }
        }

    }
}
