using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Orders72.Shared.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Orders72.backend.Data
{
    public class DataContext : IdentityDbContext<User> //Herada del IdentiTyDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }//Propiedad que maneja mi entidad Country que va a crear una tabla Countries
                                                     //Basada en el modelo country.
        public DbSet<State> States { get; set; }

        //Método que me permite hacer cambios en la base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); //Valida que los registros sean únicos por nombre
            modelBuilder.Entity<State>().HasIndex(s => new { s.CountryId, s.Name }).IsUnique();
            modelBuilder.Entity<City>().HasIndex(c => new { c.StateId, c.Name }).IsUnique();
            DisableCascadingDelete(modelBuilder);

        }
        private void DisableCascadingDelete(ModelBuilder modelBuilder)
        {
            var relationships = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys());
            foreach (var relationship in relationships)
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }
    }
}

