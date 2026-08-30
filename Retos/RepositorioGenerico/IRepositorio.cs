namespace RepositorioGenerico;
public interface IRepositorioAsync<T> where T: class, IEntidad
{
    Task<List<T>> ObtenerTodosAsync();
    Task GuardarAsync(T entidad);
    Task<T?> ObtenerPorIdAsync(int id);
}