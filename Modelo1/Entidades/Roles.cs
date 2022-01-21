using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Roles
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }   // PENdiente, APRobada, ANUlada
        // Relación con el empleado
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
