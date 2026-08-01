public class Gasto
{
    public string categorias{get; set;}
    public double Monto{get;set;}
    public Gasto(string categoria,double monto)
    {
        this.categorias = categoria;
        this.Monto = monto;
    }
}