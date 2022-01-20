using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class HorasExt
    {
        public int id { get; set; }
        public int EmpleadoId { get; set; }
        public float horas25 { get; set; }
        public float horas50 { get; set; }
        public float horas100 { get; set; }
        public float voras25 { get; set; }
        public float vhoras50 { get; set; }
        public float vhoras100 { get; set; }
        public ICollection<Empleado> lista { get; set; }
    }
}
