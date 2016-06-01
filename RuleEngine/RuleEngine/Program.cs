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
            data.GetData();
            data.Sort();
            Console.ReadKey();
        }
    }
}
