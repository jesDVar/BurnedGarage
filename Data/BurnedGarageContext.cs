#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BurnedGarage.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BurnedGarage.Data
{
    public class BurnedGarageContext : IdentityDbContext<Member>
    {
        public BurnedGarageContext (DbContextOptions<BurnedGarageContext> options)
            : base(options)
        {
        }

        public DbSet<BurnedGarage.Models.Member> Member { get; set; }

        public DbSet<BurnedGarage.Models.Vehicle> Vehicle { get; set; }
    }
}
