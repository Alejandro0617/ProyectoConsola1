using ProyectoConsola.Data;
using ProyectoConsola.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoConsola.Services
{
    public class AppService
    {
        private readonly AppDbContext _context;

        public AppService(AppDbContext context)
        {
            _context = context;
        }

        // Métodos para Persona
        public void AddPersona(Persona persona)
        {
            _context.Personas.Add(persona);
            _context.SaveChanges();
            Console.WriteLine($"Persona añadida:  {persona.Email} {persona.Nombre} {persona.Telefono}");
        }

        public List<Persona> GetAllPersonas()
        {
            return _context.Personas.ToList();
        }

       public void UpdatePersona(Persona persona)
        {
            _context.SaveChanges();
            Console.WriteLine($"Persona actualizada:  {persona.Email} {persona.Nombre} {persona.Telefono}");
        }


        public void DeletePersona(Persona persona)
        {
            _context.Personas.Remove(persona);
            _context.SaveChanges();
            Console.WriteLine($"Persona eliminada:  {persona.Email} {persona.Nombre} {persona.Telefono}");
        }

        // Métodos para Empresa
        public void AddEmpresa(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
            Console.WriteLine($"Empresa añadida: {empresa.Nombre}");
        }

        public List<Empresa> GetAllEmpresas()
        {
            return _context.Empresas.ToList();
        }

        public void UpdateEmpresa(Empresa empresa)
        {
            _context.SaveChanges();
            Console.WriteLine($"Empresa actualizada: {empresa.Nombre}");
        }

        public void DeleteEmpresa(Empresa empresa)
        {
            _context.Empresas.Remove(empresa);
            _context.SaveChanges();
            Console.WriteLine($"Empresa eliminada: {empresa.Nombre}");
        }

        // Métodos para Cliente
        public void AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            Console.WriteLine($"Cliente añadido: {cliente.Nombre}");
        }

        public List<Cliente> GetAllClientes()
        {
            return _context.Clientes.ToList();
        }

        public void UpdateCliente(Cliente cliente)
        {
            _context.SaveChanges();
            Console.WriteLine($"Cliente actualizado: {cliente.Nombre}");
        }

        public void DeleteCliente(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            Console.WriteLine($"Cliente eliminado: {cliente.Nombre}");
        }

        // Métodos para Factura
        public void AddFactura(Factura factura)
        {
            _context.Facturas.Add(factura);
            _context.SaveChanges();
            Console.WriteLine($"Factura añadida: Número {factura.Numero}, Cliente {factura.Cliente.Nombre}");
        }

        public List<Factura> GetAllFacturas()
        {
            return _context.Facturas.ToList();
        }

        public void UpdateFactura(Factura factura)
        {
            _context.SaveChanges();
            Console.WriteLine($"Factura actualizada: Número {factura.Numero}");
        }

        public void DeleteFactura(Factura factura)
        {
            _context.Facturas.Remove(factura);
            _context.SaveChanges();
            Console.WriteLine($"Factura eliminada: Número {factura.Numero}");
        }

        // Métodos para Producto
        public void AddProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
            Console.WriteLine($"Producto añadido: {producto.Nombre}");
        }

        public List<Producto> GetAllProductos()
        {
            return _context.Productos.ToList();
        }

        public void UpdateProducto(Producto producto)
        {
            _context.SaveChanges();
            Console.WriteLine($"Producto actualizado: {producto.Nombre}");
        }

        public void DeleteProducto(Producto producto)
        {
            _context.Productos.Remove(producto);
            _context.SaveChanges();
            Console.WriteLine($"Producto eliminado: {producto.Nombre}");
        }

        // Métodos para ProductosPorFacturas
        public void AddProductosPorFacturas(ProductosPorFacturas productosPorFacturas)
        {
            _context.ProductosPorFacturas.Add(productosPorFacturas);
            _context.SaveChanges();
            Console.WriteLine($"Producto por factura añadido: {productosPorFacturas.Producto.Nombre} en factura {productosPorFacturas.Factura.Numero}");
        }

        public List<ProductosPorFacturas> GetAllProductosPorFacturas()
        {
            return _context.ProductosPorFacturas.ToList();
        }

        public void UpdateProductosPorFacturas(ProductosPorFacturas productosPorFacturas)
        {
            _context.SaveChanges();
            Console.WriteLine($"Producto por factura actualizado: {productosPorFacturas.Producto.Nombre} en factura {productosPorFacturas.Factura.Numero}");
        }

        public void DeleteProductosPorFacturas(ProductosPorFacturas productosPorFacturas)
        {
            _context.ProductosPorFacturas.Remove(productosPorFacturas);
            _context.SaveChanges();
            Console.WriteLine($"Producto por factura eliminado: {productosPorFacturas.Producto.Nombre} en factura {productosPorFacturas.Factura.Numero}");
        }

        // Métodos para Venta
        public void AddVenta(Venta venta)
        {
            _context.Ventas.Add(venta);
            _context.SaveChanges();
            Console.WriteLine($"Venta añadida: Monto {venta.Monto}, Fecha {venta.Fecha}");
        }

        public List<Venta> GetAllVentas()
        {
            return _context.Ventas.ToList();
        }

        public void UpdateVenta(Venta venta)
        {
            _context.SaveChanges();
            Console.WriteLine($"Venta actualizada: Monto {venta.Monto}, Fecha {venta.Fecha}");
        }

        public void DeleteVenta(Venta venta)
        {
            _context.Ventas.Remove(venta);
            _context.SaveChanges();
            Console.WriteLine($"Venta eliminada: Monto {venta.Monto}, Fecha {venta.Fecha}");
        }
    }
}

