//JESUS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck:IVehicle,ICompany
    {

        public bool hasbigtires { get; set; }

        public string name { get; set; }
        public int NumberOfWheels { get ; set ; }
        public bool hasengine { get ; set ; }
        public int numberofseats { get ; set ; }
        public bool hasAC { get ; set ; }
        public string Logo { get ; set ; }
        public int revenue { get ; set ; }

        public void Common()
        {
            Console.WriteLine($"It is {hasbigtires} it has big tires");
        }
    }
}
