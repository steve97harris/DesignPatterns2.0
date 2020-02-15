using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns._Flyweight.Flyweight01_CarFactory
{
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] args)
        {
            
        }

        public string getKey(Car key)
        {
            List<string> elements = new List<string>();
            
            elements.Add(key.Model);
            elements.Add(key.Colour);
            elements.Add(key.Company);

            
            
            return string.Join("-", elements);
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = this.getKey(sharedState);


            return new Flyweight(sharedState);    // <<<<Change
        }

        public void listFlyweights()
        {
            
        }
    }
}