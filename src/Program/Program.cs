using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact nuevo = new Contact ("algo", "98052386");
            Phonebook nicolas = new Phonebook (nuevo);
            Contact roberto = new Contact ("Roberto", "98052386");
            nicolas.AddContact(roberto);
            string[] names = new string[]{"Roberto"};
            nicolas.Send(names , "Hola como estas?", new Whatsapp());

        }
    }
}