using System.Collections.Generic;
using System.Linq;

namespace RuleEngine.Model
{
    class Rank
    {
        public static void CalculateRank(List<Team> teams)
        {
            teams = teams.OrderBy(x => x.Position).ToList();
            for (int i = 0; i < teams.Count; i++)
            {
                int rank = i +1;
                for(int y = i ; y >= 0 && teams[i].Position == teams[y].Position; y--)
                {
                    rank = y +1;
                }
                teams[i].Rank = rank;
            }
        }
    }
}
