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
            double points = 0;


            teams = teams.OrderBy(i => i.Position).ToList();
            for(int i = 0; i < teams.Count; i += 1)
            {
                int counterOfTeamsWithSamePosition = 0;
                for (int y = i + 1; y < teams.Count; y += 1)
                {
                    if (teams[i].Position == teams[y].Position)
                    {
                        counterOfTeamsWithSamePosition += 1;
                    }
                    else
                    {
                        break;
                    }

                }
               teams[i].Points = points;
               // Console.WriteLine(teams[i].Name + " has " + teams[i].Points + " points");
            }
            
            Console.WriteLine();
            GetPoints(1, 1);
        }

        public static decimal GetPoints(int from, int to)
        {
            //teams = teams.OrderBy(i => i.Position).ToList();
            //CalculatePoints(teams);
            //decimal getPoints = 0;
            //int previousPosition = -1;
            //for(int i = 0; i < teams.Count; i += 1)
            //{
            //    if(teams[i].Position == previousPosition)
            //    {
            //        getPoints = (teams[i].Position + teams[i + 1].Position + 1) / 2m;
            //    }
            //    if(teams[i].Position != previousPosition)
            //    {
            //        getPoints = teams[i].Position;
            //    }
            //    previousPosition = teams[i].Position;
            //}
            //return getPoints;

            decimal getPoints = 0;
            from = 1;
            to = 2;
            getPoints = (from + to) / 2m;
            return getPoints;
        }

    }
}
