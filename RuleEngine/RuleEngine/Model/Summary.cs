using System.Collections.Generic;
using System.Linq;

namespace RuleEngine.Model
{
    class Summary
    {
        public static List<Team> CalculateSummary(List<Race> races)
        {
            Dictionary<string, decimal> FinalPoints = new Dictionary<string, decimal>();
            foreach(Race race in races)
            {
                foreach(Team team in race.Teams)
                {
                    if (FinalPoints.ContainsKey(team.ID))
                    {
                        FinalPoints[team.ID] += team.Points;
                    }
                    else
                    {
                        FinalPoints.Add(team.ID, team.Points);
                    }
                }
            }
            List<Team> FinalTeams = races[0].Teams;
            foreach(Team team in FinalTeams)
            {
                team.Points = FinalPoints[team.ID];
            }
            return FinalTeams.OrderBy(x => x.Points).ToList();
        }
    }
}
