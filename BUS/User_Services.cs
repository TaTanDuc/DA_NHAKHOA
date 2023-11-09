using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class User_Services
    {        
        public bool Login(string LoginName, string Password)
        {
            using (var context = new DentalClinicDB())
            {
                if (context.Users.FirstOrDefault(u => u.LoginName == LoginName && u.Password == Password) != null)
                {
                    return true;
                }
                else return false;
            }
        }

        public int AssignUserID(string permissionID)
        {
            using (var context = new DentalClinicDB())
            {
                return context.Users.Count(u => u.PermissionID == permissionID);
            }
        }

        public int Check(string LoginName, string Phone)
        {
            if (LoginName.Any(lg => char.IsLetterOrDigit(lg)) is true)
                return -1;
            using (var context = new DentalClinicDB())
            {
                if (Phone.Any(p => char.IsDigit(p)) is true) 
                {
                    if (context.Users.FirstOrDefault(u => u.Phone == Phone) != null)
                    {
                        return -3;
                    } 
                } else return -2;

                if (context.Users.FirstOrDefault(u => u.LoginName == LoginName) != null)
                {
                    return -4;
                }
                else return 1;
            }
        }

        public void AddUser(User user)
        {
            using (var context = new DentalClinicDB())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public User findByID(string permissionID, int userID)
        {
            using (var context = new DentalClinicDB())
            {
                return context.Users.FirstOrDefault(u => u.PermissionID == permissionID && u.UserID == userID);
            }
        }

        public User findByPhone(string phone)
        {
            using (var context = new DentalClinicDB())
            {
                return context.Users.FirstOrDefault(u => u.Phone == phone);
            }
        }

        public bool validateUser(string permissionID, int userID)
        {
            using (var context = new DentalClinicDB())
            {
                if (context.Users.FirstOrDefault(u => u.PermissionID == permissionID && u.UserID == userID) == null)
                    return false;
            }
            return true;
        }
    }
}
