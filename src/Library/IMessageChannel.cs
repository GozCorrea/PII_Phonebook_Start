namespace Library
{
    public interface IMessageChannel <T>
    {
         void Send(T message);
    }
}