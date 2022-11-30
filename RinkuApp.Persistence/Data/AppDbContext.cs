using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RinkuApp.Persistence.Models;

namespace RinkuApp.Persistence.Data
{
    public  class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<A01Empleados> A01Empleados { get; set; }
        public DbSet<A02Roles> A02Roles { get; set; }
        public DbSet<B01Salarios> B01Salarios { get; set; }
        public DbSet<B02RolEmpleado> B02RolEmpleado { get; set; }
        public DbSet<B03EntregasEmpleado> B03EntregasEmpleado { get; set; }
        public DbSet<X01ParametrosGenerales> X01ParametrosGenerales { get; set; }
        public DbSet<BitacoraHorasLaboradas> BitacoraHorasLaboradas { get; set; }
    }
}
