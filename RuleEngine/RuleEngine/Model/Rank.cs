using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Rank
    {
        public void GetRank(List<List<Team>> Races)
        {
            foreach(var race in Races)
            {
                for(int i = 0; i < race.Count; i++)
                {
                    int rank = i +1;
                    for(int y = i ; y >= 0 && race[i].Position == race[y].Position; y--)
                    {
                        rank = y +1;
                    }
                    race[i].TeamName = race[i].TeamName;
                    race[i].Rank = rank;
                }
            }
        }
    }
}
