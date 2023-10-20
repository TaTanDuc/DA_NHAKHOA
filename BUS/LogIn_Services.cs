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
                var tempUser = context.LogIns.FirstOrDefault(l => l.StaffID == ID);
                var tempPass = context.LogIns.FirstOrDefault(l => l.Password == Pass);
                if (tempUser != null && tempPass != null)
                    return 1;
                else if (tempUser != null && tempPass == null)
                    return 0;
                else
                    return -1;
            }
        }

    }
}
