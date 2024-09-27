using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace ProyectoConsola.Models
{
    public class Venta
    {
        [Key]
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }

        // Constructor
        public Venta(double monto, DateTime fecha)
        {
            Monto = monto;
            Fecha = fecha;
        }
    }
}
