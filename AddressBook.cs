using System;
using System.Collections.Generic;

namespace addressbook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts { get; set; }
        public void AddContact(Contact aide)
        {
            try
            {
                Contacts.Add(aide.Email, aide);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Contact GetByEmail(string email)
        {
            return Contacts[email];
        }

        public AddressBook()
        {
            Contacts = new Dictionary<string, Contact>();
        }


    }
}