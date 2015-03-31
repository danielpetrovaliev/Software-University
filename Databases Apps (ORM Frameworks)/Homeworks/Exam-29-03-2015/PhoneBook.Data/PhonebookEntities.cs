using System.Data.Entity;
using Phonebook.Models;
using PhoneBook.Data.Migrations;

namespace PhoneBook.Data
{
    public class PhonebookEntities : DbContext
    {
        public PhonebookEntities()
                : base("Phonebook")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PhonebookEntities, Configuration>());
        }

        public virtual IDbSet<Contact> Contacts { get; set; }

        public virtual IDbSet<Phone> Phones { get; set; }

        public virtual IDbSet<Email> Emails { get; set; }

    }
}