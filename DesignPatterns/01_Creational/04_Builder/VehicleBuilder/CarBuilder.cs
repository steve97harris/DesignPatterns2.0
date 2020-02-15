using System;
using System.Collections.Generic;

namespace DesignPatterns._VehicleBuilder
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }
        
        public override void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }
        
        public override void BuildEngine()
        {
            vehicle["engine"] = "250 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }
}