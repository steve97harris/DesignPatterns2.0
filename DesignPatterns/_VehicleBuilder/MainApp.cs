using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._VehicleBuilder
{
    public class MainApp
    {
        public static void Main()
        {
            VehicleBuilder builder;
            
            Shop shop = new Shop();
            
            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            
            builder = new TruckBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }
    }

    class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}