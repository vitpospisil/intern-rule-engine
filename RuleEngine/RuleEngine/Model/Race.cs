using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Race
    {
        public string TeamName { get; set; }
        public int Position { get; private set; }
        public void SetPosition(string position)
        {
            int pos = 0;
            int.TryParse(position, out pos);
            Position = pos;
        }
    }
}
