﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Registromigrantes.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        // public DbSet<NombreClase> NombreTablaEnBaseDeDatos { get; set; }
    }
}
