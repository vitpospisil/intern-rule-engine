using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule_engine.Model
{
    public class Team
    {
        public int Position { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public double Points { get; set; }
        

        public Team(string name, int position)
        {
            Name = name;
            Position = position;
        }

    }

}
