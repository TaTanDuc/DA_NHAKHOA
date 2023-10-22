using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class DichVu_Services
    {
        public List<Treatment> GetAllTreatment()
        {
            var context = new NhaKhoaDB();
                return context.Treatments.ToList();
          
        }

        public List<Diagnose> GetAllDiagnose()
        {
             var context = new NhaKhoaDB();
            
                return context.Diagnoses.ToList();
           
        }

        public void addOrUpdateTreatment(Treatment t)
        {
            using (var context = new NhaKhoaDB())
            {
                context.Treatments.AddOrUpdate(t);
                context.SaveChanges();
            }
        }

        public void addOrUpdateDiagnose(Diagnose d)
        {
            var context = new NhaKhoaDB();
            
                context.Diagnoses.AddOrUpdate(d);
                context.SaveChanges();
            
        }

        public void removeDiagnose(Diagnose d)
        {
            var context = new NhaKhoaDB();
            
                context.Diagnoses.Remove(d);
                context.SaveChanges();
            
        }

        public void removeTreatment(Treatment t)
        {
            var context = new NhaKhoaDB();
           
              context.Treatments.Remove(t);
              context.SaveChanges();
            
        }

    }
}
