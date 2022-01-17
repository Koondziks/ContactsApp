using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if(contact == null)
                Console.WriteLine("Contacts not found");
            else
            {
                DisplayContactsDetails(contact);
            }
        }

        public void DisplayAllContacts()
        {
            FunctionForeach(Contacts);
        }

        private void DisplayContactsDetails(Contact contact )
        {
            Console.WriteLine($"Contact: { contact.Name}, {contact.Number}");
        }

        private void FunctionForeach(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactsDetails(contact);
            }
        }


        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            FunctionForeach(matchingContacts);
        }
    }
}
