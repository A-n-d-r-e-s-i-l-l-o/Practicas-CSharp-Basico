public class Videojuegos: IConPrecio
{
    public string? Titulo{get;set;}
    public decimal Precio{get;set;}
    public Videojuegos(string Titulo,decimal precio)
    {
        this.Precio = precio;
        this.Titulo = Titulo;
    }
}