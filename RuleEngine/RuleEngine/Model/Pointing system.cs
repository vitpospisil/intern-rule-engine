using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine.Model
{
    class Pointing_system
    {
        public static int OwnPointingSystem(int i)
        {
            switch (i)
            {
                case (1):
                    return 1;
                case (2):
                    return 3;
                case (3):
                    return 5;
                default:
                    return i + 3;
            }

        }

        public static int BasicPointingSystem(int i)
        {
            return i;
        }
    }
}
