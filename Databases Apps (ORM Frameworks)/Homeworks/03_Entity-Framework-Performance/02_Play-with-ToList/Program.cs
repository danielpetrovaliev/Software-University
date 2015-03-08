using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads;

namespace _02_Play_with_ToList
{
    class Program
    {
        static void Main(string[] args)
        {
            var adsEntities = new AdsEntities();

            // Slow sql
            //var slowSQLQuery = adsEntities.Ads
            //    .ToList()
            //    .Where(a => a.AdStatus.Status == "Published")
            //    .OrderBy(a => a.Date)
            //    .Select(s =>
            //        new
            //        {
            //            Title = s.Title,
            //            Category = s.Category,
            //            Town = s.Town
            //        }
            //    ).ToList();

            //foreach (var ad in slowSQLQuery)
            //{
            //    Console.WriteLine("Title: " + ad.Title + 
            //        ", Category: " + (ad.Category == null ? "(no category)" : ad.Category.Name) +
            //        ", Town: " + (ad.Town == null ? "(no category)" : ad.Town.Name));
            //}

            // Optimized Query
            var optimizedQuery = adsEntities.Ads
                .Where(a => a.AdStatus.Status == "Published")
                .OrderBy(a => a.Date)
                .Select(s =>
                    new
                    {
                        Title = s.Title,
                        Category = s.Category,
                        Town = s.Town
                    }
                );

            foreach (var ad in optimizedQuery)
            {
                Console.WriteLine("Title: " + ad.Title +
                                  ", Category: " + (ad.Category == null ? "(no category)" : ad.Category.Name) +
                                  ", Town: " + (ad.Town == null ? "(no category)" : ad.Town.Name));
            }


        }
    }
}
