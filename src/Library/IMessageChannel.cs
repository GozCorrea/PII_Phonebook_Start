using System.Collections.Generic;

namespace Library
{
    public interface IMessageChannel<T>
    {
        void Send(T canal);
    }
}