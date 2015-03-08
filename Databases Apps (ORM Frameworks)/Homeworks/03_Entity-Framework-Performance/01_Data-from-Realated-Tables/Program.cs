using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads;

namespace _01_Data_from_Realated_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Without includes
            var adsEntities = new AdsEntities();

            //foreach (var ad in adsEntities.Ads)
            //{
            //    Console.WriteLine("Title: " + ad.Title + ", Status: " + ad.AdStatus.Status +
            //                      ", Category: " + (ad.Category == null ? "(no category)" : ad.Category.Name) +
            //                      ", Town: " + (ad.Town == null ? "(no town)" : ad.Town.Name) +
            //                      ", User: " + ad.AspNetUser.Name);
            //}

            // With includes

            foreach (
                var ad in
                    adsEntities.Ads.Include(a => a.AdStatus)
                        .Include(a => a.Town)
                        .Include(a => a.Category)
                        .Include(a => a.AspNetUser))
            {
                Console.WriteLine("Title: " + ad.Title + ", Status: " + ad.AdStatus.Status +
                    ", Category: " + (ad.Category == null ? "(no category)" : ad.Category.Name) +
                    ", Town: " + (ad.Town == null ? "(no town)" : ad.Town.Name) +
                    ", User: " + ad.AspNetUser.Name);
            }

        }
    }
}
