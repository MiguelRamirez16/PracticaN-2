
using Construction.Shared.Entidades;
using Construction.Shared.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }
        public DbSet<AsignacionEquipo> AsignacionEquipos { get; set; }

        public DbSet<AsignacionMaterial> AsignacionMateriales { get; set; }

        public DbSet<EquipoConstruccion> EquipoConstrucciones { get; set; }

        public DbSet<Maquinaria> Maquinarias { get; set; }

        public DbSet<Material> Materiales { get; set; }

        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<ProyectoConstruccion> ProyectoConstrucciones { get; set; }

        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
