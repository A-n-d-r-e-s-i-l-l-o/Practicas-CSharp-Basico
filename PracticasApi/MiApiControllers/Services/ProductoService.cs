using MiApiController.Models;

namespace MiApiController.Services;

public class ProductoService : IProductoService
{
    private static List<Producto> Productos = new List<Producto>
    {
        new Producto { id = 1, nombre = "Laptop", precio = 850.50 },
        new Producto { id = 2, nombre = "Mouse Gamer", precio = 25.00 }
    };

    public List<Producto> ObtenerTodos() => Productos;

    public Producto? ObtenerPorId(int id) => Productos.FirstOrDefault(p => p.id == id);

    public Producto Crear(Producto producto)
    {
        producto.id = Productos.Count > 0 ? Productos.Max(p => p.id) + 1 : 1;
        Productos.Add(producto);
        return producto;
    }

    public bool Actualizar(int id, Producto productoActualizado)
    {
        var productoExistente = ObtenerPorId(id);
        if (productoExistente == null) return false;

        productoExistente.nombre = productoActualizado.nombre;
        productoExistente.precio = productoActualizado.precio;
        return true;
    }

    public bool Eliminar(int id)
    {
        var producto = ObtenerPorId(id);
        if (producto == null) return false;

        Productos.Remove(producto);
        return true;
    }
}