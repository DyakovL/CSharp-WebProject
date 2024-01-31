using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SurRon_VIN.Infrastructure.Data
{
    public class SurRon_VINDbContext : DbContext
    {
        public SurRon_VINDbContext(DbContextOptions<SurRon_VINDbContext> options)
            :base(options)
        {

        }
        
    }
}
