using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._VehicleBuilder
{
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }

    public class Vehicle
    {
        private string vehicleType;
        private Dictionary<string, string> parts = new Dictionary<string, string>();
        
        // Constructor 
        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }
        
        // Indexer
        public string this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("Vehicle type: {0}", vehicleType);
            Console.WriteLine("Frame: {0}", parts["frame"]);
            Console.WriteLine("Engine: {0}", parts["engine"]);
            Console.WriteLine("Wheels: {0}", parts["wheels"]);
            Console.WriteLine("Doors: {0}", parts["doors"]);
        }
    }
}