using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class HorasExt
    {
        public int Id { get; set; }
        //Relacion de uno a muchos
        public Empleado Empleado { get; set; }
     
        public double h25  { get; set; }
        public double h50 { get; set; }
        public double h100 { get; set; }

        public double vh25 { get; set; }
        public double vh50 { get; set; }
        public double vh100 { get; set; }

        public double Total { get; set; }
    }
}
