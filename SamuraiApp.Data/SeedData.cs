using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Data
{
    public class SeedData
    {
        public static List<Samurai> SeedSamurai()
        {
            var towns = new List<String>
            {
                "Takoyaki",
                "DonBuri",
                "Sushi Town",
                "Nagasaki",
                "Shijuku"
            };

            var samurais = new List<Samurai>();

            for (int i = 1; i <= 10000; i++)
            {
                var random = new Random();
                int pickTown = random.Next(0, 5);
                var samurai = new Samurai
                {
                    SamuraiId = i,
                    Picture = "https://static.wikia.nocookie.net/l5r/images/0/0e/Samurai.jpg",
                    Name = "Samurai_" + i,
                    Age = random.Next(0, 50),
                    Town = towns[pickTown]
                };
                samurais.Add(samurai);
            }

            return samurais;
          
        }

        public static List<Battle> SeedBattle()
        {
            var city = new List<String>
            {
                "Hiroshima",
                "Wakayama",
                "Nagoya",
                "Nagasaki",
                "Shijuku"
            };

            var battles = new List<Battle>();
            DateTime startDate = new DateTime(1970, 2, 8);
            int range = (DateTime.Today - startDate).Days;
            var random = new Random();
            var pickCity = 0;
            Battle battle;

            for (int i = 1; i <= 100; i++)
            {
                pickCity = random.Next(0, 5);
                battle = new Battle
                {
                    BattleId = i,
                    Date = startDate.AddDays(random.Next(range)),
                    Name = "Round_" + i,
                    City = city[pickCity],
                    Country = "Japan"
                };
                battles.Add(battle);
            }

            return battles;

        }

        public static List<BattleSamurai> SeedBattleSamurai()
        {
            //List<int> randomList = new List<int>();
            var random = new Random();
            var battleSamurais = new List<BattleSamurai>();
            BattleSamurai bs;
            int count = 1;

            for (int x = 1; x <= 100; x++)
            {
                for(int samuraiCount = 1; samuraiCount <= random.Next(200, 500); samuraiCount++)
                {
                    bs = new BattleSamurai
                    {
                        BattleSamuraiId = count,
                        BattleId = x,
                        SamuraiId = random.Next(1, 10000)
                    };
                    battleSamurais.Add(bs);
                    count++;
                }
            }

            return battleSamurais;

        }
    }
}
