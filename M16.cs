using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHawkDown
{
    class M16 : Firearm
    {
        private bool _silencer;
        private bool _m203;
        private bool _Acog;
        private bool _grip;
        private bool _peq15;
        public M16(string Name)
        {
            name = Name;
            status = "created";
            firingmode = "safe";
            caliber = "5.56x45";
            Console.WriteLine($"M16 {name} is {status}");
        }
        public void addattachment(string attach)
        {
            if (attach == "silencer")
            {
                _silencer = true;
                Console.WriteLine($"silencer has been attached to {name}");
            }
            else if (attach == "m203")
            {
                _m203 = true;
            }
            else if (attach == "Acog")
            {
                _Acog = true;
            }
            else if (attach == "grip")
            {
                _grip = true;
            }
            else if (attach == "peq15")
            {
                _peq15 = true;
            }
            else
            {
                Console.WriteLine("Thats not a correct attachment");
            }
        }
        public void removeattachment(string attach)
        {
            if (attach == "silencer")
            {
                _silencer = false;
            }
            else if (attach == "m203")
            {
                _m203 = false;
            }
            else if (attach == "Acog")
            {
                _Acog = false;
            }
            else if (attach == "grip")
            {
                _grip = false;
            }
            else if (attach == "peq15")
            {
                _peq15 = false;
            }
            else
            {
                Console.WriteLine("thats not a correct attachment");
            }
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
