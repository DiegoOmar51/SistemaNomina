using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class TrabajoEmpleado
    {
        public int Id { get; set; }
        public DateTime FechaInicioTrabajo { get; set; }
        public DateTime FechaFinTrabajo { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public int CargoId { get; set; }
        
        public List<Sueldos> Salarios { get; set; }
    
    }
}
