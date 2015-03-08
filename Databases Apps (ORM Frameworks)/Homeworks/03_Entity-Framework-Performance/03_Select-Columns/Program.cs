using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads;

namespace _03_Select_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var adsEntities = new AdsEntities();

            
            //var allAdsColumns = adsEntities.Ads;
            //foreach (var ad in allAdsColumns)
            //{
            //    Console.WriteLine("Title: " + ad.Title);
            //}

            var adTitles = adsEntities.Ads.Select(a => a.Title);
            foreach (var adTitle in adTitles)
            {
                Console.WriteLine("Title: " + adTitle);
            }
        }
    }
}
