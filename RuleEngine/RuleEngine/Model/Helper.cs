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

        public static int PointArray(int i)
        {
            switch (i)
            {
                case (1):
                    return 1;
                case (2):
                    return 3;
                case (3):
                    return 5;
                default :
                    return i + 3;
            }

        }

        public static int ParseStringToInt(string text)
        {
            int pos = 15;
            int.TryParse(text, out pos);
            return pos;
        }
    }
}
