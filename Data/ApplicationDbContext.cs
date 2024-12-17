using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BerberKuafor.Models;

namespace BerberKuafor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BerberKuafor.Models.Kullanici>? Kullanici { get; set; }
        public DbSet<BerberKuafor.Models.Calisan>? Calisan { get; set; }
        public DbSet<BerberKuafor.Models.Randevu>? Randevu { get; set; }
    }
}