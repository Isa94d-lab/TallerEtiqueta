using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using ejercicio.data;

namespace ejercicio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Laptop HP", Categoria = "Electrónica", Precio = 3500, Stock = 10, ProveedorId = 1 },
                new Producto { Id = 2, Nombre = "Mouse Logitech", Categoria = "Electrónica", Precio = 150, Stock = 50, ProveedorId = 2 },
                new Producto { Id = 3, Nombre = "Silla de Oficina", Categoria = "Muebles", Precio = 800, Stock = 5, ProveedorId = 3 },
                new Producto { Id = 4, Nombre = "Cafetera Oster", Categoria = "Electrodomésticos", Precio = 600, Stock = 0, ProveedorId = 4 },
                new Producto { Id = 5, Nombre = "Escritorio Moderno", Categoria = "Muebles", Precio = 1200, Stock = 7, ProveedorId = 3 },
                new Producto { Id = 6, Nombre = "Monitor Samsung", Categoria = "Electrónica", Precio = 2500, Stock = 8, ProveedorId = 1 },
                new Producto { Id = 7, Nombre = "Teclado Mecánico", Categoria = "Electrónica", Precio = 400, Stock = 15, ProveedorId = 2 },
                new Producto { Id = 8, Nombre = "Aspiradora LG", Categoria = "Electrodomésticos", Precio = 1100, Stock = 2, ProveedorId = 4 }
            };

            List<Proveedor> proveedores = new List<Proveedor>
            {
                new Proveedor { Id = 1, Nombre = "TechSupply" },
                new Proveedor { Id = 2, Nombre = "Accesorios PC" },
                new Proveedor { Id = 3, Nombre = "Muebles XYZ" },
                new Proveedor { Id = 4, Nombre = "ElectroHome" }
            };


            Console.WriteLine("Nombres de los productos");

            var nombresProductos = productos.Select(p => p.Nombre);
            foreach (var nombre in nombresProductos)
                Console.WriteLine(nombre);


            
            Console.WriteLine("Productos ordenados por nombre: ");
            var productosOrdenados = productos.FirstOrDefault(p => p.Stock == 0);
            if (sinStock != null)
                Console.WriteLine($"{sinStock.Nombre}");


            Console.WriteLine("productos agrupados por categoria:")
            var agrupadosPorCategoria = productos.GroupBy(p => p.Categoria);
            foreach (var grupo in agrupadosPorCategoria)
            {
                Console.WriteLine($"Categoria: {grupo.Key}");
                foreach (var p in grupo)
                    Console.WriteLine($" - {p.Nombre}");
            }


            Console.WriteLine("Stock total disponible: ");
            var totalStock = productos.Sum(p => p.stock);
            Console.WriteLine(totalStock);


            Console.WriteLine("Todos los precios son validos?:");
            bool preciosValidos = productos.All(p => p.Precio > 0);
            Console.WriteLine(preciosValidos);


            Console.WriteLine("Productos con su proveedor")
            var consulta = from producto in productos
                    join proveedor in proveedores
                        on producto.ProveedorId equals proveedor.Id
                        select new
                        {
                            NombreProveedor = proveedor.Nombre,
                            NombreProducto = producto.Nombre,
                            Categoria = producto.Categoria,
                            Precio = producto.Precio,
                            Stock = producto.Stock
                        };

            foreach (var item in consulta)
            {
                Console.WriteLine($"- {item.NombreProducto} | Categoría: {item.Categoria} | Precio: ${item.Precio} | Stock: {item.Stock} | Proveedor: {item.NombreProveedor}");
            }



            var productosConEtiquetas = new List<(string Producto, List<string> Etiquetas)> {
                (   "Laptop HP"
                    "Mouse Logitech",
                    "Silla de Oficina", 
                    "Cafetera Oster", 
                    "Escritorio Moderno", 
                    "Monitor Samsung", 
                    "Teclado Mecánico", 
                    "Aspiradora LG"
)
            }












        }
    }
}
