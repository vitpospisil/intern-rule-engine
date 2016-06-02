using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RuleEngine.Model
{
    class Data
    {
        List<IEnumerable<string>> DataList = new List<IEnumerable<string>>();
        public List<Race> Races = new List<Race>();
        Race r;
        public void ReadData()
        {
            DataList.Add(File.ReadLines(@"C:\Users\Vítek\ST_SW\intern-rule-engine\data1\race1.csv"));
            DataList.Add(File.ReadLines(@"C:\Users\Vítek\ST_SW\intern-rule-engine\data1\race2.csv"));
            DataList.Add(File.ReadLines(@"C:\Users\Vítek\ST_SW\intern-rule-engine\data1\race3.csv"));
            foreach (IEnumerable<string> data in DataList)
            {
                r = new Race();
                int lineNumber = 1;
                foreach (string line in data)
                {

                    string[] items = line.Split(',');
                    if (lineNumber != 1)
                    {
                        Team t = new Team();
                        t.TeamName = items[0];
                        t.SetPosition(items[1]);
                        r.race.Add(t);
                    }
                    lineNumber++;
                }
                Races.Add(r);
            }
        }
    }
}
