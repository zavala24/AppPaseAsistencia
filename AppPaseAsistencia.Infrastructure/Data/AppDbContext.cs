using AppPaseAsistencia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaseAsistencia.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<Alumno> Alumno => Set<Alumno>();
        public DbSet<Escuela> Escuela => Set<Escuela>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(a => a.IdAlumno);

                entity.HasIndex(a => a.NIA).IsUnique();

                entity.HasOne(a => a.Escuela)
                      .WithMany()   
                      .HasForeignKey(a => a.IdEscuela)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Escuela>(entity =>
            {
                entity.HasKey(e => e.IdEscuela);

                entity.HasIndex(e => e.Cct).IsUnique(); 
            });

            base.OnModelCreating(modelBuilder);
        }
    }

}
