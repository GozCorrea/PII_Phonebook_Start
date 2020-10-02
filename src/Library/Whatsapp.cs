  
using System;
using WhatsAppApiUCU;

namespace Library
{
    public class Whatsapp : IMessageChannel
    {
        const string accountSid = "AC52493b284c82ba2c6b196ef82e412576";
        const string authToken = "TOKEN";
        WhatsAppApi whatsAppApi;

        public IMessage ArmarMensaje(Contact from, Contact to, string text)
        {
            IMessage message = new Message (from.Phone, to.Phone, text);
            return message;
        }
        public void Send(IMessage message)
        {
            this.whatsAppApi = new WhatsAppApi(accountSid, authToken);
            string sid = whatsAppApi.Send($"+598{message.To}", message.Text);
            Console.WriteLine(sid);
        }

    }
}

