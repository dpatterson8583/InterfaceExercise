using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
            //DONE: Create 2 Interfaces called IVehicle & ICompany
            //DONE: Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            /*DONE: Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */

            //In ICompany
            /*DONE: Create 2 members that are specific to each every company regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*DONE: Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * DONE: Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            // DONE:  Now, create objects of your 3 classes and give their members values;
            // DONE:  Creatively display and organize their values

            var car = new Car()
            {
                Name = "General Motors",
                Description = "The big car company in the USA",
                EngineSize = 3.5,
                Make = "Chevrolet",
                Model = "Volt",
                SeatCount = 5,
                TowingPackage = false,
                TrunkSize = 24.5
            };

            var SUV = new SUV()
            {
                Name = "Ford",
                Description = "A classic business institution",
                CargoHoldSize = 22.6,
                EngineSize = 4.6,
                Make = "Ford",
                Model = "Suburban",
                SeatCount = 8,
                TowingPackage = true,
            };

            var truck = new Truck()
            {
                Name = "American Motors",
                Description = "Is this a company?",
                BedSize = 100,
                EngineSize = 4.9,
                HeavyDutyTran = true,
                Make = "Dodge",
                Model = "RAM",
                SeatCount = 6,
            };

            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(SUV);

            foreach(var v in vehicles)
            {
                Console.WriteLine($"{v.GetType()}: {v.Make} {v.Model},\nEngine Size: {v.EngineSize}\nSeat Count: {v.SeatCount}");
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }
    }
}
