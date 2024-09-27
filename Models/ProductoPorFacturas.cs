using System;
using System.ComponentModel.DataAnnotations; 

namespace ProyectoConsola.Models
{
   public class ProductosPorFacturas
{
    [Key]
    public int Cantidad { get; set; }
    public decimal Subtotal { get; set; }
    public Producto Producto { get; set; } // Asociación
    public Factura Factura { get; set; } // Asociación

    // Constructor sin parámetros
    public ProductosPorFacturas() {}

    // Constructor opcional
    public ProductosPorFacturas(int cantidad, decimal subtotal, Producto producto, Factura factura)
    {
        Cantidad = cantidad;
        Subtotal = subtotal;
        Producto = producto;
        Factura = factura;
    }
}

}
