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
        public DbSet<DecimoCuarto> DecimoCuartos { get; set; }
        public DbSet<DecimoTercero> DecimoTerceros { get; set; }
        public DbSet<FondoReserva> FondosReserva { get; set; }
        public DbSet<HorasExt> HorasExts { get; set; }
        public DbSet<RolPago> RolPagos { get; set; }
        public DbSet<Vacaciones> Vacaciones { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "server=DESKTOP-FAR92HR; initial catalog=DBUni; trusted_connection=true;"
                );
        }
    }
}
