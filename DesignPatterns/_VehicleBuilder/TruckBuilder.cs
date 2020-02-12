using System;
using System.Collections.Generic;

namespace DesignPatterns._VehicleBuilder
{
    public class TruckBuilder : VehicleBuilder
    {
        public TruckBuilder()
        {
            vehicle = new Vehicle("Truck");
        }
        
        public override void BuildFrame()
        {
            vehicle["frame"] = "Truck Frame";
        }
        
        public override void BuildEngine()
        {
            vehicle["engine"] = "200 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "2";
        }
    }
}