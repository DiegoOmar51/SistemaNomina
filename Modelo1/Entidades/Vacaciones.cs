using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Vacaciones
    {
        public int id { get; set; }
        public int EmpleadoId { get; set; }
        public float horasExt { get; set; }
        public float comisiones { get; set; }
        public ICollection<Empleado> lista { get; set; }
    }
}
