using Microsoft.EntityFrameworkCore;
using ProyectoConsola.Models;

namespace ProyectoConsola.Data
{
    public class AppDbContext : DbContext
    {
        
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductosPorFacturas> ProductosPorFacturas { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProyectoConsolaDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().ToTable("persona");
            modelBuilder.Entity<Empresa>().ToTable("empresa");
            modelBuilder.Entity<Cliente>().ToTable("cliente");
            modelBuilder.Entity<Factura>().ToTable("factura");
            modelBuilder.Entity<Producto>().ToTable("producto");
            modelBuilder.Entity<ProductosPorFacturas>().ToTable("productosPorFacturas");
            modelBuilder.Entity<Venta>().ToTable("venta");

            // Aquí puedes agregar más configuraciones específicas si las necesitas.
        }
    }
}
