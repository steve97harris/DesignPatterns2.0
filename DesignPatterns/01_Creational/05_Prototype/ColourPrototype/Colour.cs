using System;
using System.Collections.Generic;

namespace DesignPatterns._ColourPrototype
{
    public class Colour : ColourPrototype
    {
        private int red;
        private int green;
        private int blue;
        private int yellow;

        // Constructor 
        public Colour(int red, int green, int blue, int yellow)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.yellow = yellow;
        }

        public override ColourPrototype Clone()
        {
            Console.WriteLine("Cloning colour RGB: {0,3},{1,3},{2,3},{3,3}", red, green, blue, yellow);
            return this.MemberwiseClone() as ColourPrototype;
        }
    }
}