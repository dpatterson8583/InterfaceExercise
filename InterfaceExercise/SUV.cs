﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double SeatCount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double CargoHoldSize { get; set; }
        public bool TowingPackage { get; set; }
    }
}