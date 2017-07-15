using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class CarDBContext : DbContext
    {
        public virtual DbSet<BankTb> BankTb { get; set; }
        public virtual DbSet<BookingTb> BookingTb { get; set; }
        public virtual DbSet<CarTb> CarTb { get; set; }
        public virtual DbSet<PaymentTb> PaymentTb { get; set; }
        public virtual DbSet<TokenManager> TokenManager { get; set; }
        public virtual DbSet<UserMasterTb> UserMasterTb { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=CarDB;Trusted_Connection=Yes;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankTb>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("PK_BankTB");

                entity.ToTable("BankTB");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BookingTb>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK_Booking");

                entity.ToTable("BookingTB");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.CId).HasColumnName("C_Id");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("Contact_No")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DAddress)
                    .HasColumnName("D_address")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EmailId)
                    .HasColumnName("Email_Id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.PaymentStatus).HasColumnType("varchar(1)");

                entity.Property(e => e.SAddress)
                    .HasColumnName("S_address")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CarTb>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK_CarTB");

                entity.ToTable("CarTB");

                entity.Property(e => e.CId).HasColumnName("C_Id");

                entity.Property(e => e.Brand).HasColumnType("varchar(100)");

                entity.Property(e => e.Color).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Fueltype).HasColumnType("varchar(100)");

                entity.Property(e => e.Image).HasColumnType("varchar(100)");

                entity.Property(e => e.ModelName)
                    .HasColumnName("Model_Name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.NoOfPas).HasColumnName("No_of_Pas");

                entity.Property(e => e.Price).HasColumnType("decimal");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PaymentTb>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK_PaymentTB");

                entity.ToTable("PaymentTB");

                entity.Property(e => e.PId).HasColumnName("P_Id");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.CId).HasColumnName("C_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TokenManager>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("PK_TokenManager");

                entity.Property(e => e.TokenId).HasColumnName("TokenID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiresOn).HasColumnType("datetime");

                entity.Property(e => e.IssuedOn).HasColumnType("datetime");

                entity.Property(e => e.TokenKey).HasColumnType("varchar(100)");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserMasterTb>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("PK_UserMaster");

                entity.ToTable("UserMasterTB");

                entity.Property(e => e.UId).HasColumnName("U_Id");

                entity.Property(e => e.Address).HasColumnType("varchar(100)");

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("Contact_No")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.Password).HasColumnType("varchar(100)");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.Username).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.UserTypeName).HasColumnType("varchar(50)");
            });
        }
    }
}