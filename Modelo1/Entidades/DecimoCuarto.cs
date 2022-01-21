﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class DecimoCuarto
    {
        public int Id { get; set; }
        //Relacion de uno a muchos con empleado
        public int EmpleadoId { get; set; }
        public Empleado   Empleado { get; set; }
        public string Meses { get; set; }
        public double Total { get; set; }
    }
}
