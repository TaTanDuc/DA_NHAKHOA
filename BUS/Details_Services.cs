using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class Details_Services
    {
        public int Check(Detail detail)
        {
            using (var context = new DentalClinicDB())
            {
                if (context.Details.FirstOrDefault(d => d.PermissionID == detail.PermissionID && d.UserID == detail.UserID && d.Appointment == detail.Appointment) == null)
                    return -1;
            }
            return 1;
        }

        public void Add(Detail detail) 
        {
            using (var context = new DentalClinicDB())
            {
                context.Details.Add(detail);
                context.SaveChanges();
            }
        }

        public void autoAddDetail(Schedule s, List<ServicesDetail> list)
        {
            using (var context = new DentalClinicDB())
            {
                int count = 1;
                context.Details.Add(new Detail() { Appointment = s.Appointment, PermissionID = s.PermissionID, UserID = s.UserID });
                context.UsageDetails.Add(new UsageDetail() { Appointment = s.Appointment, PermissionID = s.PermissionID, UserID = s.UserID });

                foreach (var item in list)
                {
                    context.ServicesDetails.Add(new ServicesDetail()
                    {
                        Count = count,
                        Appointment = item.Appointment,
                        PermissionID = item.PermissionID,
                        UserID = item.UserID,
                        CategoryID = item.CategoryID,
                        ServiceID = item.ServiceID,
                        Quantity = item.Quantity,
                        Total = item.Total
                    });
                    count++;
                }
                context.SaveChanges();
            }
        }
    }
}
