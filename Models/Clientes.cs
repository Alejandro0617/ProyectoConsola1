namespace ProyectoConsola.Models
{
    public class Cliente : Persona
    {
        public double Credito { get; set; } // Propiedad pública

        // Constructor
        public Cliente(int codigo, string email, string nombre, string telefono, double credito)
            : base(codigo, email, nombre, telefono)
        {
            Credito = credito; // Asignación de valor
        }
    }
}