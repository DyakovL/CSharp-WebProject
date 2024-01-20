using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SurRon_VIN.Models;

namespace SurRon_VIN.Data
{
    public class SurRon_VINContext : DbContext
    {
        public SurRon_VINContext (DbContextOptions<SurRon_VINContext> options)
            : base(options)
        {
        }

        public DbSet<SurRon_VIN.Models.Users> Users { get; set; } = default!;
    }
}
