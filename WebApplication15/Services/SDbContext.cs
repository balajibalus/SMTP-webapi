using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication15.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApplication15.Services
{
    public class SDbContext : DbContext
    {
        public SDbContext(DbContextOptions<SDbContext> options) : base(options)
        {
            Database.Migrate();
        }
        public virtual DbSet<Gmail> Gmails { get; set; }
    }
}

