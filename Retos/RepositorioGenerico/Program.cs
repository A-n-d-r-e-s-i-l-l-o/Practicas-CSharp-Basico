namespace RepositorioGenerico;
class Program
{
    static async Task Main()
    {
        RepositorioJsonAsync<Producto> repositorioJsonAsyncProductos = new RepositorioJsonAsync<Producto>("Producto.json");
        RepositorioJsonAsync<Usuarios> repositorioJsonAsyncUsuarios = new RepositorioJsonAsync<Usuarios>("Usuarios.json");
        await repositorioJsonAsyncUsuarios.GuardarAsync(new Usuarios{Id = 2, nombre = "jose", Edad = 34, email = "asddsa@gmail.com"});
        await repositorioJsonAsyncProductos.GuardarAsync(new Producto{nombre = "Mouse", precio = 32});
        Producto? producto = await repositorioJsonAsyncProductos.ObtenerPorIdAsync(1);
        Console.WriteLine($"Producto {producto?.nombre} encontrado");
    }
}