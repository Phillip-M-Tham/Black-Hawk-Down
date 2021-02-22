using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHawkDown
{
    class Insurgent : Person
    {
        public Insurgent(string name)
        {
            base.name = name;
            status = "Alive";
            Console.WriteLine($"{base.name} is {status}");
        }
    }
}
