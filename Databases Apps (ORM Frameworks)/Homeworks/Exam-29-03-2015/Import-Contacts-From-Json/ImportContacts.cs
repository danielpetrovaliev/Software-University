namespace Import_Contacts_From_Json
{
    using System;
    using System.IO;
    using Newtonsoft.Json.Linq;
    using Phonebook.Models;
    using PhoneBook.Data;

    class ImportContacts
    {
        static void Main(string[] args)
        {
            string jsonAsString = File.ReadAllText(@"../../../Files-for-Import/contacts.json");

            var contacts = JArray.Parse(jsonAsString);

            foreach (var contact in contacts)
            {
                try
                {
                    ImportContact(contact);
                    Console.WriteLine("Contact {0} imported.", contact["name"]);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }

        private static void ImportContact(JToken contact)
        {
            using (var context = new PhonebookEntities())
            {
                var newContact = new Contact();

                if (contact["name"] == null)
                {
                    throw new ArgumentException("Name is required.");
                }

                newContact.Name = contact["name"].Value<string>();

                if (contact["site"] != null)
                {
                    newContact.Url = contact["site"].Value<string>();
                }
                if (contact["position"] != null)
                {
                    newContact.Position = contact["position"].Value<string>();
                }
                if (contact["company"] != null)
                {
                    newContact.Company = contact["company"].Value<string>();
                }
                if (contact["notes"] != null)
                {
                    newContact.Notes = contact["notes"].Value<string>();
                }

                if (contact["emails"] != null)
                {
                    var emails = contact["emails"];

                    foreach (var email in emails)
                    {
                        var newEmail = new Email
                        {
                            EmailAdress = email.Value<string>()
                        };

                        newContact.Emails.Add(newEmail);
                    }
                }

                if (contact["phones"] != null)
                {
                    var phones = contact["phones"];

                    foreach (var phone in phones)
                    {
                        var newPhone = new Phone
                        {
                            Number = phone.Value<string>()
                        };

                        newContact.Phones.Add(newPhone);
                    }
                }

                context.Contacts.Add(newContact);
                context.SaveChanges();
            }
        }
    }
}
