using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
namespace WebApplication1.DBContext
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        //public DbSet<UserMasterTB> UserMasterTB { get; set; }
        //public DbSet<CarTB> CarTB { get; set; }
        //public DbSet<BookingTB> BookingTB { get; set; }
        //public DbSet<PaymentTB> PaymentTB { get; set; }
        //public DbSet<BankTB> BankTB { get; set; }
        //public DbSet<TokenManager> TokenManager { get; set; }
        //public DbSet<UserType> UserType { get; set; }
    }
}
