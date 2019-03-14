using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ApexSharp
{
    public class AidModels
    {
        [JsonProperty("playerfound")]
        public bool Playerfound { get; set; }

        [JsonProperty("aid")]
        public string Aid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("skillratio")]
        public double Skillratio { get; set; }

        [JsonProperty("visits")]
         
        public long Visits { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("legend")]
        public string Legend { get; set; }

        [JsonProperty("level")]
         
        public long Level { get; set; }

        [JsonProperty("kills")]
         
        public long Kills { get; set; }

        [JsonProperty("headshots")]
         
        public long Headshots { get; set; }

        [JsonProperty("matches")]
         
        public long Matches { get; set; }

        [JsonProperty("damage")]
         
        public long Damage { get; set; }

        [JsonProperty("lastdata")]
        public object Lastdata { get; set; }

        [JsonProperty("kills_Bloodhound")]
         
        public long KillsBloodhound { get; set; }

        [JsonProperty("kills_Gibraltar")]
         
        public long KillsGibraltar { get; set; }

        [JsonProperty("kills_Lifeline")]
         
        public long KillsLifeline { get; set; }

        [JsonProperty("kills_Pathfinder")]
         
        public long KillsPathfinder { get; set; }

        [JsonProperty("kills_Wraith")]
         
        public long KillsWraith { get; set; }

        [JsonProperty("kills_Bangalore")]
         
        public long KillsBangalore { get; set; }

        [JsonProperty("kills_Caustic")]
         
        public long KillsCaustic { get; set; }

        [JsonProperty("kills_Mirage")]
         
        public long KillsMirage { get; set; }

        [JsonProperty("headshots_Bloodhound")]
         
        public long HeadshotsBloodhound { get; set; }

        [JsonProperty("headshots_Gibraltar")]
         
        public long HeadshotsGibraltar { get; set; }

        [JsonProperty("headshots_Lifeline")]
         
        public long HeadshotsLifeline { get; set; }

        [JsonProperty("headshots_Pathfinder")]
         
        public long HeadshotsPathfinder { get; set; }

        [JsonProperty("headshots_Wraith")]
         
        public long HeadshotsWraith { get; set; }

        [JsonProperty("headshots_Bangalore")]
         
        public long HeadshotsBangalore { get; set; }

        [JsonProperty("headshots_Caustic")]
         
        public long HeadshotsCaustic { get; set; }

        [JsonProperty("headshots_Mirage")]
         
        public long HeadshotsMirage { get; set; }

        [JsonProperty("matches_Bloodhound")]
         
        public long MatchesBloodhound { get; set; }

        [JsonProperty("matches_Gibraltar")]
         
        public long MatchesGibraltar { get; set; }

        [JsonProperty("matches_Lifeline")]
         
        public long MatchesLifeline { get; set; }

        [JsonProperty("matches_Pathfinder")]
         
        public long MatchesPathfinder { get; set; }

        [JsonProperty("matches_Wraith")]
         
        public long MatchesWraith { get; set; }

        [JsonProperty("matches_Bangalore")]
         
        public long MatchesBangalore { get; set; }

        [JsonProperty("matches_Caustic")]
         
        public long MatchesCaustic { get; set; }

        [JsonProperty("matches_Mirage")]
         
        public long MatchesMirage { get; set; }

        [JsonProperty("damage_Bloodhound")]
         
        public long DamageBloodhound { get; set; }

        [JsonProperty("damage_Gibraltar")]
         
        public long DamageGibraltar { get; set; }

        [JsonProperty("damage_Lifeline")]
         
        public long DamageLifeline { get; set; }

        [JsonProperty("damage_Pathfinder")]
         
        public long DamagePathfinder { get; set; }

        [JsonProperty("damage_Wraith")]
         
        public long DamageWraith { get; set; }

        [JsonProperty("damage_Bangalore")]
         
        public long DamageBangalore { get; set; }

        [JsonProperty("damage_Caustic")]
         
        public long DamageCaustic { get; set; }

        [JsonProperty("damage_Mirage")]
         
        public long DamageMirage { get; set; }

        [JsonProperty("globalrank")]
         
        public long Globalrank { get; set; }

        [JsonProperty("utime")]
         
        public long Utime { get; set; }

    }

    public class RootObjects
    {
        [JsonProperty("aid")]
        public string Aid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("legend")]
        public string Legend { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }
    }

    public class NormalModels
    {
        [JsonProperty("results")]
        public List<RootObjects> results { get; set; }
        
        [JsonProperty("totalresults")]
        public int totalresults { get; set; }
    }
}