using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class DecimoTercero
    {
        public int id { get; set; }
        public int EmpleadoId { get; set; }
        public String meses { get; set; }
        public float decimoTercer { get; set; }
        public ICollection<Empleado> lista { get; set; }
    }
}
