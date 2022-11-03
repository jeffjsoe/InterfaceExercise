
using InterfaceExercise;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces-Done

            //Create 2 Interfaces called IVehicle & ICompany-Done

            //Create 3 classes called Car , Truck , & SUV-Done

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.-Done
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company-Done
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class-Done
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car1 = new Car() { hasAC = false, Logo = "Horse", revenue = 1000000000, numberofseats = 2, hasengine = true, hastrunk = false, NumberOfWheels = 4, name = "ferrari" };


            


            Truck truck1 = new Truck() { hasAC = true, Logo = "Volvo", revenue = 2000000000, numberofseats = 3, hasengine = true, hasbigtires = true, name = "Volvo Truck", NumberOfWheels = 8 };

            Console.WriteLine($"It is {truck1.hasAC}. It has AC");
            SUV suv1 = new SUV() { hasAC = true, numberofseats = 8, NumberOfWheels = 4, hasengine = true, revenue = 1000000000, hascargospace = true, hasmorethan5seats = true, Logo = "Toyota symbol", };


            //Why do we call this method.
            //We cal this because if we jsut caleld commone it would not know which to print unless this goes through a forloop
            suv1.Common();

            var car = new List<IVehicle>();//WE used Ivehicle type because we were trying to find which type has the most amount of items which are common to it
            
            car.Add(suv1);
            car.Add(truck1);
            car.Add(car1);

            //So her3 since we created a method called tester. In order to access and call the method. We need to get the name of the object and called the method. 
            car1.tester();

            Console.WriteLine($"The logo for the {car1.name} is {car1.Logo}. Their revenue is {car1.revenue}. It is {car1.hastrunk} It does not have a trunk");
            Console.WriteLine($"The logo for the {truck1.name} is {truck1.Logo}. Their revenue is {truck1.revenue}. It is {truck1.hasbigtires} It has big tires. ");
            Console.WriteLine($"The logo for the suv is {suv1.Logo}. Their revenue is {suv1.revenue}. It is {suv1.hascargospace} It has cargo space. It is {suv1.hasmorethan5seats}. It has more than 5 seats.");
            foreach (var cars in car)
            {
                //This also lets us print out the other member which are only special to the objects in the other classes. 
                cars.Common();

                Console.WriteLine($"The number of wheels it has are {cars.NumberOfWheels}. It is {cars.hasengine} they all have a eingine. The seats these vehicles have are {cars.numberofseats}. It is {cars.hasAC}");

            }

           

         



    }   
    
    
    } 






}








