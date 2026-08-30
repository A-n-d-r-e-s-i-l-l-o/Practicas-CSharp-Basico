namespace RepositorioGenerico;
public class Usuarios:IEntidad
{
    public int Id{get;set;}
    public string? nombre{get;set;}
    public int Edad{get;set;}
    public string? email{get;set;}
    public Usuarios(){}
}