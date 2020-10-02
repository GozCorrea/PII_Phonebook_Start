using System;
using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public void AddContact (Contact contact)
        {
            persons.Add (contact);
        }
        public Contact Owner { get; }

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

        public void Send(string[] names, IMessageChannel channel, string text){
            List<Contact> contacts = this.Search(names);
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.Phone);
                IMessage m = channel.CreateMessage(this.Owner, contact, text);
                channel.Send(m);
            }
        }
    }
}