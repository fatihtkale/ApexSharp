# About this api wrapper
This wrapper is using the [ApexTab](apextab.com)
There are no limitations to this API as long as it is not abused. Apextab hold the right to refuse service to anyone who we believe is abusing their system.

# How to use?
Simple search:
```cs
ApexClient Client = new ApexClient();
var Search = await Client.NormalSearch("psn", "Waayyzz");
```

Advanced search:
```cs

ApexClient Client = new ApexClient();
var Search = await Client.NormalSearch("psn", "Waayyzz");

var User = Search.results.FirstOrDefault();

var AidSearch = await Client.IdSearch(User.Aid);

Console.WriteLine(AidSearch.SkillRatio);
```
for a better understanding of how to use the wrapper check out test folder in the repo

# Install
this project can be installed by using the nuget package
 - [Link to nuget package](https://www.nuget.org/packages/ApexSharp/1.0.0)
 
or

 - Clone the project.
 - Drag out Client.cs & Models.cs
 - Make sure you have [NewtonSoft.Json](https://www.newtonsoft.com/json)
 - And refrence ApexSharp & you're all set!

# API Documentation
### Results from a Simple Search, by using the Username and the Platform
```json
{  
   "results":[
      {  
         "aid":"f5337d769b7b29628f59d8c84ea45d9d",
         "name":"BallerInGame",
         "platform":"pc",
         "avatar":"https://apextab.com/cache/fc4c4cba183c2f81a94730be057cf07d.png",
         "legend":"Lifeline",
         "level":"28",
         "kills":"112"
      }
   ],
   "totalresults":1
}
```
### Results from a Advanced Search, By using Aid 
```json
{
  "playerfound": true,
  "aid": "f5337d769b7b29628f59d8c84ea45d9d",
  "name": "BallerInGame",
  "platform": "PC",
  "skillratio": 4,
  "visits": "1522",
  "avatar": "https://apextab.com/cache/fc4c4cba183c2f81a94730be057cf07d.png",
  "legend": "Lifeline",
  "level": "28",
  "kills": "112",
  "headshots": "178",
  "matches": "113",
  "kills_Bloodhound": "18",
  "kills_Gibraltar": "10",
  "kills_Lifeline": "9",
  "kills_Pathfinder": "4",
  "kills_Wraith": "2",
  "kills_Bangalore": "62",
  "kills_Caustic": "3",
  "kills_Mirage": "4",
  "headshots_Bloodhound": "38",
  "headshots_Gibraltar": "11",
  "headshots_Lifeline": "23",
  "headshots_Pathfinder": "31",
  "headshots_Wraith": "4",
  "headshots_Bangalore": "61",
  "headshots_Caustic": "4",
  "headshots_Mirage": "6",
  "matches_Bloodhound": "11",
  "matches_Gibraltar": "13",
  "matches_Lifeline": "10",
  "matches_Pathfinder": "15",
  "matches_Wraith": "11",
  "matches_Bangalore": "40",
  "matches_Caustic": "7",
  "matches_Mirage": "6",
  "globalrank": "24192",
  "utime": "1550669669"
}
```

# For support Join my discord!
[Discord](https://discord.gg/zZzC4za)
