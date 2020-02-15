using System;
using System.Collections.Generic;

namespace DesignPatterns._Flyweight.Flyweight01_CarFactory
{
    // Anything that will be cached is flyweight.

    public class Flyweight
    {
        private Car sharedState;

        public Flyweight(Car car)
        {
            
        }

        public void Operation(Car uniqueState)
        {
            
        }
    }
} 