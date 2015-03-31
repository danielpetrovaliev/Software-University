namespace PhoneBook.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    internal class ListAllContacts
    {
        private static void Main(string[] args)
        {
            var context = new PhonebookEntities();

            foreach (var contact in context.Contacts
                .Include(c => c.Emails)
                .Include(c => c.Phones))
            {
                Console.WriteLine("Name: " + contact.Name);

                if (contact.Position != null)
                {
                    Console.WriteLine(" Position: " + contact.Position);
                }
                if (contact.Company != null)
                {
                    Console.WriteLine(" Company: " + contact.Company);
                }
                if (contact.Emails.Count > 0)
                {
                    Console.WriteLine(" Emails: " + string.Join(", ", contact.Emails.Select(e => e.EmailAdress)));
                }
                if (contact.Phones.Count > 0)
                {
                    Console.WriteLine(" Phones: " + string.Join(", ", contact.Phones.Select(p => p.Number)));
                }
                if (contact.Url != null)
                {
                    Console.WriteLine(" Url: " + contact.Url);
                }
                if (contact.Notes != null)
                {
                    Console.WriteLine(" Notes: " + contact.Notes);
                }
            }
        }
    }
}
