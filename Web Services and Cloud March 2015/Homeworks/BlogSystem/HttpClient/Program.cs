using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient
{
    using System.Net;
    using System.Net.Http;

    class Program
    {
        static void Main()
        {
            GetAlbums();
        }

        async static void GetAlbums()
        {
            using (var client = new WebClient())
            {
                var data = client.DownloadString("http://localhost:11011/api/albums");

                Console.WriteLine(data);
            }
        }
    }
}
