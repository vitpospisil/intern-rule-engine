using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuleEngine.Model;

namespace RuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Race> races = new List<Race>();
            races.Add(RaceLoader.ReadRace(@"C:\Users\Vítek\ST_SW\intern-rule-engine\data1\race1.csv"));
            races.Add(RaceLoader.ReadRace(@"C:\Users\Vítek\ST_SW\intern-rule-engine\data1\race2.csv"));
            races.Add(RaceLoader.ReadRace(@"C:\Users\Vítek\ST_SW\intern-rule-engine\data1\race3.csv"));
            foreach (Race r in races)
            {
                r.Teams = Helper.Sort(r.Teams);
                Rank.CalculateRank(r.Teams);
                Points.CalculatePoints(r.Teams);
                foreach (var team in r.Teams)
                {
                    Console.WriteLine(team.TeamName + " - " + team.Position + ". position " + " rank - " + team.Rank + " with " + team.Points + " points");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
