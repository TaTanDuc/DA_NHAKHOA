using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class NhaKhoaDB : DbContext
    {
        public NhaKhoaDB()
            : base("name=NhaKhoaDB")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Diagnose> Diagnoses { get; set; }
        public virtual DbSet<ExamDetail> ExamDetails { get; set; }
        public virtual DbSet<ExamTicket> ExamTickets { get; set; }
        public virtual DbSet<ImportExportTicket> ImportExportTickets { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<ToolAndMaterial> ToolAndMaterials { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Diagnose>()
                .HasMany(e => e.Treatments)
                .WithRequired(e => e.Diagnose)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExamTicket>()
                .Property(e => e.CustomerID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExamTicket>()
                .Property(e => e.StaffID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExamTicket>()
                .HasOptional(e => e.ExamDetail)
                .WithRequired(e => e.ExamTicket);

            modelBuilder.Entity<ImportExportTicket>()
                .Property(e => e.IorE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LogIn>()
                .Property(e => e.StaffID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LogIn>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prescription>()
                .Property(e => e.CustomerID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasOptional(e => e.LogIn)
                .WithRequired(e => e.Staff);

            modelBuilder.Entity<Treatment>()
                .HasMany(e => e.ExamDetails)
                .WithOptional(e => e.Treatment)
                .HasForeignKey(e => new { e.DiagnoseID, e.TreatmentID });
        }
    }
}
