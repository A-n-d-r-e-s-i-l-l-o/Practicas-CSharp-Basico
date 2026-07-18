namespace SistemaPeaje;
public abstract class VehiculoBase : IVehiculo
{
    public string Placa{get;}
    public VehiculoBase(string placa)
    {
        this.Placa = placa;
    }
    public abstract double CalcularPeaje();
    
}