using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHawkDown
{
    class Ranger : Person
    {
        private string _rank;
        public Ranger(string name)
        {
            base.name = name;
            status = "Alive";
            _rank = "Pvt";
            Console.WriteLine($"{base.name} is {status}");
        }
        public void setRank(string rank)
        {
            _rank = rank;
        }
        public void Rappel(Blackhawk helo, string[,] AO)
        {
            helo.dismountBlackHawk(this, AO);
            myvec = null;
        }
    }
}
