using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Rank
    {
        public static void CalculateRank(List<Team> race)
        {
            for(int i = 0; i < race.Count; i++)
            {
                int rank = i +1;
                for(int y = i ; y >= 0 && race[i].Position == race[y].Position; y--)
                {
                    rank = y +1;
                }                    
                race[i].Rank = rank;
            }
        }
    }
}
