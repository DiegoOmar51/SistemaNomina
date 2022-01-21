using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class DecimoTercero
    {
        public int Id { get; set; }
        //Relacion de uno a muchos
        public Empleado Empleado { get; set; }
        public string NombreEmpleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Meses { get; set; }
        public double Total { get; set; }
    }
}
