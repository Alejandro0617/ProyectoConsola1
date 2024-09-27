using System;
using System.ComponentModel.DataAnnotations; 

namespace ProyectoConsola.Models
{
  public class Persona
{
    [Key]
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    // Constructor con parámetros
    public Persona(int codigo, string nombre, string email, string telefono)
    {
        Codigo = codigo;
        Nombre = nombre;
        Email = email;
        Telefono = telefono;
    }

    // Constructor predeterminado
    public Persona() {}
}


}




