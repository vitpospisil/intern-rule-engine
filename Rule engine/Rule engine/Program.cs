using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rule_engine.Model;

namespace Rule_engine
{
    class Program
    {
        static void Main(string[] args)
        {
            Races y = new Races();
            Console.WriteLine(y.PointsOfTeams()[0].ToString());
            Console.ReadKey();
        }
    }
}
