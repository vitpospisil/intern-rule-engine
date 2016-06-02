using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Helper
    {
        public static int ParseStringToInt(string text)
        {
            int pos = 15;
            int.TryParse(text, out pos);
            return pos;
        }
    }
}
