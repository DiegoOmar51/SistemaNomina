using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class RolPago
    {
        public int id { get; set; }
        public DecimoTercero DecimoTercero { get; set; }
        public DecimoCuarto DecimoCuarto { get; set; }
        public HorasExt HorasExtras { get; set; }
        public FondoReserva FondoReserva { get; set; }
        public Vacaciones Vacaciones { get; set; }
        public float ARecibir { get; set; }
        public ICollection<Empleado> lista { get; set; }

    }
}
