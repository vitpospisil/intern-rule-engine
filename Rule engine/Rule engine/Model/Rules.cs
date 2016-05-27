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
                if (f.Position != 0)
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
            teams = teams.OrderBy(i => i.Position).ToList();
            int counterOfTeamsWithSamePosition = 1;
            for (int i = 0; i < teams.Count; i += counterOfTeamsWithSamePosition)
            {
                counterOfTeamsWithSamePosition = 1;
                for (int y = i + 1; y < teams.Count; y += 1)
                {
                    if (teams[i].Rank == teams[y].Rank)
                    {
                        counterOfTeamsWithSamePosition += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                decimal points = GetPoints(i + 1, i + counterOfTeamsWithSamePosition);

                for(int j = i; j < i + counterOfTeamsWithSamePosition; j += 1)
                {
                    teams[j].Points = points;
                }
                //Console.WriteLine("points: {0}, i: {1}, counter: {2}", points, i, counterOfTeamsWithSamePosition);
            }

            Console.WriteLine();

        }

        public static decimal GetPoints(int from, int to)
        {
            decimal result = 0;
            for (int i = from; i <= to; i += 1)
            {
                result += i;
            }
            decimal count = to - from + 1;
            return result / count;
        }

    }
}
