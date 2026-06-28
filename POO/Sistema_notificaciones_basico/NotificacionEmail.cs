using System;
namespace Sistema_noti;

public class NotificacionEmail:INotificacion
{
    public void EnviarMensaje(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje por Email: {mensaje}");
    }
}