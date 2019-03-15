using System.Linq;
using System;
using ApexSharp;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            ApexClient c = new ApexClient();

            var search = await c.NormalSearch("psn", "Waayyzz");

            // Getting the stats from JSON Array
            var getStats = search.Results.FirstOrDefault();

            // With Normal Search you can get the following stats
            /*
                getStats.Aid;
                getStats.Avatar
                getStats.Kills
                getStats.Legend
                getStats.Level
                getStats.Name
                getStats.Platform            
            */

            // By using normal search we can do a ID search
            // ID Search does give us more stats we can view

            var idSearch = await c.IdSearch(getStats.Aid);

            // With ID Search you can a longer list of
            // Stats look into Models.cs to see what you can return

            Console.ReadLine();
        }
    }
}
