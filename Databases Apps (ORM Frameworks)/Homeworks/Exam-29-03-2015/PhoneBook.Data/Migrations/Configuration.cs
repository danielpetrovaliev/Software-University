namespace PhoneBook.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    using Phonebook.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneBook.Data.PhonebookEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PhonebookEntities context)
        {
            if (!context.Contacts.Any())
            {
                AddSomeContacts(context);
            }
        }

        private void AddSomeContacts(PhonebookEntities context)
        {
            var peterContact = new Contact
            {
                Name = "Peter Ivanov",
                Position = "CTO",
                Company = "Smart Ideas",
                Url = "http://blog.peter.com",
                Notes = "Friend from school"
            };

            peterContact.Phones.Add(new Phone{Number = "+359 2 22 22 22"});
            peterContact.Phones.Add(new Phone{Number = "+359 88 77 88 99"});
            peterContact.Emails.Add(new Email{EmailAdress = "peter_ivanov@yahoo.com"});
            peterContact.Emails.Add(new Email{EmailAdress = "peter@gmail.com"});


            var mariaContact = new Contact
            {
                Name = "Maria",
                Phones = new HashSet<Phone>
                {
                    new Phone{Number = "+359 22 33 44 55"}
                }
            };

            var angieContact = new Contact
            {
                Name = "Angie Stanton",
                Url = "http://angiestanton.com",
                Emails = new HashSet<Email>
                {
                    new Email{EmailAdress = "info@angiestanton.com"}
                }
            };

            context.Contacts.Add(peterContact);
            context.Contacts.Add(mariaContact);
            context.Contacts.Add(angieContact);
            context.SaveChanges();
        }
    }
}
