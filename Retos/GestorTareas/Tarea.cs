namespace GestorTareas;
public class Tarea
{
    public int ID{get;set;}
    public string? Titulo{get;set;}
    public bool Completado{get;set;}
    public Tarea(){}
    public Tarea(int ID,string Titulo, bool Completado)
    {
        this.ID = ID;
        this.Titulo = Titulo;
        this.Completado = Completado;
    }
}