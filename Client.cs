using System.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApexSharp
{
    class ApexClient
    {
        HttpClient client;

        ///<summary>
        ///<para>Search A user up with their username and platform</para>
        ///</summary>
        public async Task<NormalModels> NormalSearch(string platform, string name)
        {
            client = new HttpClient();
            var url = await client.GetStringAsync($"https://apextab.com/api/search.php?platform={platform.ToLower()}&search={name}");
            NormalModels normaldata = JsonConvert.DeserializeObject<NormalModels>(url);

            return normaldata;
        }

        ///<summary>
        ///<para>Search A user up with their Aid</para>
        ///</summary>
        public async Task<AidModels> IdSearch(string aid)
        {   
            client = new HttpClient();
            var url = await client.GetStringAsync($"https://apextab.com/api/player.php?aid={aid}");
            AidModels aiddata = JsonConvert.DeserializeObject<AidModels>(url);

            return aiddata;
        }
    
    }
}
