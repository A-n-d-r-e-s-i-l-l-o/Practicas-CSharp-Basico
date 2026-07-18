namespace SistemaPeaje;
public class CabinaPeaje
{
    private List<IVehiculo> ListaVehiculos = new List<IVehiculo>(); 
    private double _totalRecaudado;
    public void ProcesarVehiculo(IVehiculo vehiculo)
    {
        _totalRecaudado += vehiculo.CalcularPeaje();
        ListaVehiculos.Add(vehiculo);
    }
    public double MostrarReporte()
    {
        return _totalRecaudado;
    }
    public List<IVehiculo> MostrarLista()
    {
        return ListaVehiculos;
    }
}