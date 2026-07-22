using System.Linq;
using Microsoft.VisualBasic;
public class Filtrador
{
    public static List<T> filtrar<T>(List<T> list, decimal maxPrecio) where T: IConPrecio
    {
        var ListaFiltrada = list.Where(n => n.Precio < maxPrecio).ToList();
        return ListaFiltrada;
    }
}