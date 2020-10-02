namespace Library
{
    public class Message : IMessage
    {
        public Message(string from, string to, string text)
        {
            this.From = from;
            this.To = to;
            this.Text = text;
        }

        public string From { get; }
        public string To { get; }
        public string Text { get; set; }
    }
}