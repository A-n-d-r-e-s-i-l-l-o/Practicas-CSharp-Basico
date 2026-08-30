namespace RepositorioGenerico;
public class Producto:IEntidad
{
    public int Id{get;set;}
    public string? nombre{get;set;}
    public double precio{get;set;}
    public Producto(){}
}