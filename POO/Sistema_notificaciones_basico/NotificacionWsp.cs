using System;
namespace Sistema_noti;

public class NotificacionWsp:INotificacion
{
    public void EnviarMensaje(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje por WhatsApp: {mensaje}");
    }
}