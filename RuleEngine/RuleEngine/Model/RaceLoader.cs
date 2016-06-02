using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RuleEngine.Model
{
    class RaceLoader
    {

        public static Race ReadRace(string filename)
        {
            IEnumerable<string> data = File.ReadLines(filename);
            Race r = new Race();
            int lineNumber = 1;
            foreach (string line in data)
            {

                string[] items = line.Split(',');
                if (lineNumber != 1)
                {
                    Team t = new Team();
                    t.TeamName = items[0];
                    t.Position = Helper.ParseStringToInt(items[1]);
                    r.Teams.Add(t);
                }
                lineNumber++;
            }
            return r;
        }
    }
}
