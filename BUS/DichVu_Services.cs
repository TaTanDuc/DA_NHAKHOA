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
                return context.Treatments.OrderBy(t => t.DiagnoseID).ToList();
          
        }

        public List<Diagnose> GetAllDiagnose()
        {
             var context = new NhaKhoaDB();
             return context.Diagnoses.OrderBy(d => d.DiagnoseID).ToList();
           
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
        
        public List<Treatment> GetTrD(int i)
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Treatments.Where(t => t.DiagnoseID == i).OrderBy(t => t.TreatmentID).ToList();
            }
        }

        public Treatment GetPrice(int i1, int i2)
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Treatments.FirstOrDefault(t => t.DiagnoseID == i1 && t.TreatmentID == i2);
            }
        }

        public Diagnose GetDiagnose(int id)
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Diagnoses.FirstOrDefault(d => d.DiagnoseID == id);
            }
        }

        public Treatment GetTreatment(int id,int id1)
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Treatments.FirstOrDefault(t => t.DiagnoseID == id && t.TreatmentID == id1);
            }
        }
    }
}
