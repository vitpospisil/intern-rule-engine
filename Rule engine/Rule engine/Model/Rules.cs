using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule_engine.Model
{
    public class Rules
    {
        public static void CalculatePoints(List<Team> teams)
        {
            int rank = 1;

            foreach(var f in teams.OrderBy(i => i.Position))
            {
                if (f.Position != 0)
                {
                    f.Rank = rank;
                    rank += 1;
            
                }
                while(f.Position != f.Rank)
                {
                    f.Rank -= 1;
                }


                Console.WriteLine( f.Name + " has " + f.Points.ToString() + " points");
            }
            Console.WriteLine();
        }

    }
}
