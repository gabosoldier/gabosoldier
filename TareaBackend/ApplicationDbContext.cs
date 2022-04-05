using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaBackend.Entidades;

namespace TareaBackend
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DronMedicamento>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dron> Dron { get; set; }
        public DbSet<Medicamento> Medicamento { get; set; }
        public DbSet<DronMedicamento> DronMedicamento { get; set; }
    }
}
