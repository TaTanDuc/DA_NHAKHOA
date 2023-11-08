using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class DentalClinicDB : DbContext
    {
        public DentalClinicDB()
            : base("name=DentalClinicDB")
        {
        }

        public virtual DbSet<Detail> Details { get; set; }
        public virtual DbSet<ImportExport> ImportExports { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServicesDetail> ServicesDetails { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<UsageDetail> UsageDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detail>()
                .Property(e => e.PermissionID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Detail>()
                .HasMany(e => e.Invoices)
                .WithOptional(e => e.Detail)
                .HasForeignKey(e => new { e.Appointment, e.PermissionID, e.UserID });

            modelBuilder.Entity<Detail>()
                .HasOptional(e => e.ServicesDetail)
                .WithRequired(e => e.Detail);

            modelBuilder.Entity<ImportExport>()
                .Property(e => e.ItemType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.PermissionID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ItemType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ImportExports)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => new { e.ItemType, e.ItemID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Storages)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => new { e.ItemType, e.ItemID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permission>()
                .Property(e => e.PermissionID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Permission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prescription>()
                .HasMany(e => e.PrescriptionDetails)
                .WithRequired(e => e.Prescription)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.PermissionID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Schedule>()
                .HasOptional(e => e.Detail)
                .WithRequired(e => e.Schedule);

            modelBuilder.Entity<Schedule>()
                .HasOptional(e => e.UsageDetail)
                .WithRequired(e => e.Schedule);

            modelBuilder.Entity<ServiceCategory>()
                .Property(e => e.CategoryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ServiceCategory>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.ServiceCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.CategoryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ServicesDetails)
                .WithOptional(e => e.Service)
                .HasForeignKey(e => new { e.CategoryID, e.ServiceID });

            modelBuilder.Entity<ServicesDetail>()
                .Property(e => e.PermissionID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ServicesDetail>()
                .Property(e => e.CategoryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.StatusID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Storage>()
                .Property(e => e.ItemType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Storage>()
                .Property(e => e.StatusID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Storage>()
                .HasMany(e => e.UsageDetails)
                .WithOptional(e => e.Storage)
                .HasForeignKey(e => new { e.ItemType, e.ItemID, e.ItemNO });

            modelBuilder.Entity<UsageDetail>()
                .Property(e => e.PermissionID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UsageDetail>()
                .Property(e => e.ItemType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LoginName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PermissionID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.User)
                .HasForeignKey(e => new { e.PermissionID, e.UserID })
                .WillCascadeOnDelete(false);
        }
    }
}
