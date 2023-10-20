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
        public List<Staff> GetAll()
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Staffs.ToList();
            }
        }

        public List<Staff> Find(string find)
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Staffs.Where(p => p.StaffID == find || p.FullName == find).ToList();
            }
        }

        public void addOrUpdate(Staff s)
        {
            using (var context = new NhaKhoaDB())
            {
                context.Staffs.AddOrUpdate(s);
                context.SaveChanges();
            }
        }

        public void remove(Staff s)
        {
            using (var context = new NhaKhoaDB())
            {
                context.Staffs.Remove(s);
                context.SaveChanges();
            }
        }

    }
}
