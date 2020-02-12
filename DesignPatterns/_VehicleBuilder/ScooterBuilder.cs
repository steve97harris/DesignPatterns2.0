using System;
using System.Collections.Generic;

namespace DesignPatterns._VehicleBuilder
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }
        
        public override void BuildFrame()
        {
            vehicle["frame"] = "Scooter Frame";
        }
        
        public override void BuildEngine()
        {
            vehicle["engine"] = "20 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
}