using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Sis_Escolar.Models;
    public class AppDbContext : DbContext {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }


        public DbSet<Estudiante> Estudiantes { get; set; }
         public DbSet<Calificacion> Calificacion { get; set; }

        public DbSet<Tutor> Tutores {get; set;}

        public DbSet<Grado> Grados {get; set;}


        
    }