using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Summary
    {
        public static void CalculateSummary(List<Race> races)
        {
            List<Team> FinalStats = new List<Team>();
            for (int i = 0; i < races[0].Teams.Count; i++)
                {
                    FinalStats.Add(races[0].Teams[i]);
                    FinalStats[i].ID = races[0].Teams[i].ID;
                }
            foreach(Race teams in races)
            {
                for(int i = 0; i < FinalStats.Count; i++)
                {
                    FinalStats[i].Points += teams.Teams[i].Points;
                }
            }
            foreach(Team team in FinalStats)
            {
                Console.WriteLine(team.ID + " " + team.Position);
            }
        }
    }
}
