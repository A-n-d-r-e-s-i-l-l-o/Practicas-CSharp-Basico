namespace SistemaPeaje;
public class Camion : VehiculoBase
{
    public int CantidadEjes{get;}
    public Camion(string placa,int cantidadEjes) : base(placa)
    {
        this.CantidadEjes = cantidadEjes;
    }
    public override double CalcularPeaje()
    {
        return 5.00 + (CantidadEjes*2.50);
    }
}