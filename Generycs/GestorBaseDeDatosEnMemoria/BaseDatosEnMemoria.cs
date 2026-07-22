public class BaseDatosEnMemoria<T> : IBaseDatos<T>
{
    private List<T> Lista= new List<T>();
    public void Guardar(T item)
    {
        Lista.Add(item);
    }
    public List<T> ObtenerTodos()
    {
        return Lista;
    }
}