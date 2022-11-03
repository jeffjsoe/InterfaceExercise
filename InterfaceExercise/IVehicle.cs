//JESUS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
   public  interface IVehicle
    {


        public int NumberOfWheels { get; set; }

        public bool hasengine { get; set; }

        public int numberofseats   { get; set; }

        public bool hasAC { get; set; }

        public abstract void Common(); 

    }
}
