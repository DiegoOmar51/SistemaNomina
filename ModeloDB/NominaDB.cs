using Microsoft.EntityFrameworkCore;
using Modelo1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class NominaDB:DbContext
    {
        
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<DecimoCuarto> DecimoCuartos { get; set; }
        public DbSet<DecimoTercero> DecimoTerceros { get; set; }
        public DbSet<FondoReserva> FondosReserva { get; set; }
        public DbSet<HorasExt> HorasExts { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Vacaciones> Vacaciones { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "server=DESKTOP-FAR92HR; initial catalog=PROYECTONOMINA; trusted_connection=true;"
                );
        }
        public NominaDB() : base()
        {

        }
        public NominaDB(DbContextOptions<NominaDB> opciones)
            :base(opciones)
        {

        }
        //Modelado
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relación uno a muchos; un Estudiante tiene muchas Matrículas 
            // Relación uno a muchos; un Personal tiene muchos sueldos a lo largo del tiempo de trabajo
            // 
            modelBuilder.Entity<Sueldos>()
                .HasOne(suel => suel.TiempoTrabajo)
                .WithMany(emp => emp.Salarios)
                .HasForeignKey(emp => emp.IdTiempo);

            modelBuilder.Entity<Roles>()
                .HasOne(emp => emp.Empleado)
                .WithMany()
                .HasForeignKey(rol => rol.EmpleadoId);
                


        }
    }
}
