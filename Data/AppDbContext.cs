using ClinicaVeterinariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinariaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
    }
}
