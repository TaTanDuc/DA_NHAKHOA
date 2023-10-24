using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class VatLieu_Service
    {
        public List<ToolAndMaterial> GetAll()
        {
            var context = new NhaKhoaDB();
            return context.ToolAndMaterials.ToList();
        }

        public List<ImportExportTicket> GetAllTicket()
        {
            var context = new NhaKhoaDB();
            return context.ImportExportTickets.ToList();
        }

        public void AddTicket(ImportExportTicket ticket)
        {
            var context = new NhaKhoaDB();
            context.ImportExportTickets.Add(ticket);
            context.SaveChanges();
        }

        public void AddTool(ToolAndMaterial tl)
        {
            var context = new NhaKhoaDB();
            context.ToolAndMaterials.Add(tl);
            context.SaveChanges();
        }

        public ImportExportTicket FindByID(int id)
        {
            var context = new NhaKhoaDB();
            return context.ImportExportTickets.FirstOrDefault(p => p.IETicketID == id);
        }

        public ToolAndMaterial FindIDTol(int id)
        {
            var context = new NhaKhoaDB();
            return context.ToolAndMaterials.FirstOrDefault(p => p.TaM_ID == id);
        }


        public void addOrUpdateIMP(ImportExportTicket imp)
        {
            var context = new NhaKhoaDB();
            context.ImportExportTickets.AddOrUpdate(imp);
            context.SaveChanges();
        }

        public void addOrUpdateTol(ToolAndMaterial tol)
        {
            var context = new NhaKhoaDB();
            context.ToolAndMaterials.AddOrUpdate(tol);
            context.SaveChanges();
        }
    }
}
