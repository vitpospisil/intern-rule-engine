using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Points
    {
        public static void CalculatePoints(List<Team> race)
        {
            foreach(var team in race)
            {
                decimal count = 0m;
                for(int i = 0; i < race.Count; i++)
                {
                    if(team.Rank == race[i].Rank)
                    {
                        count++;
                    }
                }
                int rank = team.Rank;
                for(int i = 1; i < count; i++)
                {
                    rank += team.Rank + i;
                }
                team.Points = rank / count;
            }
        }
    }
}
