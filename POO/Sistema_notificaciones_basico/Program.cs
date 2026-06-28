using System;
namespace Sistema_noti;

class Program
{
    static void Main()
    {
        INotificacion canal;
        canal = new NotificacionEmail();
        canal.EnviarMensaje("Estas ahi?");

        canal = new NotificacionWsp();
        canal.EnviarMensaje("Volvere a verte?");
    }
}