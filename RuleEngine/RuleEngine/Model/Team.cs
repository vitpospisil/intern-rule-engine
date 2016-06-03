
using System.Collections.Generic;

namespace RuleEngine.Model
{
    class Team
    {
        public string TeamName { get; set; }
        public int Position { get; set; }
        public int Rank { get; set; }
        public decimal Points { get; set; }
        public string ID { get; set; }
        public List<RaceResult> RaceResults = new List<RaceResult>();
    }
}
