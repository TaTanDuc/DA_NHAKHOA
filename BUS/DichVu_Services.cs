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
            using (var context = new NhaKhoaDB())
            {
                return context.Treatments.ToList();
            }
        }

        public List<Diagnose> GetAllDiagnose()
        {
            using (var context = new NhaKhoaDB())
            {
                return context.Diagnoses.ToList();
            }
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
            using (var context = new NhaKhoaDB())
            {
                context.Diagnoses.AddOrUpdate(d);
                context.SaveChanges();
            }
        }

        public void removeDiagnose(Diagnose d)
        {
            using (var context = new NhaKhoaDB())
            {
                context.Diagnoses.Remove(d);
                context.SaveChanges();
            }
        }

        public void removeTreatment(Treatment t)
        {
            using (var context = new NhaKhoaDB())
            {
                context.Treatments.Remove(t);
                context.SaveChanges();
            }
        }

    }
}
