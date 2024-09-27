using System;
using System.ComponentModel.DataAnnotations; 

namespace ProyectoConsola.Models
{
   public class Factura
{
    [Key]
    public int Numero { get; set; }
    public DateTime Fecha { get; set; }
    public decimal total { get; set; }
    public Cliente Cliente { get; set; } // Asegúrate de que esto sea una propiedad

    // Constructor sin parámetros
    public Factura() {}

    // Constructor con parámetros
    public Factura(DateTime fecha, int numero, decimal total, Cliente cliente)
    {
        
        Fecha = fecha;
        Numero = numero;
        total=total;
        Cliente = cliente;
    }
}


    
}
