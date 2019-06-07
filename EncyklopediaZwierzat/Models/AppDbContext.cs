using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncyklopediaZwierzat.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options) // dbcontextoptions wymagane 17
        {

        }
        public DbSet<Zwierze> Zwierzeta { get; set; } // odzwierciedlenie 
        public DbSet<Opinia> Opinie { get; set; }
    }
}
