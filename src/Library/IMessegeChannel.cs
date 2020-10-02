using System.Collections.Generic;

namespace Library
{
    public interface IMessageChannel
    {
        void Send(IMessage message);
        IMessage ArmarMensaje( Contact from, Contact to, string text);
    }
}