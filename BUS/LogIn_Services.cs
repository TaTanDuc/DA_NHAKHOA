using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class LogIn_Services
    {
        public int LogIn(string ID,string Pass)
        {
            using (var context = new NhaKhoaDB())
            {
                var temp = context.LogIns.FirstOrDefault(l => l.StaffID == ID && l.Password == Pass);
                if (temp != null)
                    return 1;
                else
                    return 0;
            }
        }

    }
}
