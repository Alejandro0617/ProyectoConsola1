using System.Collections.Generic;

namespace ProyectoConsola.Models
{
  using System.ComponentModel.DataAnnotations;

public class Empresa
{
    [Key]
    public int Id { get; set; } // Clave primaria

    // Otras propiedades de la clase
    public string Nombre { get; set; }
}


 

}
