using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Data;
using News.Data.Migrations;

namespace _02_Concurrent_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsDbContext, Configuration>());

            var firstNewsContext = new NewsDbContext();
            var secondNewsContext = new NewsDbContext();

            var allNewsFirst = firstNewsContext.News.ToList();
            var allNewsSecond = secondNewsContext.News.ToList();

            // Print all news content
            foreach (var news in allNewsFirst)
            {
                Console.WriteLine(news.Content);
            }

            Console.WriteLine();
            Console.WriteLine("Application Started !!!");
            Console.WriteLine();

            // Change news Content from first context instance
            foreach (var news in allNewsFirst)
            {
                Console.WriteLine("First User.");
                Console.WriteLine("Text from DB: " + news.Content);
                Console.WriteLine("Enter the correct text.   [Press 'Enter' to save]");

                string newNewsContent = Console.ReadLine();
                news.Content = newNewsContent;
                
                firstNewsContext.SaveChanges();

                Console.WriteLine("Changes successfully saved in the DB.");
                Console.WriteLine();
            }

            // Change news Content from second context instance
            foreach (var news in allNewsSecond)
            {
                Console.WriteLine("Second User.");
                Console.WriteLine("Text from DB: " + news.Content);
                Console.WriteLine("Enter the correct text.   [Press 'Enter' to save]");

                string newNewsContent = Console.ReadLine();
                news.Content = newNewsContent;

                try
                {
                    secondNewsContext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("Conflict!!!");
                    Console.WriteLine("==========================");

                    var thirdNewsContext = new NewsDbContext();

                    var newsWithNewValue = thirdNewsContext.News.Find(news.Id);

                    Console.WriteLine("Text from DB: " + newsWithNewValue.Content);
                    Console.WriteLine("Enter the correct text.   [Press 'Enter' to save]");

                    newNewsContent = Console.ReadLine();
                    news.Content = newNewsContent;

                    thirdNewsContext.SaveChanges();
                }

                Console.WriteLine("Changes successfully saved in the DB.");
                Console.WriteLine();
            }
        }
    }
}
