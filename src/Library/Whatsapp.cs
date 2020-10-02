using System;
using WhatsAppApiUCU;

namespace Library
{
    public class Whatsapp : IMessageChannel
    {
        const string accountSid = "AC52493b284c82ba2c6b196ef82e412576";
        const string authToken = "fe35a2702d8c2e83fbea2628d4cace09";
        WhatsAppApi whatsAppApi;

        public Whatsapp()
        {
            this.whatsAppApi = new WhatsAppApi(accountSid, authToken);
        }

        public void Send(IMessage message)
        {
            string sid = whatsAppApi.Send($"+598{message.To}", message.Text);
            Console.WriteLine(sid);
        }

        public IMessage CreateMessage(Contact from, Contact to, string text)
        {
            IMessage message = new WhatsAppMessage (from.Phone, to.Phone, text);
            return message;
        }

    }
}



