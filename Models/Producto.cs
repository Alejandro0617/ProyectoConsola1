using System;
using System.ComponentModel.DataAnnotations; 

namespace ProyectoConsola.Models
{
    public class Producto
    {
        [Key]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public double ValorUnitario { get; set; }

        // Constructor
        public Producto(string codigo, string nombre, int stock, double valorUnitario)
        {
            Codigo = codigo;
            Nombre = nombre;
            Stock = stock;
            ValorUnitario = valorUnitario;
        }
    }
}
