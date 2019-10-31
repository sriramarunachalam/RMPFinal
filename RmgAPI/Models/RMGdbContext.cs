using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RmgAPI.Models;

namespace RmgAPI.Models
{
    public class RMGdbContext: DbContext
    {
        public RMGdbContext(DbContextOptions<RMGdbContext> options) : base(options)
        { }

        public DbSet<Account> accounts { get; set; }
        public DbSet<ListOfRequests> listOfRequests { get; set; }
       // public DbSet<ListOfRequests> Employees { get; set; }
        public DbSet<Employees> Employees { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
