using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Sueldos
    {
        public int Id { get; set; }
        public string Estado { get; set; }   // PENdiente, APRobada, ANUlada


        public float SueldoBasico { get; set; }
        public float DecimoTercerSueldo { get; set; }
        public float DecimoCuartoSueldo { get; set; }
        public float Utilidades { get; set; }
        

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public TrabajoEmpleado TiempoTrabajo { get; set; }
        public int IdTiempo { get; set; }

    }
}
