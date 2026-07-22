public interface IBaseDatos<T>
{
    void Guardar(T item);
    List<T> ObtenerTodos();
}