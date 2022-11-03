//JESUS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV:IVehicle,ICompany
    {
        public bool hasmorethan5seats { get; set; } //THis is true cause we set it inside the program
        public string name { get; set; }
        public bool hascargospace { get; set; }
        public int NumberOfWheels { get ; set ; }
        public bool hasengine { get ; set ; }
        public int numberofseats { get ; set ; }
        public bool hasAC { get ; set ; }
        public string Logo { get ; set ; }
        public int revenue { get ; set ; }

        public void Common()
        {
            //This runs and it will say that since it belongs to the type 
            Console.WriteLine($"It is {hascargospace} it has cargo space. It is also {hasmorethan5seats} it has more than 5 seats");
            
        }
    }
}
