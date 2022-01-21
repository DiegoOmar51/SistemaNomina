using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class FondoReserva
    {
        public int id { get; set; }
        public List<Empleado> Empleados { get; set; }
        public float Porcentaje { get; set; }
        public float valor { get; set; }
        
    }
}
