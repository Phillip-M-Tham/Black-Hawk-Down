using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHawkDown
{
    class Vehicles
    {
        public string name;
        public string status;
        public int coordinatex;
        public int coordinatey;
        public Person Operator;
        public Person AOperator;

        public void move(int x, int y, string[,] AO)
        {
            if (status != "destroyed")
            {
                //moves the aircraft x y coordinates and removes previous location on map
                AO[this.coordinatex, this.coordinatey] = "";
                status = "moving";
                coordinatex = x;
                coordinatey = y;
                AO[this.coordinatex, this.coordinatey] = $"{name}";
                if (AOperator != null)
                {
                    AOperator.coordinatex = x;
                    AOperator.coordinatey = y;
                }
                if (Operator != null)
                {
                    Operator.coordinatex = x;
                    Operator.coordinatey = y;
                }
                Console.WriteLine($"{name} is {status} to {x},{y}");
            }
            else
            {
                Console.WriteLine($"{name} is destroyed");
            }
        }

        public virtual void start()
        {
            if (status != "destroyed")
            {
                status = "start engine";
                Console.WriteLine($"{name} is {status}");
            }
            else
            {
                Console.WriteLine($"{name} is destroyed");
            }
        }

        public virtual void stop()
        {
            if (status != "destroyed")
            {
                status = "stop engine";
                Console.WriteLine($"{name} is {status}");
            }
            else
            {
                Console.WriteLine($"{name} is destroyed");
            }
        }
        public void mountO(Person driver, string[,] AO)
        {
            if (status != "destroyed")
            {
                //checks if the person you want to mount can mount vec
                if (Operator == null)
                {
                    //adds driver to vec class, sets the vec of the person to the vec they get into
                    Operator = driver;
                    driver.myvec = this;
                    AO[driver.coordinatex, driver.coordinatey] = "";
                    driver.coordinatex = this.coordinatex;
                    driver.coordinatey = this.coordinatey;
                    Console.WriteLine($"{driver.name} is operating {name}");
                }
                else
                {
                    Console.WriteLine($"This seat is taken in {name}");
                }
            }
            else
            {
                Console.WriteLine($"{name} is destroyed");
            }
        }
        public void mountA(Person Adriver, string[,] AO)
        {
            if (status != "destroyed")
            {
                if (AOperator == null)
                {
                    AOperator = Adriver;
                    AO[Adriver.coordinatex, Adriver.coordinatey] = "";
                    Adriver.myvec = this;
                    Adriver.coordinatex = this.coordinatex;
                    Adriver.coordinatey = this.coordinatey;
                    Console.WriteLine($"{Adriver.name} is A driving {name}");
                }
                else
                {
                    Console.WriteLine($"This seat is taken in {name}");
                }
            }
            else
            {
                Console.WriteLine($"{name} is destroyed");
            }
        }
        public void dismountO(Person driver, string[,] AO)
        {
            //Sets the driver to null, sets the persons myvec to null, updates the persons x,y position
            if (status != "destroyed")
            {
                if (Operator.name == driver.name)
                {
                    Operator = null;
                    driver.myvec = null;
                    AO[driver.coordinatex, driver.coordinatey] = "";
                    //offsets the person getting out near the vehicle they were in
                    driver.coordinatex = this.coordinatex + 1;
                    driver.coordinatey = this.coordinatey + 1;
                    Console.WriteLine($"{driver.name} got out of {name}");
                }
                else
                {
                    Console.WriteLine($"{driver.name} is not in {name}");
                }
            }
            else
            {
                Console.WriteLine($"{name} is destroyed");
            }
        }
        public void dismountA(Person Adriver, string[,] AO)
        {
            if (status != "destroyed")
            {
                if (AOperator.name == Adriver.name)
                {
                    AOperator = null;
                    Adriver.myvec = null;
                    AO[Adriver.coordinatex, Adriver.coordinatey] = "";
                    Adriver.coordinatex = this.coordinatex + 1;
                    Adriver.coordinatey = this.coordinatey + 1;
                    Console.WriteLine($"{Adriver} is got out");
                }
                else
                {
                    Console.WriteLine($"{Adriver.name} is not in {name}");
                }
            }
            else
            {
                Console.WriteLine($"{name} is destroyed");
            }
        }
        public void idle()
        {
            if (status != "destroyed")
            {
                status = "idle";
                Console.WriteLine($"{name} is {status}");
            }
            else
            {
                Console.WriteLine($"{name} is destroyed");
            }
        }

        public void destroyed(string[,] AO)
        {
            if (status != "destroyed")
            {
                //might need to make this virtual to kill everyone inside of a destroyed vec
                if (this.Operator != null)
                {
                    this.Operator.KIA(AO);
                }
                if (this.AOperator != null)
                {
                    this.AOperator.KIA(AO);
                }
                status = "destroyed";
                AO[this.coordinatex, this.coordinatey] = "CS";
                Console.WriteLine($"{name} is {status}");
            }
            else
            {
                Console.WriteLine($"{name} is destroyed");
            }
        }
    }
}
