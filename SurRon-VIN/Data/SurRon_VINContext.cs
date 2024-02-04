using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP;
using Microsoft.AspNetCore.Mvc;
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


        public IActionResult IsDataValid(SurRon_VINContext context, string username, string password)
        {
            return View(_Page_Views_UserDesign__Layout_cshtml);
        }
    }

    
}
