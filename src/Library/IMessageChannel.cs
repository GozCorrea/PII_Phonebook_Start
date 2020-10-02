using System;

namespace Library
{
    public interface IMessageChannel
    {
        void Send(IMessage message);
        IMessage CreateMessage(Contact from, Contact to, string text);
    }
}