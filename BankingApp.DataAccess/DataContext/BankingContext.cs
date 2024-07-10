using BankingApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.DataAccess.DataContext
{
    public class BankingContext : DbContext
    {
        public BankingContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Account> Accounts { get; set; }
    }
}
