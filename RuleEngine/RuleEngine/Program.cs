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
            Rank rank = new Rank();
            data.GetData();
            data.Sort();
            rank.GetRank(data.Races);
            Console.ReadKey();
        }
    }
}
