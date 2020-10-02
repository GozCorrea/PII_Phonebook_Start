using System;

namespace Library
{
    public class Message : IMessage
    {
        public void Message(string from, string to, string text)
        {
            this.From = from;
            this.To = to;
            this.Text = text;
        }

        string From {get;}
        string To {get;}
        string Text {get; set;}
    }
}