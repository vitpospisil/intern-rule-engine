﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RuleEngine.Model
{
    class Data
    {
        List<Stream> DataList = new List<Stream>();
        public List<List<Race>> Races = new List<List<Race>>();
        public void GetData()
        {
            DataList.Add(File.OpenRead(@"C:\Users\Vítek\ST_SW\intern-rule-engine\data1\race1.csv"));
            DataList.Add(File.OpenRead(@"C:\Users\Vítek\ST_SW\intern-rule-engine\data1\race2.csv"));
            DataList.Add(File.OpenRead(@"C:\Users\Vítek\ST_SW\intern-rule-engine\data1\race3.csv"));
            foreach (Stream data in DataList)
            {
                StreamReader reader = new StreamReader(data);
                List<Race> Teams = new List<Race>();
                int lineNumber = 1;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] items = line.Split(',');
                    if (lineNumber != 1)
                    {
                        Race t = new Race();
                        t.TeamName = items[0];
                        t.SetPosition(items[1]);
                        Teams.Add(t);
                    }
                    lineNumber++;
                }
                Races.Add(Teams);
            }
            foreach(List<Race> race in Races)
            {
                foreach(Race team in race)
                {
                    Console.WriteLine(team.TeamName + " - " + team.Position);
                }
                Console.WriteLine();
            }
        }
    }
}