using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Rank
    {
        List<Team> Ranks;
        public void GetRank(List<List<Team>> Races)
        {
            Console.WriteLine("Ranks");
            foreach(var race in Races)
            {
                Ranks = new List<Team>();
                for(int i = 0; i < race.Count; i++)
                {
                    int rank = i +1;
                    for(int y = i ; y >= 0 && race[i].Position == race[y].Position; y--)
                    {
                        rank = y +1;
                    }
                    Team t = new Team();
                    t.TeamName = race[i].TeamName;
                    t.Position = rank;
                    Ranks.Add(t);
                    Console.WriteLine(t.TeamName + " - " + t.Position);
                }
                Console.WriteLine();
            }
        }
    }
}
