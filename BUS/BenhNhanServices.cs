using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class BenhNhanServices
    {
        public List<Customer> GetAll()
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Customers.ToList();
            }
            
        }
        public List<Customer> Find(string find)
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Customers.Where(p => p.FullName == find || p.CustomerID == find).ToList();
            }
        }

        public Customer FindByID(string ID) 
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Customers.FirstOrDefault(p => p.CustomerID == ID);
            }
        }

        public void addOrUpdate(Customer c)
        {
            using (var context = new NhaKhoaDB())
            {
                context.Customers.AddOrUpdate(c);
                context.SaveChanges();
            }
        }

        public void remove(Customer c)
        {
            using (var context = new NhaKhoaDB())
            {
                context.Customers.Remove(c);
                context.SaveChanges();
            }
        }

        public void AddOrUpdateDuc(Customer cs)
        {
            using (var context = new NhaKhoaDB())
            {
                context.Customers.AddOrUpdate(cs);
                context.SaveChanges();
            }
        }
    }
}
