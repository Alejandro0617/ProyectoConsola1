using ProyectoConsola.Data;
using ProyectoConsola.Models;
using ProyectoConsola.Services;
using System;
using System.Linq;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
                
                var appService = new AppService(context);
                


                // Añadiendo Personas
                var persona1 = new Persona {  Email="roalejandro", Nombre="Alejandro", Telefono="gsdg"  };
                appService.AddPersona(persona1);

                var persona2 = new Persona {  Email="roalejandroafr", Nombre="Alejandro R", Telefono="3048577"  };
                appService.AddPersona(persona2);

                var persona3 = new Persona {  Email="roalejandro55", Nombre="Alejandro M", Telefono="30485755"  };
                appService.AddPersona(persona3);

                // Recuperar todas las Personas
                var personas = appService.GetAllPersonas();
                Console.WriteLine("Personas en la base de datos:");
                foreach (var p in personas)
                {
                    Console.WriteLine($"-  {p.Email} {p.Nombre} {p.Telefono}");
                }

                // Actualizar una Persona
                var personaToUpdate = personas.First();
                personaToUpdate.Email = "roalejandro";
                personaToUpdate.Nombre= "Alejandro";
                personaToUpdate.Telefono="304857";
                appService.UpdatePersona(personaToUpdate);

                // Eliminar una Persona
                var personaToDelete= personas.First();
                appService.DeletePersona(personaToDelete);

                // Recuperar Personas restantes
                personas = appService.GetAllPersonas();
                Console.WriteLine("Personas restantes en la base de datos:");
                foreach (var p in personas)
                {
                    Console.WriteLine($"-  {p.Email} {p.Nombre} {p.Telefono}");
                }

                


            }
        }
    }
}

