using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule_engine.Model
{
    public class Rules
    {
        public static void CalculateRank(List<Team> teams)
        {
            int rank = 0;
            int previousposition = -1;
            int countOfTeamsWithSameRank = 0;
            foreach (var f in teams.OrderBy(i => i.Position))
            {
                if (f.Position > 0)
                {
                    if(f.Position == previousposition)
                    {
                        countOfTeamsWithSameRank += 1;
                    }
                    if (f.Position != previousposition)
                    {
                        rank = rank + 1 + countOfTeamsWithSameRank;
                        countOfTeamsWithSameRank = 0;
                    }
                    f.Rank = rank;
                }
                previousposition = f.Position;
                Console.WriteLine(f.Name + " has rank – " + f.Rank);
            }
            Console.WriteLine();
        }

        public static void CalculatePoints(List<Team> teams)
        {
            double previousSamePoints = -1;
            teams = teams.OrderBy(i => i.Position).ToList();
            foreach (var p in teams.OrderBy(i => i.Position))
            {
                
                if(p.Points > 0)
                {
                    if(p.Points != previousSamePoints)
                    {
                        p.Points += 1;
                    }
                    else if(p.Points == previousSamePoints)
                    {
                        p.Points = p.Points + 1 + p.Points;
                        p.Points = p.Points / 2;
                    }
                }

                p.Points = p.Rank;
                previousSamePoints = p.Points;

                Console.WriteLine(p.Name + " has " + p.Points + " points");


            }
            Console.WriteLine();
        }

    }
}
