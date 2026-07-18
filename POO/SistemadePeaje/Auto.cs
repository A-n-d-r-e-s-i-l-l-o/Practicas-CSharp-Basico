namespace SistemaPeaje;
public class Auto : VehiculoBase
{
    public Auto(string placa) :base(placa)
    {
    }
    public override double CalcularPeaje()
    {
        return 5.0;
    }
}