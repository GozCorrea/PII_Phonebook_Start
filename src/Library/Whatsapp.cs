using System;
using WhatsAppApiUCU;

namespace Library
{
    public class WhatsApp : IMessageChannel
    {
        public void ArmarMensaje(string text, Contact from, Contact to)
        {
            Message mensaje = new Message(from.Name, to.Phone, text);
            Send(mensaje);
        }
        public void Send()
        {
            const string accountSid = "AC52493b284c82ba2c6b196ef82e412576";
            const string authToken = "<ingresar token solo a nivel local, no subir al repo>";

            var whatsApp = new WhatsAppApi(accountSid, authToken);
            string sid = whatsApp.Send("+598<Poné tu teléfono acá>", "Hey there! I'm using WhatsAppUCU");
            Console.WriteLine(sid);
        }
    }
}