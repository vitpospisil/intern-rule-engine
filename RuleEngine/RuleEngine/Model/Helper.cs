using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Helper
    {
        public static List<Team> Sort(List<Team> race)
        {
            return race.OrderBy(x => x.Position).ToList();
        }
    }
}
