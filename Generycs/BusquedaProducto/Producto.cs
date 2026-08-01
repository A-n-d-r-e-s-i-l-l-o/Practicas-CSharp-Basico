public class Producto
{
    public int ID{get;set;}
    public string Nombre{get;set;}
    public int Stock{get;set;}
    public Producto(int Id,string Nombre,int Stock)
    {
        this.ID = Id;
        this.Nombre = Nombre;
        this.Stock = Stock;
    }
}