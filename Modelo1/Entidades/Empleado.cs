using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Empleado
    {
        public int empleadoid { get; set; }
        public String NombreEmp { get; set; }
        public float Sueldo { get; set; }
        public int Telefono { get; set; }
        public String EstadoCivil { get; set; }
        public String Estado { get; set; }
        public List<DecimoCuarto> Cuartos { get; set; }
        public int CuartosId { get; set; }
    }
}
