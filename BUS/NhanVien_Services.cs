using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class NhanVien_Services
    {
        public List<Staff> GetAllStaff()
        {
            var context = new NhaKhoaDB();
            return context.Staffs.ToList();
        }

        public List<LogIn> GetAllLogIn()
        {
            var context = new NhaKhoaDB();          
            return context.LogIns.ToList();           
        }

        public List<Staff> Find(string find)
        {
            var context = new NhaKhoaDB();
            
                return context.Staffs.Where(p => p.StaffID == find || p.FullName == find).ToList();
            
        }

        public Staff GetStaff(string id)
        {
            var context = new NhaKhoaDB();
            return context.Staffs.FirstOrDefault(p => p.StaffID == id);
        }

        public void addOrUpdate(Staff s)
        {
            var context = new NhaKhoaDB();
            context.Staffs.AddOrUpdate(s);
            context.SaveChanges();
           
        }
        public void addStaff(Staff s)
        {
            var context = new NhaKhoaDB();                
            context.Staffs.Add(s);
            context.SaveChanges();
          
        }

        public void remove(Staff s)
        {
            var context = new NhaKhoaDB();          
            context.Staffs.Remove(s);
            context.SaveChanges();          
        }



    }
}
