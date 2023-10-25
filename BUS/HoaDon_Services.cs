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

        public int GetID()
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Bills.Count() + 1;
            }
        }

        public Bill GetByTID(int i) 
        {
            var context = new NhaKhoaDB();
            return context.Bills.FirstOrDefault(b => b.TicketID == i);
        }

        public void Add(DateTime date)
        {
            using (var context = new NhaKhoaDB())
            {
                context.Bills.Add(new Bill { BillID = context.Bills.Count() + 1, TicketID = , InvoiceDate = date});
                context.SaveChanges();
            }
        }
    }


}
