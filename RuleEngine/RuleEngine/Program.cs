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
            data.GetData();
            data.Sort();
            Rank.GetRank(data.Races);
            foreach(var race in data.Races)
            {
                foreach(var team in race)
                {
                    Console.WriteLine(team.TeamName + " - " + team.Position + ". position " + " rank - " + team.Rank + " with " + team.Points + " points");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
