using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHawkDown
{
    class AK : Firearm
    {
        public AK(string Name)
        {
            name = Name;
            status = "created";
            firingmode = "safe";
            caliber = "7.62x39";
            Console.WriteLine($"AK {name} is {status}");
        }
        public override void changemode(int mode)
        {
            if (mode == 0)
            {
                firingmode = "safe";
                Console.WriteLine($"{Owner.name} set {name} to {firingmode}");
            }
            else if (mode == 2)
            {
                firingmode = "semi";
                Console.WriteLine($"{Owner.name} set {name} to {firingmode}");
            }
            else if (mode == 3)
            {
                firingmode = "auto";
                Console.WriteLine($"{ Owner.name} set {name} to {firingmode}");
            }
            else
            {
                Console.WriteLine("Thats not a correct number");
            }
        }
    }
}
