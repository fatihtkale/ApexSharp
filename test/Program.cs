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
            // Normal Search
            ApexClient Client = new ApexClient();
            var Search = await Client.NormalSearch("psn", "Waayyzz");
            
            // FirstOrDefault used to get the objects inside of our JSON Array
            var User = Search.results.FirstOrDefault();

            // User.Kills

            // Using the AID to get more accurate stats on the user
            var AidSearch = await Client.IdSearch(User.Aid);

            // AidSearch.Skillratio; And what ever else you wanna use.

            Console.ReadLine();
        }
    }
}
