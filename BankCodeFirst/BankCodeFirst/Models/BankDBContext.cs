using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCodeFirst.Models
{
    public class BankDBContext : DbContext
    {
        public BankDBContext() : base("MyDb")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<CreditInfo> CreditInfos { get; set; }

    }
}
