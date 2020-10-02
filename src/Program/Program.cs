using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact nuevo = new Contact ("algo", "98578659");
            Phonebook guz = new Phonebook (nuevo);
            Contact jona = new Contact ("Jona", "98578659");
            guz.AddContact(jona);
            string[] names = new string[]{"Jona"};
            guz.Send(names , new Whatsapp(), "Hola como estas?");

            
            // Crear el contacto dueño



            // Crear la lista de contactos

            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
