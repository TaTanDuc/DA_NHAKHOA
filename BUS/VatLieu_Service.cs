using DAL.Entities;
using System;
using System.Collections.Generic;
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
    }
}
