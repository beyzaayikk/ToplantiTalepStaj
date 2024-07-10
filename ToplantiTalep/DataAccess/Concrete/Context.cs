using Microsoft.EntityFrameworkCore;
using ToplantiTalep.Models;

namespace ToplantiTalep.DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HB6BD4E;database=ToplantiTalepDB;integrated security=true");
        }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Departman> departmen { get; set; }
        public DbSet<Kullanici> kullanicis { get; set; }
        public DbSet<Kurum> kurums { get; set; }
        public DbSet<Oda> odas { get; set; }
        public DbSet<Talep> taleps { get; set; }
        public DbSet<ToplantiTur> toplantiTurs { get; set; }
    }
}
