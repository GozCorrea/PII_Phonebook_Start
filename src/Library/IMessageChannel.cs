using System.Collections.Generic;

namespace Library
{
    public interface IMessageChannel
    {
        void Send(IMessage canal);
        void ArmarMensaje(string text, Contact from, Contact to);
    }
}