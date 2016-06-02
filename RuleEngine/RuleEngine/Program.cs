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
            Data data = new Data();
            
            data.ReadData();
            foreach (Race r in data.Races)
            {
                Helper.Sort(r.race);
                Rank.CalculateRank(r.race);
                Points.CalculatePoints(r.race);
                foreach (var team in r.race)
                {
                    Console.WriteLine(team.TeamName + " - " + team.Position + ". position " + " rank - " + team.Rank + " with " + team.Points + " points");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
