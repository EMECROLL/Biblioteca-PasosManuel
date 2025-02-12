using Biblioteca_PasosManuel.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_PasosManuel.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
        }

        // Modelos para la BD
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        // Seeder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    PKUsuario = 1,
                    Nombre = "Manuel",
                    Apellido = "Pasos",
                    UserName = "MPasos",
                    Password = "root",
                    FKRol = 1,
                }
            );

            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    PKRol = 1,
                    Nombre = "Admin",
                }  
            );
        }
    }
}
