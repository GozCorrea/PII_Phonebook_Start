using System;
using TwitterUCU;

namespace Library
{
    public class Twitter : IMessageChannel
    {
        public IMessage ArmarMensaje( Contact from, Contact to, string text)
        {
            IMessage message = new Message(from.Name, to.Email, text);
            Send(message);
            return message;
        }
       public void Send(IMessage message)
       {
            string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
            string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
            string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
            string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
            var twitterDirectMessage = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitterDirectMessage.SendMessage(((IMessage) message).Text, ((IMessage) message).To));
       }
    }
}