using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Registromigrantes.Components.Pages;
using FormularioShared = Registromigrantes.shared.Formulario; // Alias para evitar ambigüedad
using LoginShared = Registromigrantes.shared.Login; // Alias para evitar ambigüedad

namespace Registromigrantes.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FormularioShared> Formulario { get; set; } // Usar alias para evitar ambigüedad
        public DbSet<LoginShared> Login { get; set; } // Usar alias para evitar ambigüedad

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormularioShared>()
                .HasKey(f => f.Id); // Definir la clave primaria para la entidad Formulario
            modelBuilder.Entity<LoginShared>()
                .HasKey(f => f.Id); // Definir la clave primaria para la entidad Login

            base.OnModelCreating(modelBuilder);
        }
    }
}

