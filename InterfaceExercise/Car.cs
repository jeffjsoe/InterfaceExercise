
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car:IVehicle,ICompany
    {

        public bool hastrunk { get; set; }

        public string name { get; set; }
        public int NumberOfWheels { get ; set ; }
        public bool hasengine { get ; set ; }
        public int numberofseats { get ; set ; }
        public bool hasAC { get ; set ; }
        public string Logo { get ; set ; }
        public int revenue { get ; set ; }

        public void Common()
        {
            Console.WriteLine($"It is {hastrunk}, it has a trunk.");
        }

        public void tester()
        {
            Console.WriteLine($"The logo is {Logo}");

        }


    }
}
