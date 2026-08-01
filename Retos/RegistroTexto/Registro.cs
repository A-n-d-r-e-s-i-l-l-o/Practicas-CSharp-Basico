using System.IO;
public class Registro
{
    public string ruta{get;set;}
    public Registro(string ruta)
    {
        this.ruta = ruta;
    }
    public void GuardarRegistro(string? mensaje)
    {
        string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string linea = $"{fecha} {mensaje}{Environment.NewLine} ";
        File.AppendAllText(ruta,linea);
    }
}