namespace SistemaPeaje;
public class Ambulancia : VehiculoBase
{
    public Ambulancia(string placa) : base(placa)
    {
        
    }
    public override double CalcularPeaje()
    {
        return 0.00;
    }
}