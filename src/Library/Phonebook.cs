using System.Collections.Generic;

namespace Library
{
    public class Phonebook //: IMessageChannel<T>
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public void AddContact(Contact contacto)
        {
            persons.Add(contacto);
        }

        public void RemoveContact(Contact contacto)
        {
            persons.Remove(contacto);
        }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
       public void Send(string[] nombres, string text, IMessageChannel canal)
        {
            List<Contact> lista = Search(nombres);
            foreach(Contact persona in lista)
            {
                canal.ArmarMensaje(text, this.Owner, persona);
            }
        }
    }
}