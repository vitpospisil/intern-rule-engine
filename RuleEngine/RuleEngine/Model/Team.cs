using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Team
    {
        public string TeamName { get; set; }
        public int Position { get; private set; }
        public int Rank { get; set; }
        public void SetPosition(string position)
        {
            int pos = 0;
            int.TryParse(position, out pos);
            Position = pos;
        }
    }
}
