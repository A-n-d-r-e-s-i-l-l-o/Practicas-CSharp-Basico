namespace practicaSerializacion;
public class Configuracion
{
    public string? Idioma{get;set;}
    public int Volumen{get;set;}
    public bool ModoOscuro{get;set;}
    public Configuracion(){}
    public Configuracion(string Idioma,int volumen,bool modooscuro)
    {
        this.Idioma = Idioma;
        this.Volumen = volumen;
        this.ModoOscuro = modooscuro;
    }
}