using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
   
    class Points
    {
        public static void CalculatePoints(List<Team> teams, Func<int, int> pointSystemDelegate)
        {
            foreach(var team in teams.OrderBy(x => x.Rank))
            {
                decimal count = 0m;
                for(int i = 0; i < teams.Count; i++)
                {
                    if(team.Rank == teams[i].Rank)
                    {
                        count++;
                    }
                }
                int rank = pointSystemDelegate(team.Rank);
                for(int i = 1; i < count; i++)
                {
                    rank += pointSystemDelegate(team.Rank + i);
                }
                team.Points = rank / count;
            }
        }
    }
}
