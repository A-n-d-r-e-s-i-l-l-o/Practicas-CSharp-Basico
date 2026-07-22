public class Comida : IConPrecio
{
    public string nombre{get;set;}
    public decimal Precio{get;set;}
    public Comida(string nombre,decimal precio)
    {
        this.nombre = nombre;
        this.Precio = precio;
    }
    
}