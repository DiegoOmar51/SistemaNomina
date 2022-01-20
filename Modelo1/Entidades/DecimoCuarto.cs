using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class DecimoCuarto
    {
        public int id { get; set; }
        public int EmpleadoId { get; set; }
        public int diaslaborables { get; set; }
        public float decimocuarto { get; set; }
        public ICollection<Empleado> lista { get; set; }
    }
}
