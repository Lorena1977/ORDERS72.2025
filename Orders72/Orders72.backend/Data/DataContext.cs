using Microsoft.EntityFrameworkCore;
using Orders72.Shared.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Orders72.backend.Data
{
    public class DataContext : DbContext //Herada del DbContext.
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }//Propiedad que maneja mi entidad Country que va a crear una tabla Countries
        //Basada en el modelo country.

        //Método que me permite hacer cambios en la base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); //Valida que los registros sean únicos por nombre
        }
    }


}
